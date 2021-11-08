
namespace App
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.MultimediaTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GitHub_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TechnicalityTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ITTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.softName = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.menuPanel.Controls.Add(this.MultimediaTab);
            this.menuPanel.Controls.Add(this.GitHub_Button);
            this.menuPanel.Controls.Add(this.TechnicalityTab);
            this.menuPanel.Controls.Add(this.ITTab);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(135, 590);
            this.menuPanel.TabIndex = 4;
            // 
            // MultimediaTab
            // 
            this.MultimediaTab.Active = false;
            this.MultimediaTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.MultimediaTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultimediaTab.BackColor = System.Drawing.Color.Transparent;
            this.MultimediaTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MultimediaTab.BorderRadius = 0;
            this.MultimediaTab.ButtonText = "";
            this.MultimediaTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultimediaTab.DisabledColor = System.Drawing.Color.Gray;
            this.MultimediaTab.Iconcolor = System.Drawing.Color.Transparent;
            this.MultimediaTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("MultimediaTab.Iconimage")));
            this.MultimediaTab.Iconimage_right = null;
            this.MultimediaTab.Iconimage_right_Selected = null;
            this.MultimediaTab.Iconimage_Selected = null;
            this.MultimediaTab.IconMarginLeft = 0;
            this.MultimediaTab.IconMarginRight = 0;
            this.MultimediaTab.IconRightVisible = true;
            this.MultimediaTab.IconRightZoom = 0D;
            this.MultimediaTab.IconVisible = true;
            this.MultimediaTab.IconZoom = 90D;
            this.MultimediaTab.IsTab = false;
            this.MultimediaTab.Location = new System.Drawing.Point(0, 359);
            this.MultimediaTab.Margin = new System.Windows.Forms.Padding(0);
            this.MultimediaTab.Name = "MultimediaTab";
            this.MultimediaTab.Normalcolor = System.Drawing.Color.Transparent;
            this.MultimediaTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.MultimediaTab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.MultimediaTab.selected = false;
            this.MultimediaTab.Size = new System.Drawing.Size(135, 128);
            this.MultimediaTab.TabIndex = 8;
            this.MultimediaTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultimediaTab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.MultimediaTab.TextFont = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MultimediaTab.Click += new System.EventHandler(this.MultimediaTab_Click);
            // 
            // GitHub_Button
            // 
            this.GitHub_Button.Active = false;
            this.GitHub_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.GitHub_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.GitHub_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GitHub_Button.BorderRadius = 0;
            this.GitHub_Button.ButtonText = "Github";
            this.GitHub_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub_Button.DisabledColor = System.Drawing.Color.Gray;
            this.GitHub_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GitHub_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.GitHub_Button.Iconimage = null;
            this.GitHub_Button.Iconimage_right = null;
            this.GitHub_Button.Iconimage_right_Selected = null;
            this.GitHub_Button.Iconimage_Selected = null;
            this.GitHub_Button.IconMarginLeft = 0;
            this.GitHub_Button.IconMarginRight = 0;
            this.GitHub_Button.IconRightVisible = true;
            this.GitHub_Button.IconRightZoom = 0D;
            this.GitHub_Button.IconVisible = true;
            this.GitHub_Button.IconZoom = 90D;
            this.GitHub_Button.IsTab = false;
            this.GitHub_Button.Location = new System.Drawing.Point(0, 546);
            this.GitHub_Button.Margin = new System.Windows.Forms.Padding(0);
            this.GitHub_Button.Name = "GitHub_Button";
            this.GitHub_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.GitHub_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(172)))));
            this.GitHub_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.GitHub_Button.selected = false;
            this.GitHub_Button.Size = new System.Drawing.Size(135, 44);
            this.GitHub_Button.TabIndex = 7;
            this.GitHub_Button.Text = "Github";
            this.GitHub_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GitHub_Button.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.GitHub_Button.TextFont = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHub_Button.Click += new System.EventHandler(this.GitHub_Button_Click);
            // 
            // TechnicalityTab
            // 
            this.TechnicalityTab.Active = false;
            this.TechnicalityTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.TechnicalityTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechnicalityTab.BackColor = System.Drawing.Color.Transparent;
            this.TechnicalityTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TechnicalityTab.BorderRadius = 0;
            this.TechnicalityTab.ButtonText = "";
            this.TechnicalityTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TechnicalityTab.DisabledColor = System.Drawing.Color.Gray;
            this.TechnicalityTab.Iconcolor = System.Drawing.Color.Transparent;
            this.TechnicalityTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("TechnicalityTab.Iconimage")));
            this.TechnicalityTab.Iconimage_right = null;
            this.TechnicalityTab.Iconimage_right_Selected = null;
            this.TechnicalityTab.Iconimage_Selected = null;
            this.TechnicalityTab.IconMarginLeft = 0;
            this.TechnicalityTab.IconMarginRight = 0;
            this.TechnicalityTab.IconRightVisible = true;
            this.TechnicalityTab.IconRightZoom = 0D;
            this.TechnicalityTab.IconVisible = true;
            this.TechnicalityTab.IconZoom = 90D;
            this.TechnicalityTab.IsTab = false;
            this.TechnicalityTab.Location = new System.Drawing.Point(0, 231);
            this.TechnicalityTab.Margin = new System.Windows.Forms.Padding(0);
            this.TechnicalityTab.Name = "TechnicalityTab";
            this.TechnicalityTab.Normalcolor = System.Drawing.Color.Transparent;
            this.TechnicalityTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.TechnicalityTab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.TechnicalityTab.selected = false;
            this.TechnicalityTab.Size = new System.Drawing.Size(135, 128);
            this.TechnicalityTab.TabIndex = 5;
            this.TechnicalityTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TechnicalityTab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.TechnicalityTab.TextFont = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TechnicalityTab.Click += new System.EventHandler(this.TechnicalityTab_Click);
            // 
            // ITTab
            // 
            this.ITTab.Active = false;
            this.ITTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(143)))));
            this.ITTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITTab.BackColor = System.Drawing.Color.Transparent;
            this.ITTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ITTab.BorderRadius = 0;
            this.ITTab.ButtonText = "";
            this.ITTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ITTab.DisabledColor = System.Drawing.Color.Gray;
            this.ITTab.Iconcolor = System.Drawing.Color.Transparent;
            this.ITTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("ITTab.Iconimage")));
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
            this.ITTab.Location = new System.Drawing.Point(0, 103);
            this.ITTab.Margin = new System.Windows.Forms.Padding(0);
            this.ITTab.Name = "ITTab";
            this.ITTab.Normalcolor = System.Drawing.Color.Transparent;
            this.ITTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(181)))));
            this.ITTab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ITTab.selected = false;
            this.ITTab.Size = new System.Drawing.Size(135, 128);
            this.ITTab.TabIndex = 4;
            this.ITTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ITTab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.ITTab.TextFont = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ITTab.Click += new System.EventHandler(this.ITTab_Click);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(0, 12);
            this.menuButton.Margin = new System.Windows.Forms.Padding(0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(135, 40);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 3;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 0;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(916, 12);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(21, 23);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(947, 12);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(21, 23);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // softName
            // 
            this.softName.AutoSize = true;
            this.softName.BackColor = System.Drawing.Color.Transparent;
            this.softName.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.softName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(251)))), ((int)(((byte)(217)))));
            this.softName.Location = new System.Drawing.Point(298, 249);
            this.softName.Margin = new System.Windows.Forms.Padding(0);
            this.softName.Name = "softName";
            this.softName.Size = new System.Drawing.Size(507, 93);
            this.softName.TabIndex = 9;
            this.softName.Text = "autoStudent";
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(236, 42);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(630, 498);
            this.contentPanel.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(980, 590);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.softName);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton GitHub_Button;
        private Bunifu.Framework.UI.BunifuFlatButton TechnicalityTab;
        private Bunifu.Framework.UI.BunifuFlatButton ITTab;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuFlatButton MultimediaTab;
        private System.Windows.Forms.Label softName;
        private System.Windows.Forms.Panel contentPanel;
    }
}

