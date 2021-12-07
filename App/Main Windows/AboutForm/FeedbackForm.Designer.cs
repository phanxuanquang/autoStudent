namespace App.Main_Windows.AboutForm
{
    partial class FeedbackForm
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
            this.TextFeedback = new System.Windows.Forms.RichTextBox();
            this.Send = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.roundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // TextFeedback
            // 
            this.TextFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.TextFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextFeedback.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFeedback.ForeColor = System.Drawing.Color.Gray;
            this.TextFeedback.Location = new System.Drawing.Point(14, 14);
            this.TextFeedback.Margin = new System.Windows.Forms.Padding(5);
            this.TextFeedback.Name = "TextFeedback";
            this.TextFeedback.Size = new System.Drawing.Size(320, 180);
            this.TextFeedback.TabIndex = 0;
            this.TextFeedback.Text = "Hãy góp ý cho chúng tôi để ngày càng hoàn thiện sản phẩm";
            // 
            // Send
            // 
            this.Send.Animated = true;
            this.Send.AutoRoundedCorners = true;
            this.Send.BorderRadius = 19;
            this.Send.CheckedState.Parent = this.Send;
            this.Send.CustomImages.Parent = this.Send;
            this.Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Send.ForeColor = System.Drawing.Color.White;
            this.Send.HoverState.Parent = this.Send;
            this.Send.Location = new System.Drawing.Point(182, 206);
            this.Send.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Send.Name = "Send";
            this.Send.PressedColor = System.Drawing.Color.Cyan;
            this.Send.ShadowDecoration.Parent = this.Send;
            this.Send.Size = new System.Drawing.Size(71, 40);
            this.Send.TabIndex = 1;
            this.Send.Text = "GỬI";
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Animated = true;
            this.Cancel.AutoRoundedCorners = true;
            this.Cancel.BorderRadius = 19;
            this.Cancel.CheckedState.Parent = this.Cancel;
            this.Cancel.CustomImages.Parent = this.Cancel;
            this.Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.HoverState.Parent = this.Cancel;
            this.Cancel.Location = new System.Drawing.Point(263, 206);
            this.Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Cancel.Name = "Cancel";
            this.Cancel.PressedColor = System.Drawing.Color.Cyan;
            this.Cancel.ShadowDecoration.Parent = this.Cancel;
            this.Cancel.Size = new System.Drawing.Size(71, 40);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "HỦY";
            this.Cancel.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // roundEdge
            // 
            this.roundEdge.BorderRadius = 15;
            this.roundEdge.TargetControl = this;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(349, 260);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.TextFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedbackForm";
            this.Shown += new System.EventHandler(this.FeedbackForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextFeedback;
        private Guna.UI2.WinForms.Guna2Button Send;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Elipse roundEdge;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
    }
}