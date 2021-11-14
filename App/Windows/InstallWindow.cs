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
using App.Models;
using System.Drawing;
using System.Net.Http;
using System.IO;

namespace App
{
    public partial class InstallWindow : Form
    {
        protected List<Software> softwares;
        protected WebClient client;
        int count = 0, countInstall = 0;
        public bool isComplete = false;

        public InstallWindow(List<Software> selectedInstall)
        {
            InitializeComponent();
            if (selectedInstall != null)
            {
                softwares = selectedInstall;
            }
            DownloadFile();
        }

        // Download
        public void DownloadFile()
        {
            if (count < softwares.Count && !System.IO.File.Exists(@"C:\" + softwares[count].NameFileDownload))
            {
                processLabel.Text += softwares[count].Name;
                client = new WebClient();
                client.Proxy = WebRequest.DefaultWebProxy;
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadFileCompleted += client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(softwares[count].LinkDownload), @"C:\" + softwares[count].NameFileDownload);
                return;
            }
            //End of the download
            processLabel.Text = "ĐANG CÀI";
            InstallAll();
        }
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                return;
            }
            count++;
            DownloadFile();
        }
        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            ProgressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        // Process Handling
        public bool OpenProcess(App.Models.Software software, ref int id)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\" + software.NameFileDownload;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            p.StartInfo = startInfo;
            p.StartInfo.Verb = "runas";
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
        public List<Process> GetChildProcesses(int parentId)
        {
            var query = "Select * From Win32_Process Where ParentProcessId = "
                    + parentId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            var result = processList.Cast<ManagementObject>().Select(p =>
              Process.GetProcessById(Convert.ToInt32(p.GetPropertyValue("ProcessId")))).ToList();

            return result;
        }

        // Install
        public void InstallAll()
        {
            if (countInstall < softwares.Count)
            {
                if (softwares[countInstall].Types == TypeOfFileInstall.exe)
                {
                    Thread installAll = new Thread
                    (
                        () => InstallEXE(softwares[countInstall])
                    );
                    installAll.IsBackground = true;
                    installAll.Start();
                }
                else if (softwares[countInstall].Types == TypeOfFileInstall.msi)
                {
                    Thread installAll = new Thread
                    (
                        () => InstallMSI(softwares[countInstall])
                    );
                    installAll.IsBackground = true;
                    installAll.Start();
                }
                return;
            }
            this.Close();
        }
        public void InstallEXE(App.Models.Software software)
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
                        AutoControl.BringToFront(mainP);
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
                            MessageBox.Show("Quá trình cài phần mềm " + softwares[countInstall].Name + " đã hủy");
                        }
                        //AutoControl.BringToFront(mainP);
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

        // Windows State

        public void InstallMSI(Software software)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "msiexec.exe";
            startInfo.Arguments = @"/i " + @"C:\" + software.NameFileDownload + " /quiet";
            p.StartInfo = startInfo;
            p.Start();
            int id = p.Id;
            while (true)
            {
                try
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
                catch
                {
                    break;
                }
            }
            Thread.Sleep(10);
            countInstall++;
            InstallAll();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "XÁC NHẬN HỦY CÀI ĐẶT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (this.Opacity > 0.0)
                {
                    Thread.Sleep(3);
                    this.Opacity -= 0.05;
                }
                this.Opacity = 0;
                if (client != null)
                    client.CancelAsync();
                this.Close();
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void InstallWindow_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void InstallWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void InstallWindow_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        // Animation
        private void softwareNameClock_Tick(object sender, EventArgs e)
        {
            if (processLabel.ForeColor == Color.Cyan)
                processLabel.ForeColor = Color.White;
            else processLabel.ForeColor = Color.Cyan;
            if (ProgressBar.Value >= ProgressBar.Minimum)
                ProgressBar.Value += 5;
            if (ProgressBar.Value >= ProgressBar.Maximum)
                softwareNameClock.Stop();
        }
    }
}
