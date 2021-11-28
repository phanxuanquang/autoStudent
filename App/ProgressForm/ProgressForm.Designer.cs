namespace App.ProgressForm
{
    partial class ProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.exitButton_Above = new Guna.UI2.WinForms.Guna2Button();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton_Above
            // 
            this.exitButton_Above.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton_Above.Animated = true;
            this.exitButton_Above.BackColor = System.Drawing.Color.Transparent;
            this.exitButton_Above.BorderColor = System.Drawing.Color.Cyan;
            this.exitButton_Above.BorderRadius = 3;
            this.exitButton_Above.CheckedState.Parent = this.exitButton_Above;
            this.exitButton_Above.CustomImages.Parent = this.exitButton_Above;
            this.exitButton_Above.FillColor = System.Drawing.Color.Transparent;
            this.exitButton_Above.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton_Above.ForeColor = System.Drawing.Color.White;
            this.exitButton_Above.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(125)))));
            this.exitButton_Above.HoverState.Parent = this.exitButton_Above;
            this.exitButton_Above.Image = ((System.Drawing.Image)(resources.GetObject("exitButton_Above.Image")));
            this.exitButton_Above.Location = new System.Drawing.Point(734, 14);
            this.exitButton_Above.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.exitButton_Above.Name = "exitButton_Above";
            this.exitButton_Above.ShadowDecoration.Parent = this.exitButton_Above;
            this.exitButton_Above.Size = new System.Drawing.Size(30, 30);
            this.exitButton_Above.TabIndex = 6;
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
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(699, 14);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(731, 410);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(746, 60);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2VScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 10;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(10, 410);
            this.guna2VScrollBar1.TabIndex = 0;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 482);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitButton_Above);
            this.Controls.Add(this.minimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exitButton_Above;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}