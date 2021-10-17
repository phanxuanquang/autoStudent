using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class kythuatTab : UserControl
    {
        public kythuatTab()
        {
            InitializeComponent();
        }

        private void addClick(dynamic sender, EventArgs e)
        {
            if (sender.Normalcolor == Color.FromArgb(255, 200, 123))
                sender.Normalcolor = Color.FromArgb(229, 164, 73);
            else sender.Normalcolor = Color.FromArgb(255, 200, 123);
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cài đặt những phần mềm đã chọn?", "XÁC NHẬN VÀ CÀI ĐẶT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No) { }
        }
    }
}
