using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Main_Windows.AboutForm
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            this.TextFeedback.SelectionChanged -= RichTextBox1_SelectionChanged;
            this.TextFeedback.KeyDown -= RichTextBox1_SelectionChanged;
            this.TextFeedback.Clear();
            this.TextFeedback.ForeColor = Color.Cyan;
        }

        private void FeedbackForm_Shown(object sender, EventArgs e)
        {
            this.TextFeedback.SelectionChanged += RichTextBox1_SelectionChanged;
            this.TextFeedback.KeyDown += RichTextBox1_SelectionChanged;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Việc bạn gửi phản hồi sẽ gửi kèm với thông tin bị\nnhư tên thiết bị, phiên bản, .v.v", "Lưu ý!", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.No:
                    this.Close();
                    break;
                case DialogResult.Yes:
                    (bool, string) send = App.Main_Windows.AboutForm.SendInfo.SendFeedback(TextFeedback.Text);
                    if (!send.Item1)
                    {
                        MessageBox.Show(String.Format("Không gửi được phản hồi.\nNội dung lỗi: {0}", send.Item2));
                    }
                    this.Close();
                    break;
            }
        }
    }
}
