﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }

        // Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                handleParam.ClassStyle |= 0x00020000;
                return handleParam;
            }
        }

        // Window
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void wizardButton_Click(object sender, EventArgs e)
        {
            if (MainPanel.Left >= 0)
            {
                exitButton_Above.Hide();
                minimizeButton_Above.Hide();
                MainPanel.Left -= 831;
            }
            else
            {
                exitButton_Above.Show();
                minimizeButton_Above.Show();
                MainPanel.Left += 831;
            }
        }

        //Drag Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Main Button
        private void installButton_Click(object sender, EventArgs e)
        {
            InstallForm installForm = new InstallForm();
            this.Hide();
            installForm.ShowDialog();
            this.Show();
        }
        private void uninstallButton_Click(object sender, EventArgs e)
        {
            UninstallForm unInstallForm = new UninstallForm();
            this.Hide();
            unInstallForm.ShowDialog();
            this.Show();
        }

        // Menu
        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            this.Hide();
            settingForm.ShowDialog();
            this.Show();
        }
        private void cleanButton_Click(object sender, EventArgs e)
        {
            Program.setting.RunCleanAction(Program.setting.saveDownloadPath);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            DateTime GetLastModifyTime(string url)
            {
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                request.Method = "HEAD";

                using (WebResponse response = request.GetResponse())
                {
                    string lastModifyString = response.Headers.Get("Last-Modified");
                    DateTime remoteTime;
                    if (DateTime.TryParse(lastModifyString, out remoteTime))
                    {
                        return remoteTime;
                    }

                    return DateTime.MinValue;
                }
            }

            try
            {
                WebClient client = new WebClient();
                string path = @"https://dung-ovl.github.io/MainData.json";
                DateTime modificationFileWeb = GetLastModifyTime(path);
                DateTime modificationFileSystem = DataAccess.Instance.GetUpdateTime();

                if (modificationFileWeb > modificationFileSystem)
                {
                    WebClient Client = new WebClient();
                    client.DownloadFile(path, DataAccess.Instance.GetFilePath());
                    /*
                    Code reload data
                    */
                    MessageBox.Show("Đã cập nhập");
                }
                else MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
            }
        }
        private void githubButton_Click(object sender, EventArgs e)
        {
            Process openGitHub = new Process();
            openGitHub.StartInfo.FileName = "CMD.exe";
            openGitHub.StartInfo.Arguments = "/C start https://github.com/phanxuanquang/autoStudent";
            openGitHub.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            openGitHub.Start();
        }
    }
}
