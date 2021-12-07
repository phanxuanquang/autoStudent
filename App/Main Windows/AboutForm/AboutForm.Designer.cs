namespace App.Main_Windows.AboutForm
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.Framework = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.SubDeveloper1 = new System.Windows.Forms.Label();
            this.SubDeveloper2 = new System.Windows.Forms.Label();
            this.SubDeveloper3 = new System.Windows.Forms.Label();
            this.SubDeveloper4 = new System.Windows.Forms.Label();
            this.Feedback = new System.Windows.Forms.LinkLabel();
            this.GetSourceCode = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundEdge
            // 
            this.roundEdge.BorderRadius = 15;
            this.roundEdge.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::App.Properties.Resources.NameSoftware;
            this.guna2PictureBox1.Location = new System.Drawing.Point(93, 15);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(414, 75);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Title.Location = new System.Drawing.Point(5, 5);
            this.Title.Margin = new System.Windows.Forms.Padding(5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Phần mềm hỗ trợ cài đặt chương trình";
            this.Title.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.AutoRoundedCorners = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderColor = System.Drawing.Color.Transparent;
            this.Exit.BorderRadius = 14;
            this.Exit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Exit.BorderThickness = 1;
            this.Exit.CheckedState.Parent = this.Exit;
            this.Exit.CustomImages.Parent = this.Exit;
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Cyan;
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.Location = new System.Drawing.Point(449, 355);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(5);
            this.Exit.PressedColor = System.Drawing.Color.Cyan;
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(58, 31);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "OK";
            this.Exit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Exit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Controls.Add(this.Framework);
            this.panel1.Controls.Add(this.Developer);
            this.panel1.Controls.Add(this.SubDeveloper1);
            this.panel1.Controls.Add(this.SubDeveloper2);
            this.panel1.Controls.Add(this.SubDeveloper3);
            this.panel1.Controls.Add(this.SubDeveloper4);
            this.panel1.Controls.Add(this.Feedback);
            this.panel1.Controls.Add(this.GetSourceCode);
            this.panel1.Location = new System.Drawing.Point(93, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 235);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Version.Location = new System.Drawing.Point(5, 28);
            this.Version.Margin = new System.Windows.Forms.Padding(5);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(80, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "Phiên bản: 1.0";
            this.Version.Visible = false;
            // 
            // Framework
            // 
            this.Framework.AutoSize = true;
            this.Framework.BackColor = System.Drawing.Color.Transparent;
            this.Framework.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Framework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Framework.Location = new System.Drawing.Point(5, 51);
            this.Framework.Margin = new System.Windows.Forms.Padding(5);
            this.Framework.Name = "Framework";
            this.Framework.Size = new System.Drawing.Size(258, 13);
            this.Framework.TabIndex = 2;
            this.Framework.Text = "Chương trình viết trên nền tảng Windows Forms";
            this.Framework.Visible = false;
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.BackColor = System.Drawing.Color.Transparent;
            this.Developer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Developer.Location = new System.Drawing.Point(5, 74);
            this.Developer.Margin = new System.Windows.Forms.Padding(5);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(96, 13);
            this.Developer.TabIndex = 3;
            this.Developer.Text = "Người phát triển:";
            this.Developer.Visible = false;
            // 
            // SubDeveloper1
            // 
            this.SubDeveloper1.AutoSize = true;
            this.SubDeveloper1.BackColor = System.Drawing.Color.Transparent;
            this.SubDeveloper1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDeveloper1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubDeveloper1.Location = new System.Drawing.Point(50, 97);
            this.SubDeveloper1.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.SubDeveloper1.Name = "SubDeveloper1";
            this.SubDeveloper1.Size = new System.Drawing.Size(100, 13);
            this.SubDeveloper1.TabIndex = 4;
            this.SubDeveloper1.Text = "Phan Xuân Quang";
            this.SubDeveloper1.Visible = false;
            // 
            // SubDeveloper2
            // 
            this.SubDeveloper2.AutoSize = true;
            this.SubDeveloper2.BackColor = System.Drawing.Color.Transparent;
            this.SubDeveloper2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDeveloper2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubDeveloper2.Location = new System.Drawing.Point(50, 120);
            this.SubDeveloper2.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.SubDeveloper2.Name = "SubDeveloper2";
            this.SubDeveloper2.Size = new System.Drawing.Size(80, 13);
            this.SubDeveloper2.TabIndex = 5;
            this.SubDeveloper2.Text = "Trần Văn Thiệt";
            this.SubDeveloper2.Visible = false;
            // 
            // SubDeveloper3
            // 
            this.SubDeveloper3.AutoSize = true;
            this.SubDeveloper3.BackColor = System.Drawing.Color.Transparent;
            this.SubDeveloper3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDeveloper3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubDeveloper3.Location = new System.Drawing.Point(50, 143);
            this.SubDeveloper3.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.SubDeveloper3.Name = "SubDeveloper3";
            this.SubDeveloper3.Size = new System.Drawing.Size(84, 13);
            this.SubDeveloper3.TabIndex = 6;
            this.SubDeveloper3.Text = "Dín Hiền Dũng";
            this.SubDeveloper3.Visible = false;
            // 
            // SubDeveloper4
            // 
            this.SubDeveloper4.AutoSize = true;
            this.SubDeveloper4.BackColor = System.Drawing.Color.Transparent;
            this.SubDeveloper4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDeveloper4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SubDeveloper4.Location = new System.Drawing.Point(50, 166);
            this.SubDeveloper4.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.SubDeveloper4.Name = "SubDeveloper4";
            this.SubDeveloper4.Size = new System.Drawing.Size(113, 13);
            this.SubDeveloper4.TabIndex = 7;
            this.SubDeveloper4.Text = "Nguyễn Hoàng Phúc";
            this.SubDeveloper4.Visible = false;
            // 
            // Feedback
            // 
            this.Feedback.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.Feedback.AutoSize = true;
            this.Feedback.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Feedback.LinkColor = System.Drawing.Color.Cyan;
            this.Feedback.Location = new System.Drawing.Point(5, 189);
            this.Feedback.Margin = new System.Windows.Forms.Padding(5);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(174, 13);
            this.Feedback.TabIndex = 10;
            this.Feedback.TabStop = true;
            this.Feedback.Text = "Gửi phản hồi cho nhà phát triển";
            this.Feedback.Visible = false;
            this.Feedback.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.Feedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GetSourceCode
            // 
            this.GetSourceCode.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.GetSourceCode.AutoSize = true;
            this.GetSourceCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.GetSourceCode.LinkColor = System.Drawing.Color.Cyan;
            this.GetSourceCode.Location = new System.Drawing.Point(5, 212);
            this.GetSourceCode.Margin = new System.Windows.Forms.Padding(5);
            this.GetSourceCode.Name = "GetSourceCode";
            this.GetSourceCode.Size = new System.Drawing.Size(67, 13);
            this.GetSourceCode.TabIndex = 9;
            this.GetSourceCode.TabStop = true;
            this.GetSourceCode.Text = "Link Github";
            this.GetSourceCode.Visible = false;
            this.GetSourceCode.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.GetSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.Background__SubWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.Shown += new System.EventHandler(this.AboutForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse roundEdge;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SubDeveloper4;
        private System.Windows.Forms.Label SubDeveloper3;
        private System.Windows.Forms.Label SubDeveloper2;
        private System.Windows.Forms.Label SubDeveloper1;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.Label Framework;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel Feedback;
        private System.Windows.Forms.LinkLabel GetSourceCode;
    }
}