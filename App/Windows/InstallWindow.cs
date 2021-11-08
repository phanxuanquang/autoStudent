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
    public partial class InstallWindow : Form
    {
        public InstallWindow()
        {
            InitializeComponent();
        }

        // Test Function
        private void TestButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            softwareNameClock.Start();
            clock.Start();
        }

        // Windows State
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy tiến trình cài đặt?", "XÁC NHẬN HỦY CÀI ĐẶT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (this.Opacity > 0.0)
                {
                    Thread.Sleep(3);
                    this.Opacity -= 0.05;
                }
                this.Opacity = 0;
                this.Close();
            }
        }

        // Animation
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
