using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.InstallUninstall
{
    class Uninstall
    {
        private List<Package> listSoftware;
        private TrackingProcess tracking;
        private int index;
        private bool isContinue;

        public Uninstall()
        {
            tracking = new TrackingProcess();
        }

        public void Start(List<Package> listSoftware)
        {
            this.listSoftware = listSoftware;
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
            if (isContinue && listSoftware != null)
            {
                index++;
                MessageBox.Show(index.ToString());
                if (listSoftware.Count > index)
                {
                    if (UninstallItem(GetPath.CommandUninstall(listSoftware[index])))
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

        private bool UninstallItem(GetPath.NewProcess newProcess)
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
