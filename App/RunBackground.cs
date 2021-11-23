using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace App
{
    class RunBackground
    {
        private static bool isSetted = false;
        private NotifyIcon notifyIcon;
        private Form mainForm;
        private IContainer components;
        /// <summary>
        /// Tạo đối tượng
        /// Ví dụ: RunBackground test = new RunBackground(this, this.components);
        ///     ở đây this là form, còn this.components là biến có sẵn trong form.
        /// </summary>
        /// <param name="mainForm">Form argument</param>
        /// <param name="components">Form container</param>
        public RunBackground(Form mainForm, IContainer components = null)
        {
            this.mainForm = mainForm;
            this.components = components;
        }
        /// <summary>
        /// Ẩn form hiện tại đi và để nó xuất hiện ở taskbar.
        /// </summary>
        /// <param name="startProcess">Nếu là hẹn giờ thì đưa vào thời gian còn lại đến khi bắt đầu, không có thì thôi.</param>
        public void EnableRunBackground(params DateTime[] startProcess)
        {
            if (mainForm != null)
            {
                SetNotify(mainForm, components);
                if (startProcess.Length > 0)
                {
                    SetTime(startProcess[0]);
                }
                mainForm.Hide();
                notifyIcon.ShowBalloonTip(5000);
                notifyIcon.Visible = true;
            }
        }
        /// <summary>
        /// Đặt cái ẩn này cho form khác.
        /// </summary>
        /// <param name="mainForm">Form argument</param>
        /// <param name="components">Form container</param>
        public void SetForm(Form mainForm, IContainer components = null)
        {
            this.mainForm = mainForm;
            this.components = components;
            if (notifyIcon != null)
            {
                notifyIcon.Dispose();
            }
            isSetted = false;
        }

        private void SetNotify(Form mainForm, IContainer components)
        {
            if (!isSetted)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
                ContextMenuStrip contextMenuStrip;
                ToolStripMenuItem ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                ToolStripMenuItem AbortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

                if (components != null)
                {
                    contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
                    notifyIcon = new System.Windows.Forms.NotifyIcon(components);
                }
                else
                {
                    contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
                    notifyIcon = new System.Windows.Forms.NotifyIcon();
                }

                notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                notifyIcon.BalloonTipTitle = "autoStudent";
                notifyIcon.BalloonTipText = "autoStudent đang chạy ngầm";

                //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("guna2Button4.Image")));
                //Bắt buộc phải dùng icon. Dùng đỡ để test
                notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(@"..\..\..\download_120262.ico");
                notifyIcon.Text = "autoStudent";

                ExitToolStripMenuItem.Text = "Thoát";
                ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Clicked);

                AbortToolStripMenuItem.Text = "Hủy cài đặt";
                AbortToolStripMenuItem.Click += new System.EventHandler(this.AbortToolStripMenuItem_Clicked);

                contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 
                    ExitToolStripMenuItem, 
                    AbortToolStripMenuItem 
                });
                contextMenuStrip.Name = "contextMenuStrip";
                contextMenuStrip.AutoSize = true;
                contextMenuStrip.SuspendLayout();

                notifyIcon.ContextMenuStrip = contextMenuStrip;

                notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_MouseClick);
                notifyIcon.BalloonTipClicked += new System.EventHandler(NotifyIcon1_BalloonTipClicked);
                
                isSetted = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainForm.Show();
                notifyIcon.Visible = false;
            }
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            mainForm.Show();
            notifyIcon.Visible = false;
        }

        private void ExitToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbortToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("Chưa cài đặt cho hủy cài đặt");
        }

        private void SetTime(DateTime startProcess)
        {
            if (notifyIcon != null)
            {
                notifyIcon.BalloonTipText = "Việc cài đặt sẽ được bắt đầu sau " + startProcess.ToString("HH:mm:ss dd/MM/yyyy");
            }
        }

    }
}
