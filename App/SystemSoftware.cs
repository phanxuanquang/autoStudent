using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public partial class SystemSoftware
    {
        public static readonly List<string> keys = new List<string>() {
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
             @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };
        public string DisplayName { get; set; }
        public string UninstallString { get; set; }
        public string Version { get; set; }
        // Tra ve 1 list phan mem da cai dat trong may ma app ho tro
        public static List<SystemSoftware> GetSupportedSoftwares(List<Package> packages, List<SystemSoftware> installed)
        {
            List<SystemSoftware> supportedsSoftwares = new List<SystemSoftware>();
            for (int i = 0; i < installed.Count; i++)
            {
                for (int j = 0; j < packages.Count; j++)
                {
                    if (installed[i].DisplayName == packages[j].Displayname)
                    {
                        if (packages[j].UninstallArgument != null)
                        {
                            for (int k = 1; k < packages[j].UninstallArgument.Count; k++)
                            {
                                installed[i].UninstallString += " " + packages[j].UninstallArgument[k];
                            }
                        }
                        supportedsSoftwares.Add(installed[i]);
                    }
                }
            }
            return supportedsSoftwares;
        }
        public static void FindInstalledSofware(RegistryKey regKey, List<string> keys, List<SystemSoftware> installed)
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
                                            installed.Add(new SystemSoftware() 
                                            { 
                                                DisplayName = displayName,
                                                Version = Convert.ToString(sk.GetValue("DisplayVersion")),
                                                UninstallString = Convert.ToString(sk.GetValue("UninstallString"))
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
    }
}
