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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        // Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void defaultSetting_Button_Click(object sender, EventArgs e)
        {
            timeSetter.Value = DateTime.Now;
            activatingAction.Text = "Không làm gì";
            activatedAction.Text = "Không làm gì";
            cleanAfterCompleted_Switch.Checked = false;
            excelExportAfterCompleted_Switch.Checked = false;
            saveSetting_Button.Tag = "saved";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (saveSetting_Button.Tag.ToString() == "saved")
                this.Close();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "THOÁT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void saveSetting_Button_Click(object sender, EventArgs e)
        {
            saveSetting_Button.Tag = "saved";
        }
    }
}
