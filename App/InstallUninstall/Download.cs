using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System;

namespace App.InstallUninstall
{
    class Download
    {
        private static HttpClient client;
        private List<Package> listSoftware;
        private ProgressBar progressBar;
        private Label fileDownload;
        private string directoryFolderDownload;
        private int index = -1;
        private bool isCancel;
        private const int step = 10;

        public Download()
        {
            client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(30);
        }

        public void Start(List<Package> listSoftware, ProgressBar progressBar, Label fileDownload, string directoryFolderDownload)
        {
            this.listSoftware = listSoftware;
            this.directoryFolderDownload = directoryFolderDownload;
            this.fileDownload = fileDownload;
            this.isCancel = false;
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
            isCancel = true;
        }

        public void Continue()
        {
            if (index > 0 && isCancel == true)
            {
                isCancel = false;
                Downloads();
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

        private async void Downloads()
        {
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
                        string URL = GetPath.GetURL(listSoftware[index]);
                        string pathFile = Path.Combine(this.directoryFolderDownload, fileName);
                        if (!File.Exists(pathFile))
                        {
                            using (HttpResponseMessage response = client.GetAsync(new Uri(URL), HttpCompletionOption.ResponseHeadersRead).Result)
                            {
                                HttpResponseMessage httpRequestMessage = response.EnsureSuccessStatusCode();
                                if (httpRequestMessage.IsSuccessStatusCode && long.TryParse(response.Content.Headers.SingleOrDefault(h => h.Key.Equals("Content-Length")).Value.First(), out long totalSize))
                                {
                                    try
                                    {
                                        using (Stream contentStream = await response.Content.ReadAsStreamAsync(), fileStream = new FileStream(pathFile, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                                        {
                                            var totalRead = 0L;
                                            var stepSegment = 0L;
                                            var buffer = new byte[8192];
                                            var isMoreToRead = true;

                                            do
                                            {
                                                if (!isCancel)
                                                {
                                                    var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                                                    if (read == 0)
                                                    {
                                                        isMoreToRead = false;
                                                    }
                                                    else
                                                    {
                                                        await fileStream.WriteAsync(buffer, 0, read);

                                                        totalRead += read;
                                                        stepSegment += 1;

                                                        if (progressBar != null)
                                                        {
                                                            if (stepSegment % step == 0)
                                                            {
                                                                progressBar.BeginInvoke(new Action(() =>
                                                                {
                                                                    progressBar.Value = Convert.ToInt32(totalRead * 100 / totalSize);
                                                                }));
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            while (isMoreToRead);
                                        }
                                        if (isCancel)
                                        {
                                            if (File.Exists(pathFile))
                                            {
                                                File.Delete(pathFile);
                                            }
                                            MessageBox.Show("Đã hủy");
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("tai xong" + index.ToString());
                                        }
                                    }
                                    catch (IOException)
                                    {
                                        MessageBox.Show("Bộ nhớ đầy");
                                    }
                                    catch (UnauthorizedAccessException)
                                    {
                                        MessageBox.Show("Không truy cập được");
                                    }
                                }
                            }
                            if (!isCancel)
                            {
                                Downloads();
                            }
                        }
                        else Downloads();
                    }
                }
            }
        }
    }
}