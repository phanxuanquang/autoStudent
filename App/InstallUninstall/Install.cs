using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace App.InstallUninstall
{
    class Install
    {
        private List<Package> listSoftware;
        private string directoryFolderDownload;
        private TrackingProcess tracking;
        private int index;
        private bool isContinue;

        public Install()
        {
            tracking = new TrackingProcess();
        }

        public void Start(List<Package> listSoftware, string directoryFolderDownload)
        {
            this.listSoftware = listSoftware;
            this.directoryFolderDownload = directoryFolderDownload;
            index = -1;
            isContinue = true;
            isCompletedItem();
        }

        public void Pause()
        {
            isContinue = false;
        }

        public void Continue()
        {
            if (index > 0)
            {
                isContinue = true;
                isCompletedItem();
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

        private void isCompletedItem()
        {
            if (listSoftware != null && isContinue)
            {
                index++;
                MessageBox.Show(index.ToString());
                if (listSoftware.Count > index)
                {
                    if (InstallItem(GetPath.CommandInstall(directoryFolderDownload, listSoftware[index])))
                    {
                        Task.Factory.StartNew(() =>
                        {
                            while (!tracking.isCompleted)
                            {
                                Thread.Sleep(250);
                            }
                            isCompletedItem();
                        });
                    }
                    else
                    {
                        isCompletedItem();
                    }
                }
            }
        }

        private bool InstallItem(GetPath.NewProcess newProcess)
        {
            if (newProcess != null)
            {
                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = newProcess.FileName;
                processStartInfo.Arguments = newProcess.Arguments;
                processStartInfo.UseShellExecute = false;
                processStartInfo.Verb = "runas";
                process.StartInfo = processStartInfo;
                process.Start();
                tracking.Tracking(process.Id);
                return true;
            }
            return false;
        }
    }
}
