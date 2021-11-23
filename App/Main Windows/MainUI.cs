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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        // Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        private void wizardButton_Click(object sender, EventArgs e)
        {
            if (MainPanel.Left >= 0)
                MainPanel.Left -= 831;
            else MainPanel.Left += 831;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            InstallForm installForm = new InstallForm();
            this.Hide();
            installForm.ShowDialog();
            this.Show();
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            UninstallForm unInstallForm = new UninstallForm();
            this.Hide();
            unInstallForm.ShowDialog();
            this.Show();
        }
    }
}
