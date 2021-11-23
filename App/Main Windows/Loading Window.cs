using Microsoft.Win32;
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
        List<string> keys = new List<string>() {
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
             @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };
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
            findInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            findInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            Program.software_System = Program.software_System.Where(s => !string.IsNullOrWhiteSpace(s.name)).Distinct().ToList();
            isLoaded_System = true;
        }

        private void findInstalledSofware(RegistryKey regKey, List<string> keys, List<Software> installed)
        {
            foreach (string key in keys)
            {
                try
                {
                    using (RegistryKey rk = regKey.OpenSubKey(key))
                    {
                        if (rk == null)
                        {
                            continue;
                        }
                        foreach (string skName in rk.GetSubKeyNames())
                        {
                            using (RegistryKey sk = rk.OpenSubKey(skName))
                            {
                                try
                                {
                                    installed.Add(new Software()
                                    {
                                        name = Convert.ToString(sk.GetValue("DisplayName")),
                                        version = Convert.ToString(sk.GetValue("DisplayVersion"))
                                    });
                                }
                                catch (Exception)
                                { }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
