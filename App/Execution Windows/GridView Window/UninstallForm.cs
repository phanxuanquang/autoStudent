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
            init();
        }

        protected override void exec()
        {
            ProgressWindow_Uninstall progressWindow_Uninstall = new ProgressWindow_Uninstall(selectedSoftwareList);
            progressWindow_Uninstall.ShowDialog();
            init();
            this.Show();
        }

        protected override void init()
        {
            softwareList = Program.software_System;
            loadSoftwareToGridView(softwareList);
        }
    }
}
