using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.InstallUninstall
{
    class Uninstall
    {
        private List<Package> listSoftware;
        private List<string> UninstallString;
        private TrackingProcess tracking;
        private int index;
        private bool isContinue;

        public Uninstall()
        {
            tracking = new TrackingProcess();
        }

        public void Start(List<Package> listSoftware, List<string> UninstallString)
        {
            this.listSoftware = listSoftware;
            this.UninstallString = UninstallString;
            index = -1;
            isContinue = true;
            isCompletedItem(null, null);
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
                isCompletedItem(null, null);
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

        private void isCompletedItem(object sender, EventArgs e)
        {
            if (isContinue && listSoftware != null && UninstallString != null)
            {
                index++;
                if (listSoftware.Count > index)
                {
                    UninstallItem(GetPath.CommandInstall(UninstallString[index], listSoftware[index]));
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
                //tracking.Tracking(process.Id, isCompletedItem);
                return true;
            }
            return false;
        }
    }
}
