namespace App
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.continueButton = new Guna.UI2.WinForms.Guna2Button();
            this.selectedSoftwareView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.allSoftwareView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.softwareGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.softwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).BeginInit();
            this.SuspendLayout();
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
            this.exitButton.Location = new System.Drawing.Point(828, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 17;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Animated = true;
            this.continueButton.AutoRoundedCorners = true;
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.BorderColor = System.Drawing.Color.Cyan;
            this.continueButton.BorderRadius = 20;
            this.continueButton.BorderThickness = 2;
            this.continueButton.CheckedState.Parent = this.continueButton;
            this.continueButton.CustomImages.Parent = this.continueButton;
            this.continueButton.FillColor = System.Drawing.Color.Cyan;
            this.continueButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.continueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.continueButton.HoverState.Parent = this.continueButton;
            this.continueButton.Location = new System.Drawing.Point(542, 484);
            this.continueButton.Name = "continueButton";
            this.continueButton.PressedColor = System.Drawing.Color.Cyan;
            this.continueButton.PressedDepth = 20;
            this.continueButton.ShadowDecoration.Parent = this.continueButton;
            this.continueButton.Size = new System.Drawing.Size(168, 42);
            this.continueButton.TabIndex = 16;
            this.continueButton.Text = "TIẾP TỤC";
            this.continueButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // selectedSoftwareView_Button
            // 
            this.selectedSoftwareView_Button.Animated = true;
            this.selectedSoftwareView_Button.AutoRoundedCorners = true;
            this.selectedSoftwareView_Button.BackColor = System.Drawing.Color.Transparent;
            this.selectedSoftwareView_Button.BorderColor = System.Drawing.Color.Cyan;
            this.selectedSoftwareView_Button.BorderRadius = 20;
            this.selectedSoftwareView_Button.BorderThickness = 2;
            this.selectedSoftwareView_Button.CheckedState.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.CustomImages.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.FillColor = System.Drawing.Color.Transparent;
            this.selectedSoftwareView_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.selectedSoftwareView_Button.ForeColor = System.Drawing.Color.Cyan;
            this.selectedSoftwareView_Button.HoverState.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.Location = new System.Drawing.Point(348, 484);
            this.selectedSoftwareView_Button.Name = "selectedSoftwareView_Button";
            this.selectedSoftwareView_Button.PressedColor = System.Drawing.Color.Cyan;
            this.selectedSoftwareView_Button.PressedDepth = 20;
            this.selectedSoftwareView_Button.ShadowDecoration.Parent = this.selectedSoftwareView_Button;
            this.selectedSoftwareView_Button.Size = new System.Drawing.Size(168, 42);
            this.selectedSoftwareView_Button.TabIndex = 15;
            this.selectedSoftwareView_Button.Text = "Phần mềm đã chọn";
            this.selectedSoftwareView_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.selectedSoftwareView_Button.Click += new System.EventHandler(this.selectedSoftwareView_Button_Click);
            // 
            // allSoftwareView_Button
            // 
            this.allSoftwareView_Button.Animated = true;
            this.allSoftwareView_Button.AutoRoundedCorners = true;
            this.allSoftwareView_Button.BackColor = System.Drawing.Color.Transparent;
            this.allSoftwareView_Button.BorderColor = System.Drawing.Color.Cyan;
            this.allSoftwareView_Button.BorderRadius = 20;
            this.allSoftwareView_Button.BorderThickness = 2;
            this.allSoftwareView_Button.CheckedState.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.CustomImages.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.FillColor = System.Drawing.Color.Transparent;
            this.allSoftwareView_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.allSoftwareView_Button.ForeColor = System.Drawing.Color.Cyan;
            this.allSoftwareView_Button.HoverState.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.Location = new System.Drawing.Point(155, 484);
            this.allSoftwareView_Button.Name = "allSoftwareView_Button";
            this.allSoftwareView_Button.PressedColor = System.Drawing.Color.Cyan;
            this.allSoftwareView_Button.PressedDepth = 20;
            this.allSoftwareView_Button.ShadowDecoration.Parent = this.allSoftwareView_Button;
            this.allSoftwareView_Button.Size = new System.Drawing.Size(168, 42);
            this.allSoftwareView_Button.TabIndex = 14;
            this.allSoftwareView_Button.Text = "Tất cả phần mềm";
            this.allSoftwareView_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.allSoftwareView_Button.Click += new System.EventHandler(this.allSoftwareView_Button_Click);
            // 
            // softwareGridView
            // 
            this.softwareGridView.AllowUserToAddRows = false;
            this.softwareGridView.AllowUserToDeleteRows = false;
            this.softwareGridView.AllowUserToResizeColumns = false;
            this.softwareGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.softwareGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softwareGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.softwareGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.softwareGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.softwareGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.softwareGridView.ColumnHeadersHeight = 30;
            this.softwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.softwareGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareName,
            this.softwareVersion});
            this.softwareGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.softwareGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.softwareGridView.EnableHeadersVisualStyles = false;
            this.softwareGridView.GridColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.softwareGridView.Location = new System.Drawing.Point(155, 122);
            this.softwareGridView.Name = "softwareGridView";
            this.softwareGridView.ReadOnly = true;
            this.softwareGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.softwareGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.softwareGridView.RowHeadersVisible = false;
            this.softwareGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.softwareGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.RowTemplate.Height = 25;
            this.softwareGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.softwareGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.softwareGridView.ShowCellErrors = false;
            this.softwareGridView.Size = new System.Drawing.Size(555, 344);
            this.softwareGridView.TabIndex = 13;
            this.softwareGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.softwareGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.softwareGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(47)))));
            this.softwareGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.softwareGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.softwareGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.softwareGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.softwareGridView.ThemeStyle.ReadOnly = true;
            this.softwareGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.softwareGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.softwareGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.softwareGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.RowsStyle.Height = 25;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.softwareGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.softwareGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.softwareGridView_CellClick);
            // 
            // softwareName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareName.DefaultCellStyle = dataGridViewCellStyle3;
            this.softwareName.HeaderText = "TÊN PHẦN MỀM";
            this.softwareName.Name = "softwareName";
            this.softwareName.ReadOnly = true;
            // 
            // softwareVersion
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.softwareVersion.DefaultCellStyle = dataGridViewCellStyle4;
            this.softwareVersion.HeaderText = "PHIÊN BẢN PHẦN MỀM";
            this.softwareVersion.Name = "softwareVersion";
            this.softwareVersion.ReadOnly = true;
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.AutoRoundedCorners = true;
            this.searchBox.AutoScroll = true;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Cyan;
            this.searchBox.BorderRadius = 20;
            this.searchBox.BorderThickness = 2;
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
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.searchBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBox.Location = new System.Drawing.Point(155, 67);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.searchBox.PlaceholderText = "Tìm phần mềm trong danh sách";
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.Size = new System.Drawing.Size(555, 42);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextOffset = new System.Drawing.Point(10, 0);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 593);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.selectedSoftwareView_Button);
            this.Controls.Add(this.allSoftwareView_Button);
            this.Controls.Add(this.softwareGridView);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.softwareGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button continueButton;
        private Guna.UI2.WinForms.Guna2Button selectedSoftwareView_Button;
        private Guna.UI2.WinForms.Guna2Button allSoftwareView_Button;
        private Guna.UI2.WinForms.Guna2DataGridView softwareGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareVersion;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}