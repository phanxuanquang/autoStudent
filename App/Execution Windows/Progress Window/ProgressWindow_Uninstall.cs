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
    public partial class ProgressWindow_Uninstall : ProgressWindow_Base
    {
        List<Package> SoftwareList;

        public ProgressWindow_Uninstall(List<Package> softwareList)
        {
            InitializeComponent();
            this.SoftwareList = softwareList;
            loadSoftwareToGridView(softwareList);
        }

        void uninstall(List<Package> softwareList)
        {
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
        protected void loadSoftwareToGridView(List<Package> softwareList)
        {
            processGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                processGridView.Rows.Add(softwareList[i].Displayname, false);
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
            if (processGridView.Columns[e.ColumnIndex].Name == "action" && processGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "false" && e.RowIndex >= 0)
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
