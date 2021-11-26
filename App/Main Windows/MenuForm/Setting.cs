using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class Setting
    {
        public DateTime timeSetter;
        public string activatingAction;
        public string activatedAction;
        public bool cleanAfterCompleted;
        public bool excelExportAfterCompleted;

        public Setting()
        {
            timeSetter = DateTime.Now;
            activatingAction = "Không làm gì";
            activatedAction = "Không làm gì";
            cleanAfterCompleted = false;
            excelExportAfterCompleted = false;
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

        public void exec_cleanAfterCompleted()
        {

        }

        public void exec_excelExportAfterCompleted()
        {

        }
    }
    
}
