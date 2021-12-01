using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ProgressWindow_Base : Form
    {
        protected List<Package> listSoftware;
        public enum StatusDataGridView
        {
            None,
            Downloading,
            Installing,
            Uninstalling,
            Completed,
            Canceled,
            Failed
        }

        public ProgressWindow_Base(List<Package> listSoftware) : this()
        {
            this.listSoftware = listSoftware;
            UpdateCompletedAmount(0);
        }
        public ProgressWindow_Base()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        //Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        protected virtual void LoadDataGridView() { }

        protected void UpdateCompletedAmount(int value)
        {
            if (listSoftware != null && value >= 0)
            {
                try
                {
                    progressBar.Value = Convert.ToInt32(value / listSoftware.Count);
                    completedAmountLabel.Text = String.Format("{0}/{1}", value, listSoftware.Count);
                }
                catch
                {
                    progressBar.BeginInvoke(new Action(() =>
                    {
                        progressBar.Value = Convert.ToInt32(value / listSoftware.Count);
                    }));
                    completedAmountLabel.BeginInvoke(new Action(() =>
                    {
                        completedAmountLabel.Text = String.Format("{0}/{1}", value, listSoftware.Count);
                    }));
                }
            }
        }

        protected Image GetImageStatus(StatusDataGridView status)
        {
            Image result = null;
            switch (status)
            {
                case StatusDataGridView.Downloading:
                    break;
                case StatusDataGridView.Installing:
                    break;
                case StatusDataGridView.Uninstalling:
                    break;
                case StatusDataGridView.Completed:
                    break;
                case StatusDataGridView.Canceled:
                    break;
                case StatusDataGridView.Failed:
                    break;
                case StatusDataGridView.None:
                    break;
            }
            return result;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            softwareGridView.Visible = !softwareGridView.Visible;
        }
    }
}
