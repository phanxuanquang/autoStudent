
namespace App
{
    partial class LoadindWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadindWindow));
            this.backgroundPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataLoadingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.dataLoading_clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.backgroundPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.backgroundPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.backgroundPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.ShadowDecoration.Parent = this.backgroundPanel;
            this.backgroundPanel.Size = new System.Drawing.Size(600, 450);
            this.backgroundPanel.TabIndex = 0;
            // 
            // dataLoadingProgressBar
            // 
            this.dataLoadingProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLoadingProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dataLoadingProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dataLoadingProgressBar.Location = new System.Drawing.Point(0, 420);
            this.dataLoadingProgressBar.Name = "dataLoadingProgressBar";
            this.dataLoadingProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(106)))), ((int)(((byte)(204)))));
            this.dataLoadingProgressBar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.dataLoadingProgressBar.ShadowDecoration.Parent = this.dataLoadingProgressBar;
            this.dataLoadingProgressBar.Size = new System.Drawing.Size(600, 30);
            this.dataLoadingProgressBar.TabIndex = 18;
            this.dataLoadingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dataLoading_clock
            // 
            this.dataLoading_clock.Interval = 1;
            this.dataLoading_clock.Tick += new System.EventHandler(this.dataLoading_clock_Tick);
            // 
            // LoadindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dataLoadingProgressBar);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadindWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autoStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel backgroundPanel;
        private Guna.UI2.WinForms.Guna2ProgressBar dataLoadingProgressBar;
        private System.Windows.Forms.Timer dataLoading_clock;
    }
}

