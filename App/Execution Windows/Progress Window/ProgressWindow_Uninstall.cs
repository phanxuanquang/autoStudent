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
        private InstallUninstall.BaseProcess uninstall;
        public ProgressWindow_Uninstall(List<Package> listSoftware, OverlapTab overlapTab) : base(listSoftware, overlapTab)
        {
            InitializeComponent();

            base.softwareGridView.Columns.Add(base.NameSoftware);
            base.softwareGridView.Columns.Add(base.StatusProcess);
            base.softwareGridView.Columns.Add(base.ActionButton);

            LoadDataGridView();

            uninstall = new InstallUninstall.Uninstall();
            uninstall.Start(listSoftware);

            this.Shown += ProgressWindow_Uninstall_Shown;
        }

        private void ProgressWindow_Uninstall_Shown(object sender, EventArgs e)
        {
            this.Shown -= ProgressWindow_Uninstall_Shown;
            ToDo();
        }

        #region Overrided Functions
        protected override void LoadDataGridView()
        {
            if (base.listSoftware != null)
            {
                for(int index = 0; index < base.listSoftware.Count; index++)
                {
                    base.softwareGridView.Rows.Add(base.listSoftware[index].Displayname, GetImageStatus(StatusDataGridView.Ready), "HỦY");
                }
            }
        }

        protected override void ToDo()
        {
            Task.Factory.StartNew(() =>
            {
                int index = -1;
                while ((index = blackList.IndexOf(ActionProcess.None)) != -1)
                {
                    uninstall.RunProcess(index);
                    UpdateStatusProcess(index, StatusDataGridView.Uninstalling);
                    while (!uninstall.isCompleted)
                    {
                        Thread.Sleep(500);
                    }
                    UpdateStatusProcess(index, StatusDataGridView.Completed);
                    UpdateCompletedAmount(++countCompletedAmount, 0);
                    blackList[index] = ActionProcess.Done;
                }
                HasExitTodoTask = true;
            });
        }
        #endregion
    }
}
