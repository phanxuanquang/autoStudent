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
            this.Icon = Properties.Resources.mainIcon;
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Phản hồi của bạn sẽ được tự động đính kèm thông tin về thiết bị máy tính đang sử dụng.\nBạn có chắc chắn muốn gửi phản hồi?", "Lưu ý!", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.No:
                    this.Close();
                    break;
                case DialogResult.Yes:
                    (bool, string) send = App.Main_Windows.AboutForm.SendInfo.SendFeedback(TextFeedback.Text);
                    if (!send.Item1)
                    {
                        MessageBox.Show(String.Format("Không thể gửi phản hồi.\nNội dung lỗi: {0}", send.Item2));
                    }
                    this.Close();
                    break;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (TextFeedback.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Phản hồi chưa hoàn tất, bạn có chắc chắn muốn hủy bỏ phản hồi?", "HỦY", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }
    }
}
