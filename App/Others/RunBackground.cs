﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace App
{
    public class RunBackground
    {
        private bool isSetted = false;
        private NotifyIcon notifyIcon;
        private Form mainForm;
        private IContainer components;
        public bool Visible
        {
            get
            {
                if (notifyIcon != null)
                {
                    return notifyIcon.Visible;
                }
                else return false;
            }
        }
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
                if (notifyIcon != null)
                {
                    notifyIcon.ShowBalloonTip(5000);
                    notifyIcon.Visible = true;
                }
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

        public void OverrideNotify()
        {
            if (notifyIcon != null)
            {
                notifyIcon.Visible = !notifyIcon.Visible;
            }
        }

        private void SetNotify(Form mainForm, IContainer components)
        {
            if (!isSetted)
            {
                ContextMenuStrip contextMenuStrip;
                ToolStripMenuItem ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                ToolStripMenuItem ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                ToolStripMenuItem SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

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

                notifyIcon.Icon = Properties.Resources.mainIcon;
                notifyIcon.Text = "autoStudent";

                ExitToolStripMenuItem.Text = "Thoát";
                ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Clicked);

                ShowToolStripMenuItem.Text = "Bảng điều khiển";
                ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Clicked);

                SettingToolStripMenuItem.Text = "Bảng thiết lập";
                SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Clicked);

                contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    ShowToolStripMenuItem,
                    SettingToolStripMenuItem,
                    ExitToolStripMenuItem
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

        private void ShowToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }
            notifyIcon.Visible = false;
        }

        private void SettingToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            App.SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mainForm != null)
                {
                    mainForm.Show();
                    if(mainForm is ProgressWindow_Base)
                    {
                        ((ProgressWindow_Base)mainForm).SetRefresh();
                    }
                }
                notifyIcon.Visible = false;
            }
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }
            notifyIcon.Visible = false;
        }

        private void ExitToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            Program.mainUI.Close();
        }

        private void SetTime(DateTime startProcess)
        {
            if (notifyIcon != null)
            {
                notifyIcon.BalloonTipText = "Việc cài đặt sẽ được bắt đầu vào " + startProcess.ToString("HH:mm:ss dd/MM/yyyy");
            }
        }
    }
}
