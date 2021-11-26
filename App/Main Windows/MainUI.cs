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
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        //Anti Flickering
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
            {
                exitButton_Above.Hide();
                minimizeButton_Above.Hide();
                MainPanel.Left -= 831;
            }
            else
            {
                exitButton_Above.Show();
                minimizeButton_Above.Show();
                MainPanel.Left += 831;
            }
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            this.Hide();
            settingForm.ShowDialog();
            this.Show();
        }
    }
}
