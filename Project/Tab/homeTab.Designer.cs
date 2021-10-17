namespace Project
{
    partial class homeTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.credit = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BorderRadius = 10;
            this.contentPanel.Controls.Add(this.credit);
            this.contentPanel.FillColor = System.Drawing.Color.White;
            this.contentPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.contentPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.ShadowDecoration.Parent = this.contentPanel;
            this.contentPanel.Size = new System.Drawing.Size(945, 471);
            this.contentPanel.TabIndex = 11;
            // 
            // credit
            // 
            this.credit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.credit.BackColor = System.Drawing.Color.Transparent;
            this.credit.Font = new System.Drawing.Font("UTM Daxline", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.LightGray;
            this.credit.Location = new System.Drawing.Point(189, 186);
            this.credit.Name = "credit";
            this.credit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.credit.Size = new System.Drawing.Size(567, 98);
            this.credit.TabIndex = 2;
            this.credit.Text = "Được phát triển bởi nhóm sinh viên Đại học Công nghệ Thông tin thành phố Hồ Chí M" +
    "inh";
            this.credit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Name = "homeTab";
            this.Size = new System.Drawing.Size(945, 471);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel contentPanel;
        private System.Windows.Forms.Label credit;
    }
}
