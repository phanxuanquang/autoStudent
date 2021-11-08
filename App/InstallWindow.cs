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
    public partial class InstallWindow : Form
    {
        public InstallWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            softwareNameClock.Start();
            clock.Start();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            ProgressBar.Increment(1);
        }

        private void softwareNameClock_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.ForeColor == Color.Cyan)
                ProgressBar.ForeColor = Color.White;
            else ProgressBar.ForeColor = Color.Cyan;
        }
    }
}
