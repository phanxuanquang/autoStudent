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
        private App.InstallUninstall.BaseProcess install;
        private App.InstallUninstall.Download download;
        public ProgressWindow_Install(List<Package> listSoftware) : base(listSoftware)
        {
            InitializeComponent();
            this.SuspendLayout();
            base.flowLayoutPanel1.Controls.RemoveAt(4);
            base.flowLayoutPanel1.Controls.RemoveAt(3);
            base.flowLayoutPanel1.Controls.Add(this.label1);
            base.flowLayoutPanel1.Controls.Add(this.guna2ProgressBar1);
            base.flowLayoutPanel1.Controls.Add(this.guna2Button1);
            base.flowLayoutPanel1.Controls.Add(base.cancelAll_Button);
            base.flowLayoutPanel1.Controls.Add(base.backgroundRunning_Button);

            base.softwareGridView.Columns.Add(base.NameSoftware);
            base.softwareGridView.Columns.Add(base.PercentDownload);
            base.softwareGridView.Columns.Add(base.StatusProcess);
            base.softwareGridView.Columns.Add(base.ActionButton);

            LoadDataGridView();
            this.ResumeLayout(false);

            install = new InstallUninstall.Install();
            download = new InstallUninstall.Download();
            ((InstallUninstall.Install)install).Start(listSoftware, Program.setting.saveDownloadPath);
            download.Start(listSoftware, Program.setting.saveDownloadPath);

            this.Shown += ProgressWindow_Install_Shown;
        }

        private void ProgressWindow_Install_Shown(object sender, EventArgs e)
        {
            this.Shown -= ProgressWindow_Install_Shown;
            ToDo();
        }

        protected override void LoadDataGridView()
        {
            if (base.listSoftware != null)
            {
                for (int index = 0; index < base.listSoftware.Count; index++)
                {
                    base.softwareGridView.Rows.Add(base.listSoftware[index].Displayname, "0%", null, "HỦY");
                }
            }
        }

        private void UpdatePercentProcess(int index, float value)
        {
            if (listSoftware != null && index > -1 && index < listSoftware.Count)
            {
                try
                {
                    guna2ProgressBar1.Value = Convert.ToInt32(value);
                    base.softwareGridView.Rows[index].Cells[1].Value = String.Format("{0}%", Math.Round(value, 2));
                }
                catch
                {
                    guna2ProgressBar1.BeginInvoke(new Action(() =>
                    {
                        guna2ProgressBar1.Value = Convert.ToInt32(value);
                    }));
                    base.softwareGridView.BeginInvoke(new Action(() =>
                    {
                        base.softwareGridView.Rows[index].Cells[1].Value = String.Format("{0}%", Math.Round(value, 2));
                    }));
                }
            }
        }

        protected override void ToDo()
        {
            Task.Factory.StartNew(() =>
            {
                for (int index = 0; index < listSoftware.Count; index++)
                {
                    download.DownloadsNext(index);
                    UpdateStatusProcess(index, StatusDataGridView.Downloading);
                    while (!download.isCompleted)
                    {
                        UpdatePercentProcess(index, download.GetPercentDownload);
                        Thread.Sleep(500);
                    }
                    if (download.isCanceled)
                    {
                        UpdateStatusProcess(index, StatusDataGridView.Canceled);
                        break;
                    }
                    if (download.HasException)
                    {
                        UpdateStatusProcess(index, StatusDataGridView.Failed);
                        break;
                    }
                    UpdatePercentProcess(index, 100.0f);
                    UpdateStatusProcess(index, StatusDataGridView.Installing);
                    install.RunProcess(index);
                    while (!install.isCompleted)
                    {
                        Thread.Sleep(1000);
                    }
                    UpdateStatusProcess(index, StatusDataGridView.Completed);
                    UpdateCompletedAmount(index + 1);
                }
            });
        }
    }
}
