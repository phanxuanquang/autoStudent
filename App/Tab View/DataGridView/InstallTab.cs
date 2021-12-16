using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class InstallTab : BaseTab
    {
        public InstallTab()
        {
            InitializeComponent();
            init();
        }

        protected override void exec()
        {
            if (!Directory.Exists(Program.setting.saveDownloadPath))
            {
                Directory.CreateDirectory(Program.setting.saveDownloadPath);
            }
            ExportData();
            List<Package> overlapList = LoadingWindow.GetOverlapSoftware(Program.software_System, selectedSoftwareList);
            //ProgressWindow_Install progressWindow_Install = new ProgressWindow_Install(selectedSoftwareList);

            //progressWindow_Install.FormClosing += (sender, e) =>
            //{
            //    LoadingWindow.LoadAfterDone();
            //    this.Parent.Controls.Remove(this);
            //};
            if (overlapList != null && overlapList.Count > 0)
            {
                OverlapTab overlapTab = new OverlapTab(overlapList, selectedSoftwareList);
                Program.mainUI.loadTab(overlapTab);
            }
            else
            {
                ProgressWindow_Install progressWindow_Install = new ProgressWindow_Install(selectedSoftwareList);
                progressWindow_Install.Show();
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
