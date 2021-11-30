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
            softwareList = Program.software_System;
            loadSoftwareToGridView(softwareList);
        }

        protected override void exec()
        {
            Program.software_System = selectedSoftwareList;
            ProgressWindow_Uninstall progressWindow_Uninstall = new ProgressWindow_Uninstall(Program.software_System);
            progressWindow_Uninstall.ShowDialog();
            this.Show();
        }
    }
}
