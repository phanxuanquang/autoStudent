using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace App
{
    public partial class LoadindWindow : Form
    {
        bool isLoaded_Database = false, isLoaded_System = false;

        public LoadindWindow()
        {
            InitializeComponent();

            Program.software_Database = new List<Software>();
            Program.software_System = new List<Software>();

            dataLoading_clock.Start();

            loadFrom_Database();
            loadFrom_System();
        }

        // Progress Bar
        private void dataLoading_clock_Tick(object sender, EventArgs e)
        {
            dataLoadingProgressBar.Increment(1);
            if (dataLoadingProgressBar.Value >= dataLoadingProgressBar.Maximum && isLoaded_Database && isLoaded_System)
            {
                dataLoading_clock.Stop();
                this.Hide();
                MainUI mainUI = new MainUI();
                mainUI.ShowDialog();
            }
        }

        // Loading Functions
        private void loadFrom_Database()
        {
            // loading function
            // Nạp vào Program.software_Database
            isLoaded_Database = true;
        }
        private void loadFrom_System()
        {
            // loading function
            // Nạp vào  Program.software_Database
            isLoaded_System = true;
        }
    }
}
