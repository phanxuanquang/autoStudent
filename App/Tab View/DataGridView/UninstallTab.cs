using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class UninstallTab : BaseTab
    {
        public UninstallTab()
        {
            InitializeComponent();
            base.ImportSoftwareList_Button.Visible = false;
            init();
        }

        protected override void exec()
        {
            ProgressWindow_Uninstall progressWindow_Uninstall = new ProgressWindow_Uninstall(selectedSoftwareList, null);
            progressWindow_Uninstall.FormClosing += (sender, e) =>
            {
                LoadingWindow.LoadAfterDone();
                this.Parent.Controls.Remove(this);
            };
            progressWindow_Uninstall.Show();
        }

        protected override void init()
        {
            softwareList = Program.software_System;
            loadSoftwareToGridView(softwareList);
        }
    }
}
