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
            base.processContainPanel.Controls.RemoveAt(5);
            base.processContainPanel.Controls.RemoveAt(4);
            base.processContainPanel.Controls.RemoveAt(3);
            base.processContainPanel.Controls.Add(this.label1);
            base.processContainPanel.Controls.Add(this.ThreadProgressBar);
            base.processContainPanel.Controls.Add(this.detail_Button);
            base.processContainPanel.Controls.Add(base.detail_Button);
            base.processContainPanel.Controls.Add(base.backgroundRunning_Button);
            base.processContainPanel.Controls.Add(base.ActionAll_Button);

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
            Program.SetDoubleBuffered(processContainPanel);
            Program.SetDoubleBuffered(this);
        }

        private void ProgressWindow_Install_Shown(object sender, EventArgs e)
        {
            this.Shown -= ProgressWindow_Install_Shown;
            if (wasRunBackground)
            {
                if (runBackground != null && isOverlap)
                {
                    runBackground.EnableRunBackground(Program.setting.timeSetter);
                }
            }
            ToDo();
        }

        #region Overrided Functions
        protected override void LoadDataGridView()
        {
            if (base.listSoftware != null)
            {
                for (int index = 0; index < base.listSoftware.Count; index++)
                {
                    base.softwareGridView.Rows.Add(base.listSoftware[index].Displayname, "0%", GetImageStatus(StatusDataGridView.Ready), "HỦY");
                }
            }
        }

        protected override void ToDo()
        {
            Task.Factory.StartNew(() =>
            {
                HasExitTodoTask = false;
                int index = -1;
                while ((index = blackList.IndexOf(ActionProcess.None)) != -1)
                {
                    download.DownloadsNext(index, blackList);
                    UpdateStatusProcess(index, StatusDataGridView.Downloading);
                    while (!download.isCompleted)
                    {
                        UpdatePercentProcess(index, download.GetPercentDownload);
                        UpdateCompletedAmount(countCompletedAmount, download.GetPercentDownload);
                        Thread.Sleep(250);
                    }
                    if (blackList[index] == ActionProcess.Canceled)
                    {
                        UpdateStatusProcess(index, StatusDataGridView.Canceled);
                        continue;
                    }
                    if (download.HasException)
                    {
                        UpdateStatusProcess(index, StatusDataGridView.Failed);
                        ActionButton_TextChanged(index, base.softwareGridView.Columns.Count - 1, ActionProcess.Canceled);
                        continue;
                    }
                    UpdatePercentProcess(index, 90.0f);
                    UpdateCompletedAmount(countCompletedAmount, 90.0f);
                    UpdateStatusProcess(index, StatusDataGridView.Installing);
                    install.RunProcess(index);
                    while (!install.isCompleted)
                    {
                        Thread.Sleep(1000);
                    }
                    UpdatePercentProcess(index, 100.0f);
                    UpdateStatusProcess(index, StatusDataGridView.Completed);
                    UpdateCompletedAmount(++countCompletedAmount, 0);
                    blackList[index] = ActionProcess.Done;
                }
                HasExitTodoTask = true;
            });
        }
        #endregion

        public void _SetListSoftware(List<Package> listSoftware)
        {
            base.SetListSoftware(listSoftware);
            base.softwareGridView.Rows.Clear();

            this.SuspendLayout();
            LoadDataGridView();
            this.ResumeLayout(false);
        }

        private void UpdatePercentProcess(int index, float value)
        {
            if (listSoftware != null && listSoftware.Count > 0 && index > -1 && index < listSoftware.Count)
            {
                try
                {
                    ThreadProgressBar.Value = Convert.ToInt32(value);
                    base.softwareGridView.Rows[index].Cells[1].Value = String.Format("{0}%", Math.Round(value, 2));
                }
                catch
                {
                    try
                    {
                        ThreadProgressBar.BeginInvoke(new Action(() =>
                        {
                            ThreadProgressBar.Value = Convert.ToInt32(value);
                        }));
                        base.softwareGridView.BeginInvoke(new Action(() =>
                        {
                            base.softwareGridView.Rows[index].Cells[1].Value = String.Format("{0}%", Math.Round(value, 2));
                        }));
                    }
                    catch { }
                }
            }
        }
    }
}
