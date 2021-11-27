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
            if (progressBar != null)
            {
                progressBar.Value = e.ProgressPercentage;
            }
        }

        private void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                throw new Exception("Lỗi quá trình download");
            }
            else Downloads();
        }

        public void Start(List<Package> listSoftware, ProgressBar progressBar, Label fileDownload, string directoryFolderDownload)
        {
            this.listSoftware = listSoftware;
            this.directoryFolderDownload = directoryFolderDownload;
            this.fileDownload = fileDownload;
            this.progressBar = progressBar;
            if (this.progressBar != null)
            {
                this.progressBar.Maximum = 100;
            }
            this.index = -1;

            Downloads();
        }

        public void Pause()
        {
            client.CancelAsync();
        }

        public void Continue()
        {
            if (index > 0)
            {
                Downloads();
            }
        }

        private void Downloads()
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
                    if (!client.IsBusy)
                    {
                        string URL = GetPath.GetURL(listSoftware[index]);
                        string pathFile = Path.Combine(this.directoryFolderDownload, fileName);
                        if (!File.Exists(pathFile) && isAvailable(URL, 30000))
                        {
                            client.DownloadFileAsync(new Uri(URL), pathFile);
                        }
                        else Downloads();
                    }
                }
            }
        }

        private bool isAvailable(string url, int timeoutMS)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMS;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
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
