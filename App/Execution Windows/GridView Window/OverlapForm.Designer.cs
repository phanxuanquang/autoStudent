namespace App
{
    partial class OverlapForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.originalGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.softwareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // originalGridView
            // 
            this.originalGridView.AllowUserToAddRows = false;
            this.originalGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.originalGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.originalGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.originalGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.originalGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.originalGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.originalGridView.ColumnHeadersHeight = 30;
            this.originalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.originalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareName});
            this.originalGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.originalGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.originalGridView.EnableHeadersVisualStyles = false;
            this.originalGridView.GridColor = System.Drawing.Color.Cyan;
            this.originalGridView.Location = new System.Drawing.Point(79, 43);
            this.originalGridView.MultiSelect = false;
            this.originalGridView.Name = "originalGridView";
            this.originalGridView.ReadOnly = true;
            this.originalGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.originalGridView.RowHeadersVisible = false;
            this.originalGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.originalGridView.RowTemplate.Height = 25;
            this.originalGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.originalGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.originalGridView.Size = new System.Drawing.Size(325, 383);
            this.originalGridView.TabIndex = 18;
            this.originalGridView.Tag = "unclicked";
            this.originalGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.originalGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.originalGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.originalGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.originalGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.originalGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.originalGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.originalGridView.ThemeStyle.ReadOnly = true;
            this.originalGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.originalGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.originalGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.RowsStyle.Height = 25;
            this.originalGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.originalGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.originalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.originalGridView_CellClick);
            // 
            // softwareName
            // 
            this.softwareName.HeaderText = "PHẦN MỀM BỊ TRÙNG";
            this.softwareName.Name = "softwareName";
            this.softwareName.ReadOnly = true;
            this.softwareName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // finalGridView
            // 
            this.finalGridView.AllowUserToAddRows = false;
            this.finalGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.finalGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finalGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.finalGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finalGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.finalGridView.ColumnHeadersHeight = 30;
            this.finalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.finalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.finalGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finalGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.finalGridView.EnableHeadersVisualStyles = false;
            this.finalGridView.GridColor = System.Drawing.Color.Cyan;
            this.finalGridView.Location = new System.Drawing.Point(464, 43);
            this.finalGridView.Margin = new System.Windows.Forms.Padding(0);
            this.finalGridView.MultiSelect = false;
            this.finalGridView.Name = "finalGridView";
            this.finalGridView.ReadOnly = true;
            this.finalGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.finalGridView.RowHeadersVisible = false;
            this.finalGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.finalGridView.RowTemplate.Height = 25;
            this.finalGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.finalGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.finalGridView.Size = new System.Drawing.Size(325, 383);
            this.finalGridView.TabIndex = 19;
            this.finalGridView.Tag = "unclicked";
            this.finalGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.finalGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finalGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.finalGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.finalGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.finalGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.finalGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.finalGridView.ThemeStyle.ReadOnly = true;
            this.finalGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.finalGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.finalGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.RowsStyle.Height = 25;
            this.finalGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Cyan;
            this.finalGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.finalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finalGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PHẦN MỀM MUỐN GIỮ LẠI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.confirmButton.Location = new System.Drawing.Point(324, 452);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(220, 49);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "TIẾP TỤC";
            this.confirmButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // OverlapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.Background__SubWindow_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 537);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.finalGridView);
            this.Controls.Add(this.originalGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverlapForm";
            this.Text = "OverlapForm";
            ((System.ComponentModel.ISupportInitialize)(this.originalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView originalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareName;
        private Guna.UI2.WinForms.Guna2DataGridView finalGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
    }
}