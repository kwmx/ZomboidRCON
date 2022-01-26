using Downloader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZomboidRCON.UpdateSystem;
using ZomboidRCON.UpdateSystem.GithubApi;

namespace ZomboidRCON
{
    public partial class UpdateForm : Form
    {
        delegate void SetTextCallback(string text, Control control);
        delegate void SetVisibleCallback(bool isVisible, Control control);
        delegate void SetProgressBarValueCallback(int value, ProgressBar progressBar);

        Updator updator;
        Release release;
        Asset asset;
        public UpdateForm(Updator updator, Release release)
        {
            InitializeComponent();
            this.updator = updator;
            this.release = release;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            asset = updator.GetDownloadableAsset(release);
            if (string.IsNullOrWhiteSpace(release.body))
                detailsTxt.Text = "No details provided for the version";
            else
                detailsTxt.Text = release.body;
            sizeLbl.Text = BytesToMb(asset.size) + " mb";
            versionLbl.Text = release.tag_name;
            detailsTxt.ReadOnly = true;
        }
        private int BytesToMb(long bytes)
        {
            return (int)bytes / 1024 / 1024;
        }
        private void detailsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            StartUpdate();
            downloadBtn.Enabled = false;
        }
        private async void StartUpdate()
        {
            try
            {
                await updator.Update(release, true, downloadStarted,  chunkDownloaded, downloadProgress, downloadCompleted);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "ZomboidRCON");
            }
        }

        private void downloadCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            SetProgressBarValueCallback b = new SetProgressBarValueCallback(SetProgressBarValue);
            this.Invoke(b, new object[] { 100, downloadBar });
            SetTextCallback d = new SetTextCallback(SetText);
            this.Invoke(d, new object[] { "Installing...", updateLabel });
        }

        private void downloadProgress(object? sender, DownloadProgressChangedEventArgs e)
        {
            SetProgressBarValueCallback b = new SetProgressBarValueCallback(SetProgressBarValue);
            this.Invoke(b, new object[] { (int)e.ProgressPercentage, downloadBar });
            SetTextCallback d = new SetTextCallback(SetText);
            this.Invoke(d, new object[] { "Downloading update " + (int)e.ProgressPercentage + "% (" + BytesToMb(e.ReceivedBytesSize) + "/" + BytesToMb(e.TotalBytesToReceive) + ")...", updateLabel });
        }

        private void chunkDownloaded(object? sender, DownloadProgressChangedEventArgs e)
        {
            return;
        }

        private void downloadStarted(object? sender, DownloadStartedEventArgs e)
        {
            SetVisibleCallback d = new SetVisibleCallback(SetControlVisible);
            this.Invoke(d, new object[] { false, detailsTxt });
            this.Invoke(d, new object[] { true, downloadBar });
            SetTextCallback t = new SetTextCallback(SetText);

            this.Invoke(t, new object[] { "Downloading...", updateLabel });

            SetProgressBarValueCallback b = new SetProgressBarValueCallback(SetProgressBarValue);
            this.Invoke(b, new object[] { 0, downloadBar });            
        }
        private void SetText(string text, Control control)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, control });
            }
            else
            {
                control.Text = text;
            }
        }
        private void SetControlVisible(bool isVisible, Control control)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (control.InvokeRequired)
            {
                SetVisibleCallback d = new SetVisibleCallback(SetControlVisible);
                this.Invoke(d, new object[] { isVisible, control });
            }
            else
            {
                control.Visible = isVisible;
            }
        }
        private void SetProgressBarValue(int value, ProgressBar progressBar)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (progressBar.InvokeRequired)
            {
                SetProgressBarValueCallback d = new SetProgressBarValueCallback(SetProgressBarValue);
                this.Invoke(d, new object[] { value, progressBar });
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(updator.IsBusy) e.Cancel = true;
        }
    }
}
