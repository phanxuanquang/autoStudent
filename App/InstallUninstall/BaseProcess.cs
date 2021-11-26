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
    abstract class BaseProcess
    {
        protected List<Package> listSoftware;
        protected TrackingProcess tracking;
        protected int index;
        protected bool isContinue;

        public BaseProcess()
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

        protected abstract void isCompletedItem();

        protected bool CreateProcess(GetPath.NewProcess newProcess)
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
