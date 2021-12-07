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
using System.Runtime.InteropServices;

namespace App
{
    public partial class LoadingWindow : Form
    {
        bool isLoaded_Database = false, isLoaded_System = false;
        public static readonly List<string> keys = new List<string>() {
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
             @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };


        public LoadingWindow()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.mainIcon;

            Program.software_Database = new List<Package>();
            Program.software_System = new List<Package>();

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
                Program.mainUI = new MainUI();
                Program.mainUI.ShowDialog();
            }
        }

        // Loading Functions
        private void loadFrom_Database()
        {
            if (Environment.Is64BitOperatingSystem)
                Program.software_Database = DataAccess.Instance.GetX64();
            else Program.software_Database = DataAccess.Instance.GetX86();
            isLoaded_Database = true;
        }
        private void loadFrom_System()
        {
            GetInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            GetInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            Program.software_System = Program.software_System.Where(s => !string.IsNullOrWhiteSpace(s.Displayname)).Distinct().ToList();
            Program.software_System = GetSupportedSoftwares(Program.software_Database, Program.software_System);
            isLoaded_System = true;
        }
        public static List<Package> GetSupportedSoftwares(List<Package> packages, List<Package> installed)
        {
            List<Package> supportedsSoftwares = new List<Package>();
            for (int i = 0; i < installed.Count; i++)
            {
                for (int j = 0; j < packages.Count; j++)
                {
                    if (installed[i].Displayname.Contains(packages[j].Displayname))
                    {
                        Package temp = packages[j];
                        temp.Displayname = installed[i].Displayname;
                        temp.Version = installed[i].Version;
                        temp.UninstallString = installed[i].UninstallString;
                        supportedsSoftwares.Add(temp);
                    }
                }
            }
            return supportedsSoftwares;
        }

        public static void GetInstalledSofware(RegistryKey regKey, List<string> keys, List<Package> installed)
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
                                    if (sk != null)
                                    {
                                        string displayName = (string)sk.GetValue("DisplayName");
                                        if (displayName != null)
                                        {
                                            installed.Add(new Package()
                                            {
                                                Displayname = displayName,
                                                Version = Convert.ToString(sk.GetValue("DisplayVersion")),
                                                UninstallString = FixUninstallString(Convert.ToString(sk.GetValue("UninstallString")))
                                            });
                                        }
                                    }
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
        public static string FixUninstallString(string tmp)
        {
            if (tmp != null)
            {
                if (tmp.Contains("MsiExec"))
                {
                    if (tmp.Contains("/I"))
                    {
                        string newString = tmp.Replace("/I", "/x");
                        return newString;
                    }
                }
                else if (!tmp.Contains("\""))
                {
                    tmp = "\"" + tmp + "\"";
                }
            }
            return tmp;
        }

       public static void LoadAfterDone()
        {
            if (Environment.Is64BitOperatingSystem)
                Program.software_Database = DataAccess.Instance.GetX64();
            else Program.software_Database = DataAccess.Instance.GetX86();
            Program.software_System.Clear();
            GetInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            GetInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, Program.software_System);
            Program.software_System = Program.software_System.Where(s => !string.IsNullOrWhiteSpace(s.Displayname)).Distinct().ToList();
            Program.software_System = GetSupportedSoftwares(Program.software_Database, Program.software_System);
        }
    }
}
