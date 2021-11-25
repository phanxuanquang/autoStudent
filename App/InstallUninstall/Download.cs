using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace App.InstallUninstall
{
    class Download
    {
        private WebClient client;
        private List<Package> listSoftware;
        private ProgressBar progressBar;
        private Label fileDownload;
        private string directoryFolderDownload;
        private int index = -1;
        public Download()
        {
            client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.DownloadProgress);
            client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.DownloadCompleted);
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (this.listSoftware != null)
            {
                index++;
                if (listSoftware.Count > index)
                {
                    string fileName = GetPath.GetFileName(listSoftware[index]);
                    if (fileDownload != null)
                    {
                        this.fileDownload.Text = fileName;
                    }
                    client.DownloadFileAsync(new Uri(GetPath.GetURL(listSoftware[index])), Path.Combine(this.directoryFolderDownload, fileName));
                }
            }
        }

        public void Start(List<Package> listSoftware, ProgressBar progressBar, Label fileDownload, string directoryFolderDownload)
        {
            this.listSoftware = listSoftware;
            this.directoryFolderDownload = directoryFolderDownload;
            this.fileDownload = fileDownload;
            this.progressBar = progressBar;
            this.progressBar.Maximum = 100;
            this.index = -1;

            if (this.listSoftware != null)
            {
                index = 0;
                if (this.listSoftware.Count > index)
                {
                    string fileName = GetPath.GetFileName(listSoftware[index]);
                    if (fileDownload != null)
                    {
                        this.fileDownload.Text = fileName;
                    }
                    client.DownloadFileAsync(new Uri(GetPath.GetURL(listSoftware[index])), Path.Combine(this.directoryFolderDownload, fileName));
                }
            }
        }

        public bool isCompleted()
        {
            if (listSoftware != null)
            {
                return index == listSoftware.Count;
            }
            return true;
        }
    }
}
