using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace App
{
    class Setting
    {
        public DateTime timeSetter;
        public string activatingAction;
        public string activatedAction;
        public bool cleanAfterCompleted;
        public bool dataExportAfterCompleted;
        public string otherDirectoryPath;

        public Setting()
        {
            timeSetter = DateTime.Now;
            activatingAction = "Không làm gì";
            activatedAction = "Không làm gì";
            cleanAfterCompleted = false;
            dataExportAfterCompleted = false;
            otherDirectoryPath = "C:\\";
        }

        public void exec_timeSetter()
        {

        }

        public void exec_activatingAction()
        {
            switch (activatingAction)
            {
                case "Chạy ngầm":
                    // Background Runnning Functions
                    break;
                default:
                    break;
            }
        }

        // For Lock
        [DllImport("user32")]
        public static extern void LockWorkStation();

        // For Sleep
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public void exec_activatedAction()
        {
            switch (activatedAction)
            {
                case "Thoát chương trình":
                    Application.Exit();
                    break;
                case "Tắt máy":
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case "Khởi động lại":
                    Process.Start("shutdown", "/r /t 0");
                    break;
                case "Khóa máy":
                    LockWorkStation();
                    break;
                case "Ngủ":
                    SetSuspendState(false, true, true);
                    break;
                default:
                    break;
            }
        }

        public void exec_cleanAfterCompleted(string savedSetupFolderPath)
        {
            void cleanFolder(DirectoryInfo dir)
            {
                foreach (FileInfo file in dir.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo subDir in dir.EnumerateDirectories())
                {
                    subDir.Delete(true);
                }
            }

            DirectoryInfo prefetchFolder = new DirectoryInfo("C:\\Windows\\Prefetch\\");
            //DirectoryInfo setupFolder = new DirectoryInfo(savedSetupFolderPath);

            cleanFolder(prefetchFolder);
            //cleanFolder(setupFolder);

            MessageBox.Show("Dọn dẹp hoàn tất");
        }

        public void exec_dataExportAfterCompleted(List<Package> dataList, string fullName)
        {
            string jsonString = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.WriteAllText(fullName + ".json", jsonString);
        }
    }
    
}
