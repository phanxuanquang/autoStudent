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
            ProgressWindow_Install progressWindow_Install = new ProgressWindow_Install(selectedSoftwareList);
            ExportData();
            progressWindow_Install.ShowDialog();
            this.Show();
        }

        private void ExportData()
        {
            if (Program.setting.dataExport == false) return;
            {
                if (Program.setting.RunDataExport(selectedSoftwareList, Program.setting.exportPath) == true)
                {
                    MessageBox.Show("Đã EXPORT dữ liệu cài đặt");

                }
            }
        }
    }
}
