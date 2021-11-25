using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.InstallUninstall
{
    class GetPath
    {
        public class NewProcess
        {
            public string FileName;
            public string Arguments;
        }

        public static string GetFileName(Package item)
        {
            string fileName = GetURL(item);

            if (String.IsNullOrEmpty(Path.GetExtension(fileName)))
            {
                switch (item.Installer.Kind)
                {
                    case Kind.Msi:
                        fileName = item.Name + ".msi";
                        break;
                    default:
                        fileName = item.Name + ".exe";
                        break;
                }
            }
            else fileName = Path.GetFileName(fileName);

            return fileName;
        }

        public static string GetURL(Package item)
        {
            string url = "";
            if (String.IsNullOrEmpty(item.Installer.X8664))
            {
                url = item.Installer.X86;
            }
            else url = item.Installer.X8664;

            if (url.Contains("{{.version}}"))
            {
                url = url.Replace("{{.version}}", item.Version);
            }
            return url;
        }

        public static NewProcess CommandInstall(string value, Kind kindInstaller)
        {
            NewProcess newProcess = new NewProcess();
            if (newProcess != null)
            {
                switch (kindInstaller)
                {
                    case Kind.Advancedinstaller:
                        newProcess.FileName = value;
                        newProcess.Arguments = @"/i /q";
                        break;
                    case Kind.Appx:
                        newProcess.FileName = "powershell.exe";
                        newProcess.Arguments = String.Format("-command Add-AppxPackage -Path {0}", value);
                        break;
                    case Kind.AsIs:
                        newProcess.FileName = value;
                        newProcess.Arguments = @"/i /q";
                        break;
                    case Kind.Innosetup:
                        newProcess.FileName = value;
                        newProcess.Arguments = @"/norestart /sp- /verysilent /allusers";
                        break;
                    case Kind.Msi:
                        newProcess.FileName = "msiexec.exe";
                        newProcess.Arguments = String.Format("/qn /i {0} ALLUSERS=1 REBOOT=ReallySuppress", value);
                        break;
                    case Kind.Nsis:
                        newProcess.FileName = value;
                        newProcess.Arguments = @"/S /NCRC";
                        break;
                    case Kind.Squirrel:
                        newProcess.FileName = value;
                        newProcess.Arguments = @"--silent";
                        break;
                    case Kind.Custom:
                        break;
                    default:
                        newProcess = null;
                        break;
                }
            }
            return newProcess;
        }
    }
}
