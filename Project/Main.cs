using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainUI : Form
    {
        UserControl tab;
        int KT, CNTT, DH;

        public MainUI()
        {
            InitializeComponent();
            KT = Engineering_Button.Location.X;
            CNTT = IT_Button.Location.X;
            DH = Graphic_Button.Location.X;
        }

        // Add shadow for form
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // Move form via banner
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(this.Location.X - lastLocation.X + e.X, this.Location.Y - lastLocation.Y + e.Y);
                this.Update();
            }
        }

        // Fade out when close form
        private void FadeOut(Form o, int time = 300)
        {
            while (o.Opacity > 0.0)
            {
                Thread.Sleep(time / 100);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; 
        }

        private void addUserPanel(UserControl UserPanel)
        {
            UserPanel.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(UserPanel);
            UserPanel.BringToFront();
        }

        private void buttonTransform(dynamic button)
        {
            button.Width = Graphic_Button.Width + Graphic_Button.Location.X - Engineering_Button.Location.X;
            button.Font = new Font("UTM Daxline", 20, FontStyle.Bold);
            button.Location = Engineering_Button.Location;
            button.BringToFront();
        }
        private void buttonTransformBack(dynamic button, int defaultLocation)
        {
            if (button.Width == Graphic_Button.Width + Graphic_Button.Location.X - Engineering_Button.Location.X)
            {
                button.Font = new Font("UTM Daxline", 12, FontStyle.Bold);
                button.Location = new Point(defaultLocation, 74);
                button.Width = 253;
            }
        }

        private void Engineering_Button_Click(object sender, EventArgs e)
        {
            buttonTransform(Engineering_Button);
            tab = new kythuatTab();
            addUserPanel(tab);
        }
        private void IT_Button_Click(object sender, EventArgs e)
        {
            buttonTransform(IT_Button);
            tab = new cnttTab();
            addUserPanel(tab);
        }
        private void Graphic_Button_Click(object sender, EventArgs e)
        {
            buttonTransform(Graphic_Button);
            tab = new dohoaTab();
            addUserPanel(tab);
        }

        // Return to Main UI
        private void doubleClick(object sender, MouseEventArgs e)
        {
            tab = new homeTab();
            addUserPanel(tab);
            buttonTransformBack(IT_Button, CNTT);
            buttonTransformBack(Graphic_Button, DH);
            buttonTransformBack(Engineering_Button, KT);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FadeOut(this, 300);
            Application.Exit();
        }
        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
