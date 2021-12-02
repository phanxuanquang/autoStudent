﻿namespace App
{
    partial class BaseExecutionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseExecutionForm));
            this.softwareGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.softwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.allSoftwareView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.selectedSoftwareView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.menuButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Graphic_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.None_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Tech_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.IT_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.ImportSoftwareList_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // softwareGridView
            // 
            this.softwareGridView.AllowUserToAddRows = false;
            this.softwareGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.softwareGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softwareGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.softwareGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.softwareGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.softwareGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.softwareGridView.ColumnHeadersHeight = 30;
            this.softwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.softwareGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareName,
            this.softwareVersion});
            this.softwareGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.softwareGridView.EnableHeadersVisualStyles = false;
            this.softwareGridView.GridColor = System.Drawing.Color.Cyan;
            this.softwareGridView.Location = new System.Drawing.Point(147, 108);
            this.softwareGridView.Name = "softwareGridView";
            this.softwareGridView.ReadOnly = true;
            this.softwareGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.softwareGridView.RowHeadersVisible = false;
            this.softwareGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.softwareGridView.RowTemplate.Height = 25;
            this.softwareGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.softwareGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.softwareGridView.Size = new System.Drawing.Size(677, 383);
            this.softwareGridView.TabIndex = 17;
            this.softwareGridView.Tag = "unclicked";
            this.softwareGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.softwareGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.softwareGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.softwareGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.softwareGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.softwareGridView.ThemeStyle.ReadOnly = true;
            this.softwareGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.softwareGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.softwareGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.RowsStyle.Height = 25;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.softwareGridView_CellClick);
            // 
            // softwareName
            // 
            this.softwareName.HeaderText = "TÊN PHẦN MỀM";
            this.softwareName.Name = "softwareName";
            this.softwareName.ReadOnly = true;
            this.softwareName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // softwareVersion
            // 
            this.softwareVersion.HeaderText = "PHIÊN BẢN PHẦN MỀM";
            this.softwareVersion.Name = "softwareVersion";
            this.softwareVersion.ReadOnly = true;
            this.softwareVersion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Cyan;
            this.searchBox.BorderRadius = 18;
            this.searchBox.BorderThickness = 3;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.Parent = this.searchBox;
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.FocusedState.Parent = this.searchBox;
            this.searchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchBox.ForeColor = System.Drawing.Color.Cyan;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBox.Location = new System.Drawing.Point(147, 51);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.LightCyan;
            this.searchBox.PlaceholderText = "Tìm phần mềm theo tên";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.Size = new System.Drawing.Size(677, 42);
            this.searchBox.TabIndex = 18;
            this.searchBox.TextOffset = new System.Drawing.Point(20, 0);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Animated = true;
            this.confirmButton.AutoRoundedCorners = true;
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BorderColor = System.Drawing.Color.Cyan;
            this.confirmButton.BorderRadius = 23;
            this.confirmButton.BorderThickness = 3;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.Cyan;
            this.confirmButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(604, 506);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(220, 49);
            this.confirmButton.TabIndex = 19;
            this.confirmButton.Text = "TIẾP TỤC";
            this.confirmButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // allSoftwareView_Button
            // 
            this.allSoftwareView_Button.Animated = true;
            this.allSoftwareView_Button.AutoRoundedCorners = true;
            this.allSoftwareView_Button.BackColor = System.Drawing.Color.Transparent;
            this.allSoftwareView_Button.BorderColor = System.Drawing.Color.Cyan;
            this.allSoftwareView_Button.BorderRadius = 23;
            this.allSoftwareView_Button.BorderThickness = 3;
            this.allSoftwareView_Button.CheckedState.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.CustomImages.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.allSoftwareView_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.allSoftwareView_Button.ForeColor = System.Drawing.Color.Cyan;
            this.allSoftwareView_Button.HoverState.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.Location = new System.Drawing.Point(147, 506);
            this.allSoftwareView_Button.Name = "allSoftwareView_Button";
            this.allSoftwareView_Button.ShadowDecoration.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.Size = new System.Drawing.Size(220, 49);
            this.allSoftwareView_Button.TabIndex = 20;
            this.allSoftwareView_Button.Text = "Tất cả phần mềm";
            this.allSoftwareView_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.allSoftwareView_Button.Click += new System.EventHandler(this.allSoftwareView_Button_Click);
            // 
            // selectedSoftwareView_Button
            // 
            this.selectedSoftwareView_Button.Animated = true;
            this.selectedSoftwareView_Button.AutoRoundedCorners = true;
            this.selectedSoftwareView_Button.BackColor = System.Drawing.Color.Transparent;
            this.selectedSoftwareView_Button.BorderColor = System.Drawing.Color.Cyan;
            this.selectedSoftwareView_Button.BorderRadius = 23;
            this.selectedSoftwareView_Button.BorderThickness = 3;
            this.selectedSoftwareView_Button.CheckedState.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.CustomImages.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.selectedSoftwareView_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.selectedSoftwareView_Button.ForeColor = System.Drawing.Color.Cyan;
            this.selectedSoftwareView_Button.HoverState.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.Location = new System.Drawing.Point(375, 506);
            this.selectedSoftwareView_Button.Name = "selectedSoftwareView_Button";
            this.selectedSoftwareView_Button.ShadowDecoration.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.Size = new System.Drawing.Size(220, 49);
            this.selectedSoftwareView_Button.TabIndex = 21;
            this.selectedSoftwareView_Button.Tag = "unclicked";
            this.selectedSoftwareView_Button.Text = "Phần mềm đã chọn";
            this.selectedSoftwareView_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.selectedSoftwareView_Button.Click += new System.EventHandler(this.selectedSoftwareView_Button_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.menuPanel.Controls.Add(this.ImportSoftwareList_Button);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Controls.Add(this.Graphic_Button);
            this.menuPanel.Controls.Add(this.None_Button);
            this.menuPanel.Controls.Add(this.Tech_Button);
            this.menuPanel.Controls.Add(this.IT_Button);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.menuPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.menuPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.menuPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.ShadowDecoration.BorderRadius = 10;
            this.menuPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.menuPanel.ShadowDecoration.Enabled = true;
            this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
            this.menuPanel.Size = new System.Drawing.Size(78, 607);
            this.menuPanel.TabIndex = 22;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.CheckedState.Parent = this.menuButton;
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.menuButton.HoverState.Parent = this.menuButton;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageSize = new System.Drawing.Size(58, 58);
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.PressedState.ImageSize = new System.Drawing.Size(58, 58);
            this.menuButton.PressedState.Parent = this.menuButton;
            this.menuButton.Size = new System.Drawing.Size(78, 78);
            this.menuButton.TabIndex = 18;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Graphic_Button
            // 
            this.Graphic_Button.Animated = true;
            this.Graphic_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.CheckedState.Parent = this.Graphic_Button;
            this.Graphic_Button.CustomImages.Parent = this.Graphic_Button;
            this.Graphic_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Graphic_Button.ForeColor = System.Drawing.Color.Cyan;
            this.Graphic_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.Graphic_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.Graphic_Button.HoverState.Parent = this.Graphic_Button;
            this.Graphic_Button.Image = ((System.Drawing.Image)(resources.GetObject("Graphic_Button.Image")));
            this.Graphic_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Graphic_Button.ImageOffset = new System.Drawing.Point(16, 0);
            this.Graphic_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Graphic_Button.Location = new System.Drawing.Point(0, 303);
            this.Graphic_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Graphic_Button.Name = "Graphic_Button";
            this.Graphic_Button.PressedColor = System.Drawing.Color.Cyan;
            this.Graphic_Button.PressedDepth = 20;
            this.Graphic_Button.ShadowDecoration.BorderRadius = 0;
            this.Graphic_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Graphic_Button.ShadowDecoration.Parent = this.Graphic_Button;
            this.Graphic_Button.Size = new System.Drawing.Size(300, 97);
            this.Graphic_Button.TabIndex = 14;
            this.Graphic_Button.Text = "Đồ họa đa phương tiện";
            this.Graphic_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Graphic_Button.TextOffset = new System.Drawing.Point(40, 0);
            this.Graphic_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Graphic_Button.Click += new System.EventHandler(this.Graphic_Button_Click);
            // 
            // None_Button
            // 
            this.None_Button.Animated = true;
            this.None_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.None_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.None_Button.CheckedState.Parent = this.None_Button;
            this.None_Button.CustomImages.Parent = this.None_Button;
            this.None_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.None_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.None_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.None_Button.ForeColor = System.Drawing.Color.Cyan;
            this.None_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.None_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.None_Button.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.None_Button.HoverState.Parent = this.None_Button;
            this.None_Button.Image = ((System.Drawing.Image)(resources.GetObject("None_Button.Image")));
            this.None_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.None_Button.ImageOffset = new System.Drawing.Point(16, 0);
            this.None_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.None_Button.Location = new System.Drawing.Point(0, 400);
            this.None_Button.Margin = new System.Windows.Forms.Padding(0);
            this.None_Button.Name = "None_Button";
            this.None_Button.PressedColor = System.Drawing.Color.Cyan;
            this.None_Button.PressedDepth = 20;
            this.None_Button.ShadowDecoration.BorderRadius = 0;
            this.None_Button.ShadowDecoration.Parent = this.None_Button;
            this.None_Button.Size = new System.Drawing.Size(300, 97);
            this.None_Button.TabIndex = 15;
            this.None_Button.Text = "Khác";
            this.None_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.None_Button.TextOffset = new System.Drawing.Point(40, 0);
            this.None_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.None_Button.Click += new System.EventHandler(this.None_Button_Click);
            // 
            // Tech_Button
            // 
            this.Tech_Button.Animated = true;
            this.Tech_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.CheckedState.Parent = this.Tech_Button;
            this.Tech_Button.CustomImages.Parent = this.Tech_Button;
            this.Tech_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tech_Button.ForeColor = System.Drawing.Color.Cyan;
            this.Tech_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.Tech_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.Tech_Button.HoverState.Parent = this.Tech_Button;
            this.Tech_Button.Image = ((System.Drawing.Image)(resources.GetObject("Tech_Button.Image")));
            this.Tech_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tech_Button.ImageOffset = new System.Drawing.Point(16, 0);
            this.Tech_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Tech_Button.Location = new System.Drawing.Point(0, 206);
            this.Tech_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Tech_Button.Name = "Tech_Button";
            this.Tech_Button.PressedColor = System.Drawing.Color.Cyan;
            this.Tech_Button.PressedDepth = 20;
            this.Tech_Button.ShadowDecoration.BorderRadius = 0;
            this.Tech_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.Tech_Button.ShadowDecoration.Parent = this.Tech_Button;
            this.Tech_Button.Size = new System.Drawing.Size(300, 97);
            this.Tech_Button.TabIndex = 13;
            this.Tech_Button.Text = "Kỹ thuật cơ khí";
            this.Tech_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tech_Button.TextOffset = new System.Drawing.Point(40, 0);
            this.Tech_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Tech_Button.Click += new System.EventHandler(this.Tech_Button_Click);
            // 
            // IT_Button
            // 
            this.IT_Button.Animated = true;
            this.IT_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.CheckedState.Parent = this.IT_Button;
            this.IT_Button.CustomImages.Parent = this.IT_Button;
            this.IT_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IT_Button.ForeColor = System.Drawing.Color.Cyan;
            this.IT_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.IT_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.IT_Button.HoverState.Parent = this.IT_Button;
            this.IT_Button.Image = ((System.Drawing.Image)(resources.GetObject("IT_Button.Image")));
            this.IT_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IT_Button.ImageOffset = new System.Drawing.Point(16, 0);
            this.IT_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.IT_Button.Location = new System.Drawing.Point(0, 109);
            this.IT_Button.Margin = new System.Windows.Forms.Padding(0);
            this.IT_Button.Name = "IT_Button";
            this.IT_Button.PressedColor = System.Drawing.Color.Cyan;
            this.IT_Button.PressedDepth = 20;
            this.IT_Button.ShadowDecoration.BorderRadius = 0;
            this.IT_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.IT_Button.ShadowDecoration.Parent = this.IT_Button;
            this.IT_Button.Size = new System.Drawing.Size(300, 97);
            this.IT_Button.TabIndex = 12;
            this.IT_Button.Text = "Công nghệ thông tin";
            this.IT_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IT_Button.TextOffset = new System.Drawing.Point(40, 0);
            this.IT_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.IT_Button.Click += new System.EventHandler(this.IT_Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Animated = true;
            this.exitButton.BorderColor = System.Drawing.Color.Cyan;
            this.exitButton.BorderRadius = 3;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(937, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 23;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ImportSoftwareList_Button
            // 
            this.ImportSoftwareList_Button.Animated = true;
            this.ImportSoftwareList_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.ImportSoftwareList_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.ImportSoftwareList_Button.CheckedState.Parent = this.ImportSoftwareList_Button;
            this.ImportSoftwareList_Button.CustomImages.Parent = this.ImportSoftwareList_Button;
            this.ImportSoftwareList_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.ImportSoftwareList_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.ImportSoftwareList_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ImportSoftwareList_Button.ForeColor = System.Drawing.Color.Cyan;
            this.ImportSoftwareList_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.ImportSoftwareList_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.ImportSoftwareList_Button.HoverState.ForeColor = System.Drawing.Color.Cyan;
            this.ImportSoftwareList_Button.HoverState.Parent = this.ImportSoftwareList_Button;
            this.ImportSoftwareList_Button.Image = ((System.Drawing.Image)(resources.GetObject("ImportSoftwareList_Button.Image")));
            this.ImportSoftwareList_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportSoftwareList_Button.ImageOffset = new System.Drawing.Point(16, 0);
            this.ImportSoftwareList_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.ImportSoftwareList_Button.Location = new System.Drawing.Point(0, 494);
            this.ImportSoftwareList_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ImportSoftwareList_Button.Name = "ImportSoftwareList_Button";
            this.ImportSoftwareList_Button.PressedColor = System.Drawing.Color.Cyan;
            this.ImportSoftwareList_Button.PressedDepth = 20;
            this.ImportSoftwareList_Button.ShadowDecoration.BorderRadius = 0;
            this.ImportSoftwareList_Button.ShadowDecoration.Parent = this.ImportSoftwareList_Button;
            this.ImportSoftwareList_Button.Size = new System.Drawing.Size(300, 97);
            this.ImportSoftwareList_Button.TabIndex = 19;
            this.ImportSoftwareList_Button.Text = "Danh sách bên ngoài";
            this.ImportSoftwareList_Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImportSoftwareList_Button.TextOffset = new System.Drawing.Point(40, 0);
            this.ImportSoftwareList_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ImportSoftwareList_Button.Click += new System.EventHandler(this.ImportSoftwareList_Button_Click);
            // 
            // BaseExecutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 607);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.selectedSoftwareView_Button);
            this.Controls.Add(this.allSoftwareView_Button);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.softwareGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseExecutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView softwareGridView;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2Button allSoftwareView_Button;
        private Guna.UI2.WinForms.Guna2Button selectedSoftwareView_Button;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel menuPanel;
        private Guna.UI2.WinForms.Guna2ImageButton menuButton;
        private Guna.UI2.WinForms.Guna2GradientButton Graphic_Button;
        private Guna.UI2.WinForms.Guna2GradientButton None_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Tech_Button;
        private Guna.UI2.WinForms.Guna2GradientButton IT_Button;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareVersion;
        private Guna.UI2.WinForms.Guna2GradientButton ImportSoftwareList_Button;
    }
}