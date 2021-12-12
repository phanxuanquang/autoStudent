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
    public partial class UninstallForm : BaseExecutionForm
    {
        public UninstallForm()
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
                this.Close();
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
