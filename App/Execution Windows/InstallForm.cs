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
    public partial class InstallForm : BaseExecutionForm
    {
        public InstallForm()
        {
            InitializeComponent();
            softwareList = Program.software_Database;
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
                    ///Download
                    App.InstallUninstall.Download download = new InstallUninstall.Download();
                    App.InstallUninstall.Install install = new InstallUninstall.Install();
                    download.Start(softwareList, null, null, @"C:\");
                    Task.Factory.StartNew(() =>
                    {
                        while (!download.isCompleted())
                        {
                            Thread.Sleep(2000);
                        }
                        install.Start(softwareList, @"C:\");
                        while (!install.isCompleted())
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
