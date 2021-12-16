using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace App
{
    class Startup
    {
        public readonly static string saveHistory = Application.StartupPath + @"\schedule.as";

        public static void WriteSchedule(List<string> installSoftwares, List<string> uninstallSoftwares)
        {
            if (HasScheduled())
            {
                File.Delete(saveHistory);
            }
            string dataPackage = GetData(installSoftwares, "INSTALL") + GetData(uninstallSoftwares, "UNINSTALL");
            File.WriteAllText(saveHistory, dataPackage, Encoding.UTF8);
            SetStartupEnviroment();
        }

        public static (bool, List<Package>, List<Package>) ReadSchedule()
        {
            List<string> install = null;
            List<string> uninstall = null;
            if (HasScheduled())
            {
                string[] listSoftware = File.ReadAllLines(saveHistory);
                int indexInstall = Array.IndexOf(listSoftware, "INSTALL");
                int indexUninstall = Array.IndexOf(listSoftware, "UNINSTALL");
                if (indexUninstall - indexInstall > 1)
                {
                    install = new List<string>();
                    for (int index = indexInstall + 1; index < indexUninstall; index++)
                    {
                        install.Add(listSoftware[index]);
                    }
                }
                if (listSoftware.Length - indexUninstall > 1)
                {
                    uninstall = new List<string>();
                    for (int index = indexUninstall + 1; index < listSoftware.Length; index++)
                    {
                        uninstall.Add(listSoftware[index]);
                    }
                }
                File.Delete(saveHistory);
                RemoveStartupEnviroment();
            }
            if (install == null && uninstall == null) return (false, null, null);
            return (true, install == null ? null : DataAccess.Instance.GetPackagesOfName(install), uninstall == null ? null : DataAccess.Instance.GetPackagesOfName(uninstall));
        }

        private static string GetData(List<string> packages, string nameField)
        {
            if (packages != null)
            {
                string data = nameField + "\n";
                for (int index = 0; index < packages.Count; index++)
                {
                    data += packages[index] + "\n";
                }
                return data;
            }
            return nameField + "\n";
        }

        private static bool HasScheduled()
        {
            return File.Exists(saveHistory);
        }

        private static void SetStartupEnviroment()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (registry.GetValue("autoStudent") == null)
            {
                registry.SetValue("autoStudent", Application.ExecutablePath);
            }
        }

        private static void RemoveStartupEnviroment()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (registry.GetValue("autoStudent") != null)
            {
                registry.DeleteValue("autoStudent", false);
            }
        }
    }
}
