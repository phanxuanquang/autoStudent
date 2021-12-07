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
            init();
        }

        protected override void exec()
        {
            ExportData();
            List<Package> overlapList = LoadingWindow.GetOverlapSoftware(Program.software_System, selectedSoftwareList);
            if (overlapList.Count != 0)
            {
                OverlapForm overlapForm = new OverlapForm(overlapList, selectedSoftwareList);
                overlapForm.ShowDialog();
            }
            else
            {
                ProgressWindow_Install progressWindow_Install = new ProgressWindow_Install(selectedSoftwareList);
                progressWindow_Install.ShowDialog();
                this.Close();
            }
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

        protected override void init()
        {
            softwareList = Program.software_Database;
            loadSoftwareToGridView(softwareList);
        }
    }
}
