using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;
using KAutoHelper;
using System.ComponentModel;

namespace App.Frameworks
{
    public class Install
    {
       
        protected WebClient webClient = new WebClient();
        protected List<App.Models.Software> softwares;
        protected ProgressBar progressBar;
        int count = 0;
        int countInstall = 0;
        void InstallAll()
        {
            if (countInstall < softwares.Count)
            {
                Thread installAll = new Thread(
                  () => InstallApp(softwares[countInstall])
                  );
                installAll.IsBackground = true;
                installAll.Start();
                return;
            }
            MessageBox.Show("Đã cài đặt xong");
        }
        private void DownloadFile()
        {
            if (count < softwares.Count)
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadFileCompleted += client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(softwares[count].LinkDownload), @"D:\"+softwares[count].NameFileDownload);
                return;
            }

            // End of the download
            InstallAll();
        }
        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // handle error scenario
                throw e.Error;
            }
            if (e.Cancelled)
            {
                // handle cancelled scenario
            }
            count++;
            DownloadFile();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void InstallApp(App.Models.Software software)
        {
            int id = 0;
            if (!OpenProcess(software, ref id))
            {
                countInstall++;
                InstallAll();
                return;
            }
            while (true)
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfProc_Process WHERE IDProcess = " + id);
                ManagementObjectCollection collection = searcher.Get();
                ManagementObject queryObj = collection.Cast<ManagementObject>().First();
                if (Convert.ToDouble(queryObj["PercentProcessorTime"]) / Environment.ProcessorCount == 0)
                {
                    break;
                }
                Thread.Sleep(1000);
            }
            var mainP = AutoControl.FindWindowHandle(null, software.WindowsName);
            while (mainP == IntPtr.Zero)
            {
                Thread.Sleep(100);
                mainP = AutoControl.FindWindowHandle(null, software.WindowsName);
            }
            AutoControl.BringToFront(mainP);
            Thread.Sleep(500);
            if (mainP != IntPtr.Zero)
            {
                int i;
                for (i = 0; i < software.InstallControlHanders.Count; i++)
                {
                    if (software.InstallControlHanders[i].threadSleep == 50)
                    {
                        Thread.Sleep(software.InstallControlHanders[i].threadSleep);
                        switch (software.InstallControlHanders[i].keyPress)
                        {
                            case "ENTER":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_RETURN);
                                break;
                            case "TAB":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_TAB);
                                break;
                            case "UP":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_UP);
                                break;
                            case "SPACE":
                                {
                                    AutoControl.BringToFront(mainP);
                                    AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        List<Process> processes = GetChildProcesses(id);
                        if (processes.Count != 0)
                            id = processes[0].Id;
                        Thread.Sleep(1000);
                        try
                        {
                            while (true)
                            {
                                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfProc_Process WHERE IDProcess = " + id);
                                ManagementObjectCollection collection = searcher.Get();
                                ManagementObject queryObj = collection.Cast<ManagementObject>().First();
                                if (Convert.ToDouble(queryObj["PercentProcessorTime"]) / Environment.ProcessorCount == 0)
                                {
                                    break;
                                }
                                Thread.Sleep(1000);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("lỗi foreach");
                        }
                        switch (software.InstallControlHanders[i].keyPress)
                        {
                            case "ENTER":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_RETURN);
                                break;
                            case "TAB":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_TAB);
                                break;
                            case "UP":
                                AutoControl.SendKeyBoardPress(mainP, VKeys.VK_UP);
                                break;
                            case "SPACE":
                                {
                                    AutoControl.BringToFront(mainP);
                                    AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi cài");
            }
            Thread.Sleep(10);
            countInstall++;
            InstallAll();
        }
        bool OpenProcess(App.Models.Software software, ref int id)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"D:\" + software.NameFileDownload;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            p.StartInfo = startInfo;
            try
            {
                p.Start();
            }
            catch
            {
                MessageBox.Show("Lỗi khi mở file " + software.NameFileDownload);
                return false;
            }
            id = p.Id;
            return true;
        }
        List<Process> GetChildProcesses(int parentId)
        {
            var query = "Select * From Win32_Process Where ParentProcessId = "
                    + parentId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            var result = processList.Cast<ManagementObject>().Select(p =>
              Process.GetProcessById(Convert.ToInt32(p.GetPropertyValue("ProcessId")))).ToList();

            return result;
        }
    }
}
