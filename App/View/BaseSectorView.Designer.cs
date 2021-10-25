
namespace App.View
{
    partial class BaseSectorView
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
            this.ITTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ITTab
            // 
            this.ITTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.ITTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ITTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ITTab.BorderRadius = 7;
            this.ITTab.ButtonText = "XÁC NHẬN VÀ CÀI ĐẶT";
            this.ITTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ITTab.DisabledColor = System.Drawing.Color.Gray;
            this.ITTab.Iconcolor = System.Drawing.Color.Transparent;
            this.ITTab.Iconimage = null;
            this.ITTab.Iconimage_right = null;
            this.ITTab.Iconimage_right_Selected = null;
            this.ITTab.Iconimage_Selected = null;
            this.ITTab.IconMarginLeft = 0;
            this.ITTab.IconMarginRight = 0;
            this.ITTab.IconRightVisible = true;
            this.ITTab.IconRightZoom = 0D;
            this.ITTab.IconVisible = true;
            this.ITTab.IconZoom = 90D;
            this.ITTab.IsTab = false;
            this.ITTab.Location = new System.Drawing.Point(334, 389);
            this.ITTab.Margin = new System.Windows.Forms.Padding(0);
            this.ITTab.Name = "ITTab";
            this.ITTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ITTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.ITTab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ITTab.selected = false;
            this.ITTab.Size = new System.Drawing.Size(225, 54);
            this.ITTab.TabIndex = 5;
            this.ITTab.Text = "XÁC NHẬN VÀ CÀI ĐẶT";
            this.ITTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ITTab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ITTab.TextFont = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Microsoft Visual Studio Code",
            "Microsoft Visual Studio Community",
            "SQL Server Management Studio",
            "Oracle VM VirtualBox",
            "Wireshark",
            "Android Studio"});
            this.checkedListBox1.Location = new System.Drawing.Point(69, 69);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(490, 294);
            this.checkedListBox1.TabIndex = 6;
            // 
            // BaseSectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ITTab);
            this.Location = new System.Drawing.Point(350, 100);
            this.Name = "BaseSectorView";
            this.Size = new System.Drawing.Size(629, 498);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton ITTab;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
