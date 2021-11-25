using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace App.InstallUninstall
{
    class TrackingProcess
    {
        private string _pid;
        private int pidNewProcess;
        private bool running;
        public delegate void delegateAction(object sender, EventArgs e);
        private delegateAction actionComplete;
        private bool _isCompleted;
        private bool isCompleted
        {
            get
            {
                return _isCompleted;
            }
            set
            {
                if (_isCompleted)
                {
                    if (value != _isCompleted && actionComplete != null)
                    {
                        actionComplete(null, null);
                        running = false;
                        _isCompleted = false;
                    }
                }
                else _isCompleted = value;
            }
        }

        public void Tracking(int PID, delegateAction action)
        {
            _isCompleted = false;
            running = false;
            actionComplete = new delegateAction(action);
            this.pidNewProcess = PID;
            Start();
        }

        private void Start()
        {
            running = true;
            Task.Factory.StartNew(() =>
            {
                while (running)
                {
                    _pid = "";
                    SearchPID(ref _pid, this.pidNewProcess);
                    SearchPID(ref _pid, Process.GetCurrentProcess().Id);
                    Analyst();
                    Thread.Sleep(500);
                }
            });
        }

        private void SearchPID(ref string pid, int PID)
        {
            if (PID > 0)
            {
                string query = "SELECT * FROM Win32_Process WHERE ParentProcessId = " + PID;
                using (ManagementObjectSearcher seacher = new ManagementObjectSearcher(query))
                using (ManagementObjectCollection collection = seacher.Get())
                {
                    if (collection.Count > 0)
                    {
                        foreach (var item in collection)
                        {
                            pid += item.GetPropertyValue("ProcessID") + "\t";
                            SearchPID(ref pid, int.Parse(item.GetPropertyValue("ProcessID").ToString()));
                        }
                    }
                }
            }
        }

        private void Analyst()
        {
            if (String.IsNullOrEmpty(_pid))
            {
                isCompleted = false;
            }
            else isCompleted = true;
        }
    }
}
