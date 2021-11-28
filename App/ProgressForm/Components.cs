using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.ProgressForm
{
    class Components
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));

        public Guna.UI2.WinForms.Guna2ProgressBar progressBar
        {
            get
            {
                return guna2ProgressBar1;
            }
        }

        public Guna.UI.WinForms.GunaLabel label
        {
            get
            {
                return gunaLabel1;
            }
        }

        public enum Status
        {
            Downloading = 4,
            Processing = 3,
            Completed = 2,
            Canceled = 1,
            None = 0
        }
        private Status _status;
        public Status status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                UpdateStatus();
            }
        }

        public Components(FlowLayoutPanel panel = null)
        {
            InitializeComponent();
            if (panel != null)
            {
                panel.Controls.Add(this.flowLayoutPanel1);
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaLabel1);
            this.flowLayoutPanel1.Controls.Add(this.guna2ProgressBar1);
            this.flowLayoutPanel1.Controls.Add(this.guna2PictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.gunaLabel2);
            this.flowLayoutPanel1.Controls.Add(this.guna2Button1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(731, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(10, 5);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.gunaLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel1.Size = new System.Drawing.Size(200, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "y";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(213, 5);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(300, 26);
            this.guna2ProgressBar1.TabIndex = 1;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Load_img")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(518, 5);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(26, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(549, 5);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Padding = new System.Windows.Forms.Padding(2);
            this.gunaLabel2.Size = new System.Drawing.Size(96, 26);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Đang tải";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(645, 5);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(81, 26);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Hủy";
            // 
            // ProgressForm
            // 
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
        }

        private void UpdateStatus()
        {
            string update = "";
            Image updateImg = null;
            switch (_status)
            {
                case Status.Downloading:
                    update = "Đang tải";
                    updateImg= ((System.Drawing.Image)(resources.GetObject("Load_img.Image")));
                    break;
                case Status.Processing:
                    update = "Đang cài đặt";
                    updateImg = ((System.Drawing.Image)(resources.GetObject("Load_img.Image")));
                    break;
                case Status.Completed:
                    update = "Hoàn thành";
                    updateImg = ((System.Drawing.Image)(resources.GetObject("Complete_img.Image")));
                    break;
                case Status.Canceled:
                    updateImg = ((System.Drawing.Image)(resources.GetObject("Cancel_img.Image")));
                    update = "Bị hủy";
                    break;
                case Status.None:
                    updateImg = ((System.Drawing.Image)(resources.GetObject("Ready_img.Image")));
                    update = "Sẵn sàng";
                    break;
            }
            gunaLabel2.Text = update;
        }
    }
}
