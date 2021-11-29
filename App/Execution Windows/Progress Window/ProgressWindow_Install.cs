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
    public partial class ProgressWindow_Install : ProgressWindow_Base
    {
        List<Package> SoftwareList;

        public ProgressWindow_Install(List<Package> softwareList)
        {
            InitializeComponent();
            this.SoftwareList = softwareList;
            loadSoftwareToGridView(softwareList);
        }

        void install(List<Package> softwareList)
        {
            App.InstallUninstall.Download download = new InstallUninstall.Download();
            App.InstallUninstall.BaseProcess install = new InstallUninstall.Install();

            download.Start(softwareList, null, null, @"C:\");

            Task.Factory.StartNew(() =>
            {
                while (!download.isCompleted())
                {
                    Thread.Sleep(2000);
                }
                ((InstallUninstall.Install)install).Start(softwareList, @"C:\");
                while (!install.isCompleted())
                {
                    Thread.Sleep(2000);
                }
            });
        }

        protected void loadSoftwareToGridView(List<Package> softwareList)
        {
            processGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                processGridView.Rows.Add(softwareList[i].Displayname, "0%", false);
            }
        }

        private void detail_Button_Click(object sender, EventArgs e)
        {
            if (!processGridView.Visible)
                processGridView.Visible = true;
            else processGridView.Visible = false;
        }

        private void processGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(processGridView.Columns[e.ColumnIndex].Name == "action" && processGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "0%" && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy trình cài đặt này?", "HỦY", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < SoftwareList.Count; i++)
                    {
                        if (SoftwareList[i].Displayname == processGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                        {
                            processGridView.Rows.Remove(processGridView.Rows[e.RowIndex]);
                            SoftwareList.RemoveAt(i);
                            loadSoftwareToGridView(SoftwareList);
                            return;
                        }
                    }
                }
                
            }
        }
    }
}
