using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.Icon = Properties.Resources.mainIcon;
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        // Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
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

        private bool isInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        // Main Button
        private void installButton_Click(object sender, EventArgs e)
        {
            
            if (isInternetAvailable())
            {
                InstallForm installForm = new InstallForm();
                this.Hide();
                installForm.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau");

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
            settingForm.ShowDialog();
        }
        private void cleanButton_Click(object sender, EventArgs e)
        {
            if (!Program.setting.cleanAfter)
            {
                DialogResult dialogResult = MessageBox.Show("Các tệp sẽ bị xóa vĩnh viễn, bạn có muốn tiếp tục?", "DỌN DẸP", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.setting.RunCleanAction(Program.setting.saveDownloadPath);
                    MessageBox.Show("Dọn dẹp hoàn tất");
                }
            }
            else Program.setting.RunCleanAction(Program.setting.saveDownloadPath);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!isInternetAvailable())
            {
                MessageBox.Show("Không có kết nối mạng, vui lòng thử lại sau");
                return;
            }
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
                string path = @"https://dung-ovl.github.io/MainData.json";
                DateTime modificationFileWeb = GetLastModifyTime(path);
                DateTime modificationFileSystem = DataAccess.Instance.GetUpdateTime();

                if (modificationFileWeb > modificationFileSystem)
                {

                    string pathData = DataAccess.Instance.GetFilePath();
                    if (File.Exists(pathData))
                    {
                        File.Delete(pathData);
                    }
                    DataAccess.Instance.LoadDirect();
                    if (Environment.Is64BitOperatingSystem)
                        Program.software_Database = DataAccess.Instance.GetX64();
                    else Program.software_Database = DataAccess.Instance.GetX86();
                    MessageBox.Show("Đã cập nhập");
                }
                else MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất");
            }
            catch (WebException we)
            {
                // WebException.Status holds useful information
                MessageBox.Show(we.Message + "\n" + we.Status.ToString());
            }
            catch (NotSupportedException ne)
            {
                // other errors
                MessageBox.Show(ne.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
            }
        }
        private void githubButton_Click(object sender, EventArgs e)
        {
            App.Main_Windows.AboutForm.AboutForm aboutForm = new App.Main_Windows.AboutForm.AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
