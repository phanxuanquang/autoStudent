using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ProgressWindow_Install : ProgressWindow_Base
    {
        public ProgressWindow_Install(List<Package> listSoftware) : base(listSoftware)
        {
            InitializeComponent();

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
    }
}
