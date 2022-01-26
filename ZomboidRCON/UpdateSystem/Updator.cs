using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ZomboidRCON.UpdateSystem.GithubApi;
using System.Text.Json;
using System.Diagnostics;
using Downloader;

namespace ZomboidRCON.UpdateSystem
{
    public class Updator
    {
        const string API_URL = "https://api.github.com/repos/%repo_name%/releases";
        Version version;
        string githubRepo;
        string assetName;
        string rootPath;
        bool includePrerelease, _checking = false, _updating = false;
        Action<bool, Release, string> beforeUpdate;
        public Updator(string githubRepo, string currentVersion, bool includePrerelease = false, string assetName = "", string rootPath = "", Action<bool, Release, string> beforeUpdateCallback = null)
        {
            if(!string.IsNullOrWhiteSpace(assetName))
            {
                string[] an = assetName.Split('.');
                if(an.Length < 2 || an[an.Length - 1].ToLower() != "zip") throw new Exceptions.InvalidAssetNameFormatException();
                this.assetName = assetName;
                if(string.IsNullOrWhiteSpace(rootPath)) this.rootPath = Directory.GetCurrentDirectory();
                else this.rootPath = rootPath;

            }
            try
            {
                version = new Version(currentVersion);

            }
            catch (Exceptions.InvalidVersionFormatException ex)
            {
                throw ex;
            }
            this.githubRepo = githubRepo;
            this.includePrerelease = includePrerelease;
            beforeUpdate = beforeUpdateCallback;
            Debug.Write("Updator: Version '" + version.ToString() + "'\n");
        }
        public async void CheckForUpdate(Action<UpdateResult> callback)
        {
            _checking = true;
            using (var httpClient = new HttpClient())
            {
                string url = API_URL.Replace("%repo_name%", githubRepo);
                try
                {
                    httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
                    string json = await httpClient.GetStringAsync(url);
                    List<Release> releases = JsonSerializer.Deserialize<List<Release>>(json);
                    if(releases == null)
                    {
                        callback(new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "Unable to fetch releases!",
                            Release = null
                        });
                        _checking = false;
                        return;
                    }
                    if(releases.Count < 1)
                    {
                        callback(new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "No releases were found!",
                            Release = null
                        });
                        _checking = false;
                        return;

                    }
                    else
                    {
                        for (int i = 0; i < releases.Count; ++i)
                        {
                            Release r = releases[i];
                            if (!includePrerelease && r.prerelease) continue;
                            Version rVersion = new(r.tag_name);
                            _checking = false;
                            if (rVersion > version)
                            {
                                callback(new UpdateResult
                                {
                                    UpdateStatus = UpdateStatus.UpdateNeeded,
                                    Message = "New release was found",
                                    Release = r
                                });
                                return;
                            }
                            else
                            {
                                callback(new UpdateResult
                                {
                                    UpdateStatus = UpdateStatus.Current,
                                    Message = "Using current version",
                                    Release = r
                                });
                                return;
                            }
                        }
                        
                    }
                } 
                catch (HttpRequestException ex)
                {
                    if(ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        callback(new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "Repo page not found ('" + githubRepo + "')",
                            Release = null
                        });
                    }
                    else callback(new UpdateResult
                    {
                        UpdateStatus = UpdateStatus.Error,
                        Message = ex.Message + " (" + url + ")",
                        Release = null
                    });
                    _checking = false;
                    return;
                }
                catch (Exception e)
                {
                    callback(new UpdateResult
                    {
                        UpdateStatus = UpdateStatus.Error,
                        Message = e.Message,
                        Release = null
                    });
                    _checking = false;
                    return;
                }
            }
            callback(new UpdateResult
            {
                UpdateStatus = UpdateStatus.Error,
                Message = "Unknown error has occured",
                Release = null
            });
            _checking = false;
        }
        public async Task<UpdateResult> CheckForUpdate()
        {
            _checking = true;
            using (var httpClient = new HttpClient())
            {
                string url = API_URL.Replace("%repo_name%", githubRepo);
                try
                {
                    httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
                    string json = await httpClient.GetStringAsync(url);
                    List<Release> releases = JsonSerializer.Deserialize<List<Release>>(json);
                    if (releases == null)
                    {
                        _checking = false;
                        return new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "Unable to fetch releases!",
                            Release = null
                        };
                    }
                    if (releases.Count < 1)
                    {
                        _checking = false;
                        return new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "No releases were found!",
                            Release = null
                        };

                    }
                    else
                    {
                        for (int i = 0; i < releases.Count; ++i)
                        {
                            Release r = releases[i];
                            if (!includePrerelease && r.prerelease) continue;
                            Version rVersion = new(r.tag_name);
                            _checking = false;
                            if (rVersion > version)
                            {
                                return new UpdateResult
                                {
                                    UpdateStatus = UpdateStatus.UpdateNeeded,
                                    Message = "New release was found",
                                    Release = r
                                };
                            }
                            else
                            {
                                return new UpdateResult
                                {
                                    UpdateStatus = UpdateStatus.Current,
                                    Message = "Using current version",
                                    Release = r
                                };
                            }
                        }

                    }
                }
                catch (HttpRequestException ex)
                {
                    _checking = false;
                    if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return new UpdateResult
                        {
                            UpdateStatus = UpdateStatus.Error,
                            Message = "Repo page not found ('" + githubRepo + "')",
                            Release = null
                        };
                    }
                    else return new UpdateResult
                    {
                        UpdateStatus = UpdateStatus.Error,
                        Message = ex.Message + " (" + url + ")",
                        Release = null
                    };
                }
                catch (Exception e)
                {
                    _checking = false;

                    return new UpdateResult
                    {
                        UpdateStatus = UpdateStatus.Error,
                        Message = e.Message,
                        Release = null
                    };
                }
            }
            _checking = false;
            return new UpdateResult
            {
                UpdateStatus = UpdateStatus.Error,
                Message = "Unknown error has occured",
                Release = null
            };
        }
        /// <summary>
        /// Get an asset file based on file name
        /// </summary>
        /// <param name="release">Release file containing the asset wanted</param>
        /// <returns>Asset file that will be downloaded if the asset was bassed to <seealso cref="Update(Release, EventHandler{DownloadStartedEventArgs},
        /// EventHandler{DownloadProgressChangedEventArgs}, EventHandler{DownloadProgressChangedEventArgs},
        /// EventHandler{System.ComponentModel.AsyncCompletedEventArgs})">Update</seealso> function</returns>
        public Asset GetDownloadableAsset(Release release)
        {
            foreach (Asset asset in release.assets)
            {
                if (asset.name == assetName)
                {
                    //Debug.WriteLine(asset.name + ": " + asset.download_count + " - " + asset.browser_download_url + " - ");
                    return asset;
                }
            }
            return null;
        }
        /// <summary>
        /// Download the release file
        /// </summary>
        /// <param name="toRelease"></param>
        /// <param name="OnDownloadStarted"></param>
        /// <param name="OnChunkDownloadProgressChanged"></param>
        /// <param name="OnDownloadProgressChanged"></param>
        /// <param name="OnDownloadFileCompleted"></param>
        /// <returns></returns>
        public async Task Update(Release toRelease, bool autoInstall, EventHandler<DownloadStartedEventArgs> OnDownloadStarted = null,
            EventHandler<DownloadProgressChangedEventArgs> OnChunkDownloadProgressChanged = null,
            EventHandler<DownloadProgressChangedEventArgs> OnDownloadProgressChanged = null,
            EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OnDownloadFileCompleted = null)
        {
            if (string.IsNullOrWhiteSpace(assetName) || string.IsNullOrWhiteSpace(GetFileFullPath)) return;
            if (IsBusy) return;
            _updating = true;
            Asset? downloadAsset = GetDownloadableAsset(toRelease);
            if (downloadAsset != null)
            {
                await Downloader.Download(GetFileFullPath, downloadAsset.browser_download_url, OnDownloadStarted, OnChunkDownloadProgressChanged, OnDownloadProgressChanged, OnDownloadFileCompleted);
                if(autoInstall)
                {
                    _updating = false;
                    InstallUpdate();
                    Environment.Exit(0);
                }
            }
            _updating = false;
        }
        public void InstallUpdate()
        {
            Debug.Write("\n" + GetBatchFilePath + "\n");
            Debug.Write("\n" + (string.IsNullOrWhiteSpace(assetName) || string.IsNullOrWhiteSpace(GetFileFullPath)) + "\n");
            Debug.Write("\n" + IsBusy + "\n");
            Debug.Write("\n" + !File.Exists(GetFileFullPath) + "\n");

            if (string.IsNullOrWhiteSpace(assetName) || string.IsNullOrWhiteSpace(GetFileFullPath)) return;
            if (IsBusy) return;
            if (!File.Exists(GetFileFullPath)) return;
            Debug.Write("\n" + GetBatchFilePath + "\n");
            using (FileStream fs = File.Create(GetBatchFilePath))
            {
                Byte[] contents = new UTF8Encoding(true).GetBytes(BatContent.Replace("%FILE_DIR%", GetFileFullPath));
                fs.Write(contents, 0, contents.Length);
                
            }
            Process.Start(GetBatchFilePath);
        }
        /// <summary>
        /// Check if an update check is currently running.
        /// </summary>
        public bool IsCheckingForUpdate { get { return _checking; } }
        /// <summary>
        /// Check if the system is currently updating the software (downloading / installing).
        /// </summary>
        public bool IsUpdating { get { return _updating;} }
        /// <summary>
        /// Check if the system is busy updating or checking for an update.
        /// </summary>
        public bool IsBusy { get { return _checking || _updating; } }
        /// <summary>
        /// Gets the download file full path
        /// </summary>
        public string GetFileFullPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(assetName)) return null;
                if (string.IsNullOrWhiteSpace(rootPath)) return assetName;
                if (rootPath[rootPath.Length - 1] == '\\' ||
                    rootPath[rootPath.Length - 1] == '/') return rootPath + assetName;
                return rootPath + "\\" + assetName;
            }
        }
        private string GetBatchFilePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(rootPath)) return "updator.bat";
                if (rootPath[rootPath.Length - 1] == '\\' ||
                    rootPath[rootPath.Length - 1] == '/') return rootPath + "updator.bat";
                return rootPath + "\\" + "updator.bat";
            }
        }
        private const string BatContent = @"
