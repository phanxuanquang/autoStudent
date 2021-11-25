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

        protected override void confirmButton_Click(object sender, EventArgs e)
        {
            if (selectedSoftwareList.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tiếp tục?", "TIẾP TỤC", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    softwareList = selectedSoftwareList;
                    ///Uninstall
                    App.InstallUninstall.Uninstall uninstall = new InstallUninstall.Uninstall();
                    Task.Factory.StartNew(() =>
                    {
                        uninstall.Start(softwareList);
                        while (!uninstall.isCompleted())
                        {
                            Thread.Sleep(2000);
                        }
                    });
                }
            }
            else MessageBox.Show("Bạn chưa chọn phần mềm nào");
        }
    }
}
