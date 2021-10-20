namespace Project
{
    partial class MainUI
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
            Guna.UI2.WinForms.Guna2GradientPanel Banner;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.minimalizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.autoStudent = new System.Windows.Forms.Label();
            this.Engineering_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.IT_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Graphic_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.contentPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.credit = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            Banner = new Guna.UI2.WinForms.Guna2GradientPanel();
            Banner.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            Banner.AllowDrop = true;
            Banner.CausesValidation = false;
            Banner.Controls.Add(this.minimalizeButton);
            Banner.Controls.Add(this.exitButton);
            Banner.Controls.Add(this.autoStudent);
            Banner.Dock = System.Windows.Forms.DockStyle.Left;
            Banner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            Banner.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            Banner.Location = new System.Drawing.Point(0, 0);
            Banner.Name = "Banner";
            Banner.ShadowDecoration.Parent = Banner;
            Banner.Size = new System.Drawing.Size(130, 690);
            Banner.TabIndex = 0;
            Banner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            Banner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            Banner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalizeButton.Animated = true;
            this.minimalizeButton.CheckedState.Parent = this.minimalizeButton;
            this.minimalizeButton.CustomImages.Parent = this.minimalizeButton;
            this.minimalizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.minimalizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimalizeButton.ForeColor = System.Drawing.Color.White;
            this.minimalizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.minimalizeButton.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.minimalizeButton.HoverState.Parent = this.minimalizeButton;
            this.minimalizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalizeButton.Image")));
            this.minimalizeButton.Location = new System.Drawing.Point(40, 1);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.minimalizeButton.ShadowDecoration.Parent = this.minimalizeButton;
            this.minimalizeButton.Size = new System.Drawing.Size(45, 43);
            this.minimalizeButton.TabIndex = 2;
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Animated = true;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.exitButton.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(88, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(40, 43);
            this.exitButton.TabIndex = 1;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // autoStudent
            // 
            this.autoStudent.AllowDrop = true;
            this.autoStudent.AutoEllipsis = true;
            this.autoStudent.BackColor = System.Drawing.Color.Transparent;
            this.autoStudent.Font = new System.Drawing.Font("UTM Daxline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.autoStudent.Location = new System.Drawing.Point(1, 5);
            this.autoStudent.Name = "autoStudent";
            this.autoStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.autoStudent.Size = new System.Drawing.Size(339, 28);
            this.autoStudent.TabIndex = 0;
            this.autoStudent.Text = "   autoStudent - for Vietnamese students";
            this.autoStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Engineering_Button
            // 
            this.Engineering_Button.Animated = true;
            this.Engineering_Button.BackColor = System.Drawing.Color.Transparent;
            this.Engineering_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Engineering_Button.BorderRadius = 10;
            this.Engineering_Button.CheckedState.Parent = this.Engineering_Button;
            this.Engineering_Button.CustomImages.Parent = this.Engineering_Button;
            this.Engineering_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(78)))));
            this.Engineering_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(124)))));
            this.Engineering_Button.Font = new System.Drawing.Font("UTM Daxline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engineering_Button.ForeColor = System.Drawing.Color.White;
            this.Engineering_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.Engineering_Button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.Engineering_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(124)))));
            this.Engineering_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(78)))));
            this.Engineering_Button.HoverState.ForeColor = System.Drawing.Color.White;
            this.Engineering_Button.HoverState.Parent = this.Engineering_Button;
            this.Engineering_Button.Location = new System.Drawing.Point(59, 74);
            this.Engineering_Button.Name = "Engineering_Button";
            this.Engineering_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(145)))), ((int)(((byte)(63)))));
            this.Engineering_Button.ShadowDecoration.Parent = this.Engineering_Button;
            this.Engineering_Button.Size = new System.Drawing.Size(253, 87);
            this.Engineering_Button.TabIndex = 6;
            this.Engineering_Button.Text = "KỸ THUẬT";
            this.Engineering_Button.Click += new System.EventHandler(this.Engineering_Button_Click);
            this.Engineering_Button.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.doubleClick);
            // 
            // IT_Button
            // 
            this.IT_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IT_Button.Animated = true;
            this.IT_Button.BackColor = System.Drawing.Color.Transparent;
            this.IT_Button.BorderColor = System.Drawing.Color.Transparent;
            this.IT_Button.BorderRadius = 10;
            this.IT_Button.CheckedState.Parent = this.IT_Button;
            this.IT_Button.CustomImages.Parent = this.IT_Button;
            this.IT_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.IT_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.IT_Button.Font = new System.Drawing.Font("UTM Daxline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IT_Button.ForeColor = System.Drawing.Color.White;
            this.IT_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.IT_Button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.IT_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))));
            this.IT_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.IT_Button.HoverState.ForeColor = System.Drawing.Color.White;
            this.IT_Button.HoverState.Parent = this.IT_Button;
            this.IT_Button.Location = new System.Drawing.Point(339, 74);
            this.IT_Button.Name = "IT_Button";
            this.IT_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(163)))), ((int)(((byte)(138)))));
            this.IT_Button.ShadowDecoration.Parent = this.IT_Button;
            this.IT_Button.Size = new System.Drawing.Size(253, 87);
            this.IT_Button.TabIndex = 7;
            this.IT_Button.Text = "CÔNG NGHỆ THÔNG TIN";
            this.IT_Button.Click += new System.EventHandler(this.IT_Button_Click);
            this.IT_Button.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.doubleClick);
            // 
            // Graphic_Button
            // 
            this.Graphic_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Graphic_Button.Animated = true;
            this.Graphic_Button.BackColor = System.Drawing.Color.Transparent;
            this.Graphic_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Graphic_Button.BorderRadius = 10;
            this.Graphic_Button.CheckedState.Parent = this.Graphic_Button;
            this.Graphic_Button.CustomImages.Parent = this.Graphic_Button;
            this.Graphic_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(113)))));
            this.Graphic_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.Graphic_Button.Font = new System.Drawing.Font("UTM Daxline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphic_Button.ForeColor = System.Drawing.Color.White;
            this.Graphic_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.Graphic_Button.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.Graphic_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(152)))));
            this.Graphic_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(113)))));
            this.Graphic_Button.HoverState.ForeColor = System.Drawing.Color.White;
            this.Graphic_Button.HoverState.Parent = this.Graphic_Button;
            this.Graphic_Button.Location = new System.Drawing.Point(619, 74);
            this.Graphic_Button.Name = "Graphic_Button";
            this.Graphic_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.Graphic_Button.ShadowDecoration.Parent = this.Graphic_Button;
            this.Graphic_Button.Size = new System.Drawing.Size(253, 87);
            this.Graphic_Button.TabIndex = 8;
            this.Graphic_Button.Text = "ĐỒ HỌA";
            this.Graphic_Button.Click += new System.EventHandler(this.Graphic_Button_Click);
            this.Graphic_Button.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.doubleClick);
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.contentPanel.BorderRadius = 10;
            this.contentPanel.Controls.Add(this.credit);
            this.contentPanel.FillColor = System.Drawing.Color.White;
            this.contentPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.contentPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.contentPanel.Location = new System.Drawing.Point(57, 178);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.ShadowDecoration.Parent = this.contentPanel;
            this.contentPanel.Size = new System.Drawing.Size(817, 482);
            this.contentPanel.TabIndex = 9;
            // 
            // credit
            // 
            this.credit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.credit.BackColor = System.Drawing.Color.Transparent;
            this.credit.Font = new System.Drawing.Font("UTM Daxline", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.LightGray;
            this.credit.Location = new System.Drawing.Point(125, 192);
            this.credit.Name = "credit";
            this.credit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.credit.Size = new System.Drawing.Size(567, 98);
            this.credit.TabIndex = 1;
            this.credit.Text = "Được phát triển bởi nhóm sinh viên Đại học Công nghệ Thông tin thành phố Hồ Chí M" +
    "inh";
            this.credit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(930, 690);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.Graphic_Button);
            this.Controls.Add(this.IT_Button);
            this.Controls.Add(this.Engineering_Button);
            this.Controls.Add(Banner);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autoStudent";
            Banner.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Engineering_Button;
        private Guna.UI2.WinForms.Guna2GradientButton IT_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Graphic_Button;
        private Guna.UI2.WinForms.Guna2GradientPanel contentPanel;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label autoStudent;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button minimalizeButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