@echo off
:: --HAS ENDING BACKSLASH
set batdir=%~dp0
:: --MISSING ENDING BACKSLASH
:: set batdir=%CD%
setlocal
cd /d %~dp0
Call :UnZipFile ""%FILE_DIR%""
start ZomboidRCON.exe
(goto) 2>nul & del "" % ~f0""
:UnZipFile<newzipfile>
set vbs=""%batdir%\_.vbs""
if exist %vbs% del /f /q %vbs%
>%vbs%  echo Set fso = CreateObject(""Scripting.FileSystemObject"")
>>%vbs% echo If NOT fso.FolderExists(CreateObject(""Scripting.FileSystemObject"").GetParentFolderName(WScript.ScriptFullName)) Then
>>%vbs% echo fso.CreateFolder(CreateObject(""Scripting.FileSystemObject"").GetParentFolderName(WScript.ScriptFullName))
>>%vbs% echo End If
>>%vbs% echo set objShell = CreateObject(""Shell.Application"")
>>%vbs% echo set FilesInZip=objShell.NameSpace(%1).items()
>>%vbs% echo objShell.NameSpace(CreateObject(""Scripting.FileSystemObject"").GetParentFolderName(WScript.ScriptFullName)).CopyHere FilesInZip, 16
>>%vbs% echo Set fso = Nothing
>>%vbs% echo Set objShell = Nothing
cscript //nologo %vbs%
if exist %vbs% del /f /q %vbs%
";
    }
}
