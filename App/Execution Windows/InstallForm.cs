using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class InstallForm : BaseExecutionForm
    {
        public InstallForm()
        {
            InitializeComponent();
            softwareList = Program.software_Database;
            loadSoftwareToGridView(softwareList);
        }

        protected override void exec()
        {
            Program.software_Database = selectedSoftwareList;

            App.InstallUninstall.Download download = new InstallUninstall.Download();
            App.InstallUninstall.BaseProcess install = new InstallUninstall.Install();

            download.Start(Program.software_Database, null, null, @"C:\");

            Task.Factory.StartNew(() =>
            {
                while (!download.isCompleted())
                {
                    Thread.Sleep(2000);
                }
                ((InstallUninstall.Install)install).Start(Program.software_Database, @"C:\");
                while (!install.isCompleted())
                {
                    Thread.Sleep(2000);
                }
            });
        }
    }
}
