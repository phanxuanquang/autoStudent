using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class UninstallForm : BaseExecutionForm
    {
        public UninstallForm()
        {
            InitializeComponent();
            softwareList = Program.software_System;
            loadSoftwareToGridView(softwareList);
        }

        protected override void exec()
        {
            softwareList = selectedSoftwareList;

            App.InstallUninstall.BaseProcess uninstall = new InstallUninstall.Uninstall();
            Task.Factory.StartNew(() =>
            {
                uninstall.Start(softwareList);
                while (!uninstall.isCompleted())
                {
                    Thread.Sleep(2000);
                }
            });
        }
    }
}
