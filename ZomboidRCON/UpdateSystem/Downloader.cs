using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Downloader;
namespace ZomboidRCON.UpdateSystem
{
    public static class Downloader
    {
        private static DownloadConfiguration GetConfig()
        {
            return new DownloadConfiguration()
            {
                BufferBlockSize = 10240, // usually, hosts support max to 8000 bytes, default values is 8000
                ChunkCount = 8, // file parts to download, default value is 1
                MaximumBytesPerSecond = 0, // download speed limit, default values is zero or unlimited
                MaxTryAgainOnFailover = int.MaxValue, // the maximum number of times to fail
                OnTheFlyDownload = false, // caching in-memory or not? default values is true
                ParallelDownload = true, // download parts of file as parallel or not. Default value is false
                TempDirectory = Path.GetTempPath(), // Set the temp path for buffering chunk files, the default path is Path.GetTempPath()
                Timeout = 1000, // timeout (millisecond) per stream block reader, default values is 1000
                RequestConfiguration = // config and customize request headers
                    {
                        Accept = "*/*",
                        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                        CookieContainer =  new CookieContainer(), // Add your cookies
                        Headers = new WebHeaderCollection(), // Add your custom headers
                        KeepAlive = false,
                        ProtocolVersion = HttpVersion.Version11, // Default value is HTTP 1.1
                        UseDefaultCredentials = false,
                        UserAgent = $"DownloaderSample/{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}"
                    }
            };

        }
        public static async Task Download(string fileFullPath, string downloadUrl,
            EventHandler<DownloadStartedEventArgs> OnDownloadStarted = null, EventHandler<global::Downloader.DownloadProgressChangedEventArgs> OnChunkDownloadProgressChanged = null,
            EventHandler<global::Downloader.DownloadProgressChangedEventArgs> OnDownloadProgressChanged = null, EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OnDownloadFileCompleted = null)
        {
            var downloader = new DownloadService(GetConfig());
            // Provide `FileName` and `TotalBytesToReceive` at the start of each downloads
            if(OnDownloadStarted != null)
                downloader.DownloadStarted += OnDownloadStarted;
            // Provide any information about chunker downloads, like progress percentage per chunk, speed, total received bytes and received bytes array to live streaming.
            if (OnChunkDownloadProgressChanged != null)
                downloader.ChunkDownloadProgressChanged += OnChunkDownloadProgressChanged;
            // Provide any information about download progress, like progress percentage of sum of chunks, total speed, average speed, total received bytes and received bytes array to live streaming.
            if (OnDownloadProgressChanged != null)
                downloader.DownloadProgressChanged += OnDownloadProgressChanged;
            // Download completed event that can include occurred errors or cancelled or download completed successfully.
            if (OnDownloadFileCompleted != null)
                downloader.DownloadFileCompleted += OnDownloadFileCompleted;
            await downloader.DownloadFileTaskAsync(downloadUrl, fileFullPath);
        }
    }
}

