
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
            this.softList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
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
            this.Location = new System.Drawing.Point(350, 100);
            this.Name = "BaseSectorView";
            this.Size = new System.Drawing.Size(629, 498);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox softList;
    }
}
