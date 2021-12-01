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
    public partial class ProgressWindow_Uninstall : ProgressWindow_Base
    {
        public ProgressWindow_Uninstall(List<Package> listSoftware) : base(listSoftware)
        {
            InitializeComponent();

            base.softwareGridView.Columns.Add(base.NameSoftware);
            base.softwareGridView.Columns.Add(base.StatusProcess);
            base.softwareGridView.Columns.Add(base.ActionButton);

            LoadDataGridView();
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
    }
}
