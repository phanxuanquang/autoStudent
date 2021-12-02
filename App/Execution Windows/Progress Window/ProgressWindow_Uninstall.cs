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
        public ProgressWindow_Uninstall(List<Package> listSoftware) : base(listSoftware)
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

        protected override void LoadDataGridView()
        {
            if (base.listSoftware != null)
            {
                for(int index = 0; index < base.listSoftware.Count; index++)
                {
                    base.softwareGridView.Rows.Add(base.listSoftware[index].Displayname, null, "HỦY");
                }
            }
        }

        protected override void ToDo()
        {
            Task.Factory.StartNew(() =>
            {
                for (int index = 0; index < listSoftware.Count; index++)
                {
                    uninstall.RunProcess(index);
                    UpdateStatusProcess(index, StatusDataGridView.Uninstalling);
                    while (!uninstall.isCompleted)
                    {
                        Thread.Sleep(500);
                    }
                    UpdateStatusProcess(index, StatusDataGridView.Completed);
                    UpdateCompletedAmount(index + 1);
                }
            });
        }
    }
}
