using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadingWindow loading = new LoadingWindow();
            Application.Run(loading);
            if (loading.isDone)
            {
                mainUI = new MainUI();
                Application.Run(mainUI);
            }    
        }
        static public List<Package> software_Database;
        static public List<Package> software_System;
        static public MainUI mainUI;
        static public Setting setting = new Setting(DateTime.Now);
    }
}
