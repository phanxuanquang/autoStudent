﻿namespace App
{
    partial class ProgressWindow_Base
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressWindow_Base));
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.completedAmountLabel = new System.Windows.Forms.Label();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelAll_Button = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundRunning_Button = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.detail_Button = new Guna.UI2.WinForms.Guna2Button();
            this.softwareGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NameSoftware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentDownload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusProcess = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.ActionButton = new App.DataGridViewDisableButtonColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BorderRadius = 12;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.progressBar.ForeColor = System.Drawing.Color.Cyan;
            this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar.Location = new System.Drawing.Point(125, 5);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(106)))), ((int)(((byte)(204)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(482, 30);
            this.progressBar.TabIndex = 35;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(0, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Hoàn thành";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // completedAmountLabel
            // 
            this.completedAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completedAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.completedAmountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.completedAmountLabel.ForeColor = System.Drawing.Color.Cyan;
            this.completedAmountLabel.Location = new System.Drawing.Point(607, 8);
            this.completedAmountLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.completedAmountLabel.Name = "completedAmountLabel";
            this.completedAmountLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.completedAmountLabel.Size = new System.Drawing.Size(92, 25);
            this.completedAmountLabel.TabIndex = 36;
            this.completedAmountLabel.Text = "999/999";
            this.completedAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completedAmountLabel.UseCompatibleTextRendering = true;
            this.completedAmountLabel.TextChanged += new System.EventHandler(this.completedAmountLabel_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Animated = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.Cyan;
            this.exitButton.BorderRadius = 3;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = global::App.Properties.Resources.Exit;
            this.exitButton.Location = new System.Drawing.Point(787, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 37;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cancelAll_Button
            // 
            this.cancelAll_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelAll_Button.Animated = true;
            this.cancelAll_Button.AutoRoundedCorners = true;
            this.cancelAll_Button.BackColor = System.Drawing.Color.Transparent;
            this.cancelAll_Button.BorderColor = System.Drawing.Color.Cyan;
            this.cancelAll_Button.BorderRadius = 16;
            this.cancelAll_Button.BorderThickness = 2;
            this.cancelAll_Button.CheckedState.Parent = this.cancelAll_Button;
            this.cancelAll_Button.CustomImages.Parent = this.cancelAll_Button;
            this.cancelAll_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.cancelAll_Button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancelAll_Button.ForeColor = System.Drawing.Color.Cyan;
            this.cancelAll_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.cancelAll_Button.HoverState.Parent = this.cancelAll_Button;
            this.cancelAll_Button.Location = new System.Drawing.Point(487, 45);
            this.cancelAll_Button.Margin = new System.Windows.Forms.Padding(61, 4, 0, 0);
            this.cancelAll_Button.Name = "cancelAll_Button";
            this.cancelAll_Button.ShadowDecoration.Parent = this.cancelAll_Button;
            this.cancelAll_Button.Size = new System.Drawing.Size(120, 35);
            this.cancelAll_Button.TabIndex = 39;
            this.cancelAll_Button.Text = "HỦY TOÀN BỘ";
            this.cancelAll_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.cancelAll_Button.Click += new System.EventHandler(this.cancelAll_Button_Click);
            // 
            // backgroundRunning_Button
            // 
            this.backgroundRunning_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backgroundRunning_Button.Animated = true;
            this.backgroundRunning_Button.AutoRoundedCorners = true;
            this.backgroundRunning_Button.BackColor = System.Drawing.Color.Transparent;
            this.backgroundRunning_Button.BorderColor = System.Drawing.Color.Cyan;
            this.backgroundRunning_Button.BorderRadius = 16;
            this.backgroundRunning_Button.BorderThickness = 2;
            this.backgroundRunning_Button.CheckedState.Parent = this.backgroundRunning_Button;
            this.backgroundRunning_Button.CustomImages.Parent = this.backgroundRunning_Button;
            this.backgroundRunning_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.backgroundRunning_Button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.backgroundRunning_Button.ForeColor = System.Drawing.Color.Cyan;
            this.backgroundRunning_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.backgroundRunning_Button.HoverState.Parent = this.backgroundRunning_Button;
            this.backgroundRunning_Button.Location = new System.Drawing.Point(306, 45);
            this.backgroundRunning_Button.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.backgroundRunning_Button.Name = "backgroundRunning_Button";
            this.backgroundRunning_Button.ShadowDecoration.Parent = this.backgroundRunning_Button;
            this.backgroundRunning_Button.Size = new System.Drawing.Size(120, 35);
            this.backgroundRunning_Button.TabIndex = 40;
            this.backgroundRunning_Button.Text = "CHẠY NGẦM";
            this.backgroundRunning_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.backgroundRunning_Button.Click += new System.EventHandler(this.backgroundRunning_Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.progressBar);
            this.flowLayoutPanel1.Controls.Add(this.completedAmountLabel);
            this.flowLayoutPanel1.Controls.Add(this.detail_Button);
            this.flowLayoutPanel1.Controls.Add(this.backgroundRunning_Button);
            this.flowLayoutPanel1.Controls.Add(this.cancelAll_Button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 33);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 130);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // detail_Button
            // 
            this.detail_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.detail_Button.Animated = true;
            this.detail_Button.AutoRoundedCorners = true;
            this.detail_Button.BackColor = System.Drawing.Color.Transparent;
            this.detail_Button.BorderColor = System.Drawing.Color.Cyan;
            this.detail_Button.BorderRadius = 16;
            this.detail_Button.BorderThickness = 2;
            this.detail_Button.CheckedState.Parent = this.detail_Button;
            this.detail_Button.CustomImages.Parent = this.detail_Button;
            this.detail_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.detail_Button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.detail_Button.ForeColor = System.Drawing.Color.Cyan;
            this.detail_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.detail_Button.HoverState.Parent = this.detail_Button;
            this.detail_Button.Image = global::App.Properties.Resources.Detail;
            this.detail_Button.ImageSize = new System.Drawing.Size(18, 18);
            this.detail_Button.Location = new System.Drawing.Point(125, 45);
            this.detail_Button.Margin = new System.Windows.Forms.Padding(125, 4, 61, 0);
            this.detail_Button.Name = "detail_Button";
            this.detail_Button.ShadowDecoration.Parent = this.detail_Button;
            this.detail_Button.Size = new System.Drawing.Size(120, 35);
            this.detail_Button.TabIndex = 41;
            this.detail_Button.Text = "CHI TIẾT";
            this.detail_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.detail_Button.Click += new System.EventHandler(this.detai_Button_Click);
            // 
            // softwareGridView
            // 
            this.softwareGridView.AllowUserToAddRows = false;
            this.softwareGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.softwareGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softwareGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.softwareGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.softwareGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.softwareGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.softwareGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.softwareGridView.ColumnHeadersHeight = 30;
            this.softwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.softwareGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.softwareGridView.EnableHeadersVisualStyles = false;
            this.softwareGridView.GridColor = System.Drawing.Color.Cyan;
            this.softwareGridView.Location = new System.Drawing.Point(60, 170);
            this.softwareGridView.Margin = new System.Windows.Forms.Padding(0);
            this.softwareGridView.MultiSelect = false;
            this.softwareGridView.Name = "softwareGridView";
            this.softwareGridView.ReadOnly = true;
            this.softwareGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.softwareGridView.RowHeadersVisible = false;
            this.softwareGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.softwareGridView.RowTemplate.Height = 30;
            this.softwareGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.softwareGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.softwareGridView.Size = new System.Drawing.Size(699, 273);
            this.softwareGridView.TabIndex = 44;
            this.softwareGridView.Tag = "unclicked";
            this.softwareGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
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
            this.softwareGridView.ThemeStyle.RowsStyle.Height = 30;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.Visible = false;
            this.softwareGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.softwareGridView_CellContentClick);
            this.softwareGridView.SelectionChanged += new System.EventHandler(this.softwareGridView_SelectionChanged);
            // 
            // NameSoftware
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameSoftware.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameSoftware.HeaderText = "PHẦN MỀM";
            this.NameSoftware.Name = "NameSoftware";
            this.NameSoftware.ReadOnly = true;
            // 
            // PercentDownload
            // 
            this.PercentDownload.FillWeight = 25F;
            this.PercentDownload.HeaderText = "TIẾN ĐỘ";
            this.PercentDownload.Name = "PercentDownload";
            this.PercentDownload.ReadOnly = true;
            // 
            // StatusProcess
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.StatusProcess.DefaultCellStyle = dataGridViewCellStyle5;
            this.StatusProcess.FillWeight = 40F;
            this.StatusProcess.HeaderText = "TRẠNG THÁI";
            this.StatusProcess.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.StatusProcess.Name = "StatusProcess";
            this.StatusProcess.ReadOnly = true;
            // 
            // roundEdge
            // 
            this.roundEdge.BorderRadius = 15;
            this.roundEdge.TargetControl = this;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Animated = true;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.Cyan;
            this.minimizeButton.BorderRadius = 3;
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.minimizeButton.HoverState.Parent = this.minimizeButton;
            this.minimizeButton.Image = global::App.Properties.Resources.Minimalize;
            this.minimizeButton.Location = new System.Drawing.Point(759, 2);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 45;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.FillWeight = 40F;
            this.ActionButton.HeaderText = "HÀNH ĐỘNG";
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.ReadOnly = true;
            // 
            // ProgressWindow_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::App.Properties.Resources.Background__SubWindow_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 492);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.softwareGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressWindow_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label completedAmountLabel;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        protected Guna.UI2.WinForms.Guna2Button cancelAll_Button;
        protected Guna.UI2.WinForms.Guna2Button backgroundRunning_Button;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected Guna.UI2.WinForms.Guna2DataGridView softwareGridView;
        protected System.Windows.Forms.DataGridViewTextBoxColumn NameSoftware;
        protected System.Windows.Forms.DataGridViewTextBoxColumn PercentDownload;
        protected System.Windows.Forms.DataGridViewImageColumn StatusProcess;
        protected DataGridViewDisableButtonColumn ActionButton;
        protected Guna.UI2.WinForms.Guna2Button detail_Button;
        private Guna.UI2.WinForms.Guna2Elipse roundEdge;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
    }
}