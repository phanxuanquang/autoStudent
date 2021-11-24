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
        public readonly static string saveHistory = Application.StartupPath + @"\schedule.csv";

        public static void WriteSchedule(List<Package> softwares)
        {
            if (HasScheduled())
            {
                File.Delete(saveHistory);
            }
            else
            {
                File.Create(saveHistory);
            }
            SetStartupEnviroment();
        }

        public static List<Package> ReadSchedule()
        {
            if (HasScheduled())
            {
                List<Package> extractFile = new List<Package>();
                Package temp = new Package();
                string[] listSoftware = File.ReadAllLines(saveHistory);
                for (int index = 0; index < listSoftware.Count(); index++)
                {

                }
                File.Delete(saveHistory);
                RemoveStartupEnviroment();
                return extractFile;
            }
            return null;
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
