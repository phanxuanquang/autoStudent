using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Main_Windows.AboutForm
{
    public partial class AboutForm : Form
    {
        Timer timer;
        List<(Point, Color)> defaultFormat;
        int y = 43;
        int max = 40;
        int index = 0;

        public AboutForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            defaultFormat = new List<(Point, Color)>();
            for (int index = 0; index < this.panel1.Controls.Count; index++)
            {
                defaultFormat.Add((this.panel1.Controls[index].Location, this.panel1.Controls[index].ForeColor));
                this.panel1.Controls[index].Location = new Point(this.panel1.Controls[index].Location.X, this.panel1.Controls[index].Location.Y + y);
                this.panel1.Controls[index].ForeColor = Color.FromArgb(34, 40, 87);
            }
            SetDoubleBuffered(this.panel1);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            //https://stackoverflow.com/questions/76993/how-to-double-buffer-net-controls-on-a-form/77233#77233
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.panel1.SuspendLayout();
            if (index < panel1.Controls.Count)
            {
                if (this.panel1.Controls[index].ForeColor.G < 255)
                {
                    this.panel1.Controls[index].Visible = true;
                    if (y > 0)
                    {
                        y--;
                        panel1.Controls[index].Location = new System.Drawing.Point(panel1.Controls[index].Location.X, panel1.Controls[index].Location.Y - 1);
                    }
                    if (panel1.Controls[index].ForeColor.G < 255)
                    {
                        max += 5;
                        panel1.Controls[index].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(max)))), ((int)(((byte)(max)))));
                    }
                    this.panel1.ResumeLayout(false);
                }
                else
                {
                    index++;
                    max = 40;
                    y = 43;
                }
            }
            else timer.Stop();
            timer.Start();
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process openGitHub = new Process();
            openGitHub.StartInfo.FileName = "CMD.exe";
            openGitHub.StartInfo.Arguments = "/C start https://github.com/phanxuanquang/autoStudent";
            openGitHub.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            openGitHub.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            App.Main_Windows.AboutForm.FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            for(int index = 0; index < this.panel1.Controls.Count; index++)
            {
                this.panel1.Controls[index].Location = defaultFormat[index].Item1;
                this.panel1.Controls[index].ForeColor = defaultFormat[index].Item2;
                this.panel1.Controls[index].Visible = true;
            }
        }
    }
}
