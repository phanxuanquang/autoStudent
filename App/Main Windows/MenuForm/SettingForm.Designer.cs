﻿namespace App
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.timeSetter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activatingAction = new Guna.UI2.WinForms.Guna2ComboBox();
            this.activatedAction = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cleanAfterCompleted_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultSetting_Button = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataExportAfterCompleted_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.otherDirectoryPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.otherPath_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // timeSetter
            // 
            this.timeSetter.CalendarForeColor = System.Drawing.Color.Cyan;
            this.timeSetter.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.timeSetter.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.timeSetter.CalendarTitleForeColor = System.Drawing.Color.Cyan;
            this.timeSetter.CalendarTrailingForeColor = System.Drawing.Color.Cyan;
            this.timeSetter.CausesValidation = false;
            this.timeSetter.Checked = false;
            this.timeSetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeSetter.CustomFormat = "    dd/MM/yyyy   HH:mm tt";
            this.timeSetter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.timeSetter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeSetter.Location = new System.Drawing.Point(358, 55);
            this.timeSetter.Margin = new System.Windows.Forms.Padding(10);
            this.timeSetter.Name = "timeSetter";
            this.timeSetter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeSetter.Size = new System.Drawing.Size(355, 26);
            this.timeSetter.TabIndex = 0;
            this.timeSetter.Value = new System.DateTime(2021, 11, 26, 8, 29, 0, 0);
            this.timeSetter.ValueChanged += new System.EventHandler(this.timeSetter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hẹn thời gian bắt đầu:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(74, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trong khi chạy chương trình:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(74, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sau khi hoàn tất:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // activatingAction
            // 
            this.activatingAction.Animated = true;
            this.activatingAction.BackColor = System.Drawing.Color.Transparent;
            this.activatingAction.BorderColor = System.Drawing.Color.Cyan;
            this.activatingAction.BorderRadius = 5;
            this.activatingAction.BorderThickness = 2;
            this.activatingAction.DisplayMember = "1";
            this.activatingAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.activatingAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activatingAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.activatingAction.FocusedColor = System.Drawing.Color.Empty;
            this.activatingAction.FocusedState.Parent = this.activatingAction;
            this.activatingAction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.activatingAction.ForeColor = System.Drawing.Color.Cyan;
            this.activatingAction.FormattingEnabled = true;
            this.activatingAction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.activatingAction.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.activatingAction.HoverState.Parent = this.activatingAction;
            this.activatingAction.ItemHeight = 40;
            this.activatingAction.Items.AddRange(new object[] {
            "Không làm gì",
            "Chạy ngầm"});
            this.activatingAction.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.activatingAction.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.activatingAction.ItemsAppearance.Parent = this.activatingAction;
            this.activatingAction.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.activatingAction.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.activatingAction.Location = new System.Drawing.Point(358, 110);
            this.activatingAction.Name = "activatingAction";
            this.activatingAction.ShadowDecoration.Parent = this.activatingAction;
            this.activatingAction.Size = new System.Drawing.Size(355, 46);
            this.activatingAction.TabIndex = 4;
            this.activatingAction.TextOffset = new System.Drawing.Point(10, 0);
            this.activatingAction.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.activatingAction.SelectedIndexChanged += new System.EventHandler(this.activatingAction_SelectedIndexChanged);
            // 
            // activatedAction
            // 
            this.activatedAction.Animated = true;
            this.activatedAction.BackColor = System.Drawing.Color.Transparent;
            this.activatedAction.BorderColor = System.Drawing.Color.Cyan;
            this.activatedAction.BorderRadius = 5;
            this.activatedAction.BorderThickness = 2;
            this.activatedAction.DisplayMember = "1";
            this.activatedAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.activatedAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activatedAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.activatedAction.FocusedColor = System.Drawing.Color.Empty;
            this.activatedAction.FocusedState.Parent = this.activatedAction;
            this.activatedAction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.activatedAction.ForeColor = System.Drawing.Color.Cyan;
            this.activatedAction.FormattingEnabled = true;
            this.activatedAction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.activatedAction.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.activatedAction.HoverState.Parent = this.activatedAction;
            this.activatedAction.ItemHeight = 40;
            this.activatedAction.Items.AddRange(new object[] {
            "Không làm gì",
            "Thoát chương trình",
            "Tắt máy",
            "Khởi động lại",
            "Khóa máy",
            "Ngủ"});
            this.activatedAction.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.activatedAction.ItemsAppearance.ForeColor = System.Drawing.Color.Cyan;
            this.activatedAction.ItemsAppearance.Parent = this.activatedAction;
            this.activatedAction.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.activatedAction.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.activatedAction.Location = new System.Drawing.Point(358, 177);
            this.activatedAction.Name = "activatedAction";
            this.activatedAction.ShadowDecoration.Parent = this.activatedAction;
            this.activatedAction.Size = new System.Drawing.Size(355, 46);
            this.activatedAction.TabIndex = 5;
            this.activatedAction.TextOffset = new System.Drawing.Point(10, 0);
            this.activatedAction.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.activatedAction.SelectedIndexChanged += new System.EventHandler(this.activatedAction_SelectedIndexChanged);
            // 
            // cleanAfterCompleted_Switch
            // 
            this.cleanAfterCompleted_Switch.Animated = true;
            this.cleanAfterCompleted_Switch.AutoRoundedCorners = true;
            this.cleanAfterCompleted_Switch.BackColor = System.Drawing.Color.Transparent;
            this.cleanAfterCompleted_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cleanAfterCompleted_Switch.CheckedState.BorderRadius = 12;
            this.cleanAfterCompleted_Switch.CheckedState.FillColor = System.Drawing.Color.Cyan;
            this.cleanAfterCompleted_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.cleanAfterCompleted_Switch.CheckedState.InnerBorderRadius = 8;
            this.cleanAfterCompleted_Switch.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.cleanAfterCompleted_Switch.CheckedState.Parent = this.cleanAfterCompleted_Switch;
            this.cleanAfterCompleted_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanAfterCompleted_Switch.Location = new System.Drawing.Point(358, 257);
            this.cleanAfterCompleted_Switch.Margin = new System.Windows.Forms.Padding(0);
            this.cleanAfterCompleted_Switch.Name = "cleanAfterCompleted_Switch";
            this.cleanAfterCompleted_Switch.ShadowDecoration.Parent = this.cleanAfterCompleted_Switch;
            this.cleanAfterCompleted_Switch.Size = new System.Drawing.Size(50, 26);
            this.cleanAfterCompleted_Switch.TabIndex = 6;
            this.cleanAfterCompleted_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cleanAfterCompleted_Switch.UncheckedState.BorderRadius = 12;
            this.cleanAfterCompleted_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.cleanAfterCompleted_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.cleanAfterCompleted_Switch.UncheckedState.InnerBorderRadius = 8;
            this.cleanAfterCompleted_Switch.UncheckedState.InnerColor = System.Drawing.Color.Cyan;
            this.cleanAfterCompleted_Switch.UncheckedState.Parent = this.cleanAfterCompleted_Switch;
            this.cleanAfterCompleted_Switch.CheckedChanged += new System.EventHandler(this.cleanAfterCompleted_Switch_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(74, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dọn dẹp sau khi hoàn tất:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // defaultSetting_Button
            // 
            this.defaultSetting_Button.Animated = true;
            this.defaultSetting_Button.AutoRoundedCorners = true;
            this.defaultSetting_Button.BackColor = System.Drawing.Color.Transparent;
            this.defaultSetting_Button.BorderColor = System.Drawing.Color.Cyan;
            this.defaultSetting_Button.BorderRadius = 23;
            this.defaultSetting_Button.BorderThickness = 3;
            this.defaultSetting_Button.CheckedState.Parent = this.defaultSetting_Button;
            this.defaultSetting_Button.CustomImages.Parent = this.defaultSetting_Button;
            this.defaultSetting_Button.FillColor = System.Drawing.Color.Cyan;
            this.defaultSetting_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.defaultSetting_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.defaultSetting_Button.HoverState.Parent = this.defaultSetting_Button;
            this.defaultSetting_Button.Location = new System.Drawing.Point(260, 468);
            this.defaultSetting_Button.Name = "defaultSetting_Button";
            this.defaultSetting_Button.ShadowDecoration.Parent = this.defaultSetting_Button;
            this.defaultSetting_Button.Size = new System.Drawing.Size(267, 49);
            this.defaultSetting_Button.TabIndex = 22;
            this.defaultSetting_Button.Text = "ĐẶT VỀ MẶC ĐỊNH";
            this.defaultSetting_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.defaultSetting_Button.Click += new System.EventHandler(this.defaultSetting_Button_Click);
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
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(753, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 24;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(74, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xuất danh sách sau khi hoàn tất:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // dataExportAfterCompleted_Switch
            // 
            this.dataExportAfterCompleted_Switch.Animated = true;
            this.dataExportAfterCompleted_Switch.AutoRoundedCorners = true;
            this.dataExportAfterCompleted_Switch.BackColor = System.Drawing.Color.Transparent;
            this.dataExportAfterCompleted_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dataExportAfterCompleted_Switch.CheckedState.BorderRadius = 12;
            this.dataExportAfterCompleted_Switch.CheckedState.FillColor = System.Drawing.Color.Cyan;
            this.dataExportAfterCompleted_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.dataExportAfterCompleted_Switch.CheckedState.InnerBorderRadius = 8;
            this.dataExportAfterCompleted_Switch.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.dataExportAfterCompleted_Switch.CheckedState.Parent = this.dataExportAfterCompleted_Switch;
            this.dataExportAfterCompleted_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataExportAfterCompleted_Switch.Location = new System.Drawing.Point(358, 324);
            this.dataExportAfterCompleted_Switch.Margin = new System.Windows.Forms.Padding(0);
            this.dataExportAfterCompleted_Switch.Name = "dataExportAfterCompleted_Switch";
            this.dataExportAfterCompleted_Switch.ShadowDecoration.Parent = this.dataExportAfterCompleted_Switch;
            this.dataExportAfterCompleted_Switch.Size = new System.Drawing.Size(50, 26);
            this.dataExportAfterCompleted_Switch.TabIndex = 25;
            this.dataExportAfterCompleted_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataExportAfterCompleted_Switch.UncheckedState.BorderRadius = 12;
            this.dataExportAfterCompleted_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.dataExportAfterCompleted_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.dataExportAfterCompleted_Switch.UncheckedState.InnerBorderRadius = 8;
            this.dataExportAfterCompleted_Switch.UncheckedState.InnerColor = System.Drawing.Color.Cyan;
            this.dataExportAfterCompleted_Switch.UncheckedState.Parent = this.dataExportAfterCompleted_Switch;
            this.dataExportAfterCompleted_Switch.CheckedChanged += new System.EventHandler(this.dataExportAfterCompleted_Switch_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(74, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nơi lưu trình cài đặt:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // otherDirectoryPath
            // 
            this.otherDirectoryPath.BackColor = System.Drawing.Color.Transparent;
            this.otherDirectoryPath.BorderColor = System.Drawing.Color.Cyan;
            this.otherDirectoryPath.BorderRadius = 5;
            this.otherDirectoryPath.BorderThickness = 2;
            this.otherDirectoryPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otherDirectoryPath.DefaultText = "";
            this.otherDirectoryPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otherDirectoryPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otherDirectoryPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otherDirectoryPath.DisabledState.Parent = this.otherDirectoryPath;
            this.otherDirectoryPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otherDirectoryPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.otherDirectoryPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otherDirectoryPath.FocusedState.Parent = this.otherDirectoryPath;
            this.otherDirectoryPath.ForeColor = System.Drawing.Color.Cyan;
            this.otherDirectoryPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otherDirectoryPath.HoverState.Parent = this.otherDirectoryPath;
            this.otherDirectoryPath.Location = new System.Drawing.Point(358, 383);
            this.otherDirectoryPath.Margin = new System.Windows.Forms.Padding(0);
            this.otherDirectoryPath.Name = "otherDirectoryPath";
            this.otherDirectoryPath.PasswordChar = '\0';
            this.otherDirectoryPath.PlaceholderText = "C:\\";
            this.otherDirectoryPath.ReadOnly = true;
            this.otherDirectoryPath.SelectedText = "";
            this.otherDirectoryPath.ShadowDecoration.Parent = this.otherDirectoryPath;
            this.otherDirectoryPath.Size = new System.Drawing.Size(270, 34);
            this.otherDirectoryPath.TabIndex = 28;
            this.otherDirectoryPath.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // otherPath_Button
            // 
            this.otherPath_Button.Animated = true;
            this.otherPath_Button.BackColor = System.Drawing.Color.Transparent;
            this.otherPath_Button.BorderColor = System.Drawing.Color.Cyan;
            this.otherPath_Button.BorderRadius = 5;
            this.otherPath_Button.BorderThickness = 2;
            this.otherPath_Button.CheckedState.Parent = this.otherPath_Button;
            this.otherPath_Button.CustomImages.Parent = this.otherPath_Button;
            this.otherPath_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.otherPath_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.otherPath_Button.ForeColor = System.Drawing.Color.Cyan;
            this.otherPath_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(163)))));
            this.otherPath_Button.HoverState.Parent = this.otherPath_Button;
            this.otherPath_Button.Location = new System.Drawing.Point(634, 383);
            this.otherPath_Button.Margin = new System.Windows.Forms.Padding(0);
            this.otherPath_Button.Name = "otherPath_Button";
            this.otherPath_Button.ShadowDecoration.Parent = this.otherPath_Button;
            this.otherPath_Button.Size = new System.Drawing.Size(79, 35);
            this.otherPath_Button.TabIndex = 29;
            this.otherPath_Button.Text = "KHÁC";
            this.otherPath_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.otherPath_Button.Click += new System.EventHandler(this.otherPath_Button_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 559);
            this.Controls.Add(this.otherPath_Button);
            this.Controls.Add(this.otherDirectoryPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataExportAfterCompleted_Switch);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.defaultSetting_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cleanAfterCompleted_Switch);
            this.Controls.Add(this.activatedAction);
            this.Controls.Add(this.activatingAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeSetter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeSetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox activatingAction;
        private Guna.UI2.WinForms.Guna2ComboBox activatedAction;
        private Guna.UI2.WinForms.Guna2ToggleSwitch cleanAfterCompleted_Switch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button defaultSetting_Button;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch dataExportAfterCompleted_Switch;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox otherDirectoryPath;
        private Guna.UI2.WinForms.Guna2Button otherPath_Button;
    }
}