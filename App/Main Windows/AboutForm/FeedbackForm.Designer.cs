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
            this.Send = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.roundEdge = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.TextFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Animated = true;
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Send.BorderColor = System.Drawing.Color.Cyan;
            this.Send.BorderRadius = 10;
            this.Send.BorderThickness = 2;
            this.Send.CheckedState.Parent = this.Send;
            this.Send.CustomImages.Parent = this.Send;
            this.Send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Send.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Send.ForeColor = System.Drawing.Color.Cyan;
            this.Send.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Send.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Send.HoverState.Parent = this.Send;
            this.Send.Location = new System.Drawing.Point(114, 222);
            this.Send.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Send.Name = "Send";
            this.Send.PressedColor = System.Drawing.Color.Cyan;
            this.Send.ShadowDecoration.Parent = this.Send;
            this.Send.Size = new System.Drawing.Size(71, 40);
            this.Send.TabIndex = 1;
            this.Send.Text = "GỬI";
            this.Send.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Animated = true;
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Cancel.BorderColor = System.Drawing.Color.Cyan;
            this.Cancel.BorderRadius = 10;
            this.Cancel.BorderThickness = 2;
            this.Cancel.CheckedState.Parent = this.Cancel;
            this.Cancel.CustomImages.Parent = this.Cancel;
            this.Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cancel.ForeColor = System.Drawing.Color.Cyan;
            this.Cancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.Cancel.HoverState.Parent = this.Cancel;
            this.Cancel.Location = new System.Drawing.Point(213, 222);
            this.Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Cancel.Name = "Cancel";
            this.Cancel.PressedColor = System.Drawing.Color.Cyan;
            this.Cancel.ShadowDecoration.Parent = this.Cancel;
            this.Cancel.Size = new System.Drawing.Size(71, 40);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "HỦY";
            this.Cancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // roundEdge
            // 
            this.roundEdge.BorderRadius = 15;
            this.roundEdge.TargetControl = this;
            // 
            // TextFeedback
            // 
            this.TextFeedback.Animated = true;
            this.TextFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.TextFeedback.BorderColor = System.Drawing.Color.Cyan;
            this.TextFeedback.BorderRadius = 10;
            this.TextFeedback.BorderThickness = 2;
            this.TextFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextFeedback.DefaultText = "";
            this.TextFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextFeedback.DisabledState.Parent = this.TextFeedback;
            this.TextFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(87)))));
            this.TextFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextFeedback.FocusedState.Parent = this.TextFeedback;
            this.TextFeedback.ForeColor = System.Drawing.Color.Cyan;
            this.TextFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextFeedback.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.TextFeedback.HoverState.Parent = this.TextFeedback;
            this.TextFeedback.Location = new System.Drawing.Point(37, 18);
            this.TextFeedback.Multiline = true;
            this.TextFeedback.Name = "TextFeedback";
            this.TextFeedback.PasswordChar = '\0';
            this.TextFeedback.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.TextFeedback.PlaceholderText = " Gửi phản hồi để giúp sản phẩm ngày càng hoàn thiện";
            this.TextFeedback.SelectedText = "";
            this.TextFeedback.ShadowDecoration.Parent = this.TextFeedback;
            this.TextFeedback.Size = new System.Drawing.Size(324, 189);
            this.TextFeedback.TabIndex = 3;
            this.TextFeedback.TextOffset = new System.Drawing.Point(5, 5);
            // 
            // guna2DragControl
            // 
            this.guna2DragControl.TargetControl = this;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::App.Properties.Resources.Background__SubWindow_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 282);
            this.Controls.Add(this.TextFeedback);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phản hồi";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Send;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Elipse roundEdge;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2TextBox TextFeedback;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl;
    }
}