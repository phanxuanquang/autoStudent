
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
            this.ConfirmButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.softList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Active = false;
            this.ConfirmButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmButton.BorderRadius = 7;
            this.ConfirmButton.ButtonText = "XÁC NHẬN VÀ CÀI ĐẶT";
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.DisabledColor = System.Drawing.Color.Gray;
            this.ConfirmButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ConfirmButton.Iconimage = null;
            this.ConfirmButton.Iconimage_right = null;
            this.ConfirmButton.Iconimage_right_Selected = null;
            this.ConfirmButton.Iconimage_Selected = null;
            this.ConfirmButton.IconMarginLeft = 0;
            this.ConfirmButton.IconMarginRight = 0;
            this.ConfirmButton.IconRightVisible = true;
            this.ConfirmButton.IconRightZoom = 0D;
            this.ConfirmButton.IconVisible = true;
            this.ConfirmButton.IconZoom = 90D;
            this.ConfirmButton.IsTab = false;
            this.ConfirmButton.Location = new System.Drawing.Point(334, 389);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ConfirmButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.ConfirmButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ConfirmButton.selected = false;
            this.ConfirmButton.Size = new System.Drawing.Size(225, 54);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "XÁC NHẬN VÀ CÀI ĐẶT";
            this.ConfirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ConfirmButton.TextFont = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // softList
            // 
            this.softList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.softList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.softList.CheckOnClick = true;
            this.softList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.softList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.softList.FormattingEnabled = true;
            this.softList.Location = new System.Drawing.Point(69, 69);
            this.softList.Name = "softList";
            this.softList.Size = new System.Drawing.Size(490, 294);
            this.softList.TabIndex = 6;
            // 
            // BaseSectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.Controls.Add(this.softList);
            this.Controls.Add(this.ConfirmButton);
            this.Location = new System.Drawing.Point(350, 100);
            this.Name = "BaseSectorView";
            this.Size = new System.Drawing.Size(629, 498);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton ConfirmButton;
        private System.Windows.Forms.CheckedListBox softList;
    }
}
