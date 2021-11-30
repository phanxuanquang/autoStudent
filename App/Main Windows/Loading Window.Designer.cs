﻿
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
            this.dataLoadingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.dataLoading_clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dataLoadingProgressBar
            // 
            this.dataLoadingProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLoadingProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.dataLoadingProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dataLoadingProgressBar.Location = new System.Drawing.Point(0, 415);
            this.dataLoadingProgressBar.Name = "dataLoadingProgressBar";
            this.dataLoadingProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(106)))), ((int)(((byte)(204)))));
            this.dataLoadingProgressBar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.dataLoadingProgressBar.ShadowDecoration.Parent = this.dataLoadingProgressBar;
            this.dataLoadingProgressBar.Size = new System.Drawing.Size(707, 30);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(707, 445);
            this.Controls.Add(this.dataLoadingProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadindWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autoStudent";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar dataLoadingProgressBar;
        private System.Windows.Forms.Timer dataLoading_clock;
    }
}

