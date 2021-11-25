using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace App.InstallUninstall
{
    class Install
    {
        private List<Package> listSoftware;
        private string directoryFolderDownload;
        private TrackingProcess tracking;

        public Install(List<Package> listSoftware)
        {
            this.listSoftware = listSoftware;
            tracking = new TrackingProcess();
        }

        public void Start(string directoryFolderDownload)
        {
            this.directoryFolderDownload = directoryFolderDownload;
            if (Environment.Is64BitOperatingSystem)
            {
                for (int index = 0; index < listSoftware.Count; index++)
                {
                    GetPath.NewProcess item = GetPath.CommandInstall(Path.Combine(this.directoryFolderDownload, GetPath.GetFileName(listSoftware[index])), listSoftware[index].Installer.Kind);
                }
            }
            else
            {
                for (int index = 0; index < listSoftware.Count; index++)
                {

                }
            }
        }

        private void isCompletedItem(object sender, EventArgs e)
        {

        }
        private void InstallItem(GetPath.NewProcess newProcess)
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
                tracking.Tracking(process.Id, isCompletedItem);
            }
        }
    }
}
