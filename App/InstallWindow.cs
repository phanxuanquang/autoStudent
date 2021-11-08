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

        int r = 0;
        private void clock_Tick(object sender, EventArgs e)
        {
            ProgressBar.Increment(1);
            softwareName.ForeColor = Color.FromArgb(r, 255, 255);
            if (r <= 0)
                r += 25;
            if (r >= 224)
                r -= 25;
        }
    }
}
