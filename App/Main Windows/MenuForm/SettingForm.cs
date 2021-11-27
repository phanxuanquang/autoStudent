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
            setToDefault();
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
            setToDefault();
        }

        private void setToDefault()
        {
            Setting defaultSetting = new Setting();
            timeSetter.Value = Program.setting.timeSetter = defaultSetting.timeSetter;
            activatingAction.Text = Program.setting.activatingAction = defaultSetting.activatingAction;
            activatedAction.Text = Program.setting.activatedAction = defaultSetting.activatedAction;
            cleanAfterCompleted_Switch.Checked = Program.setting.cleanAfterCompleted = defaultSetting.cleanAfterCompleted;
            dataExportAfterCompleted_Switch.Checked = Program.setting.dataExportAfterCompleted = defaultSetting.dataExportAfterCompleted; ;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activatingAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.setting.activatingAction = activatingAction.Text;
        }

        private void activatedAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.setting.activatedAction = activatedAction.Text;
        }

        private void timeSetter_ValueChanged(object sender, EventArgs e)
        {
            Program.setting.timeSetter = timeSetter.Value;
        }

        private void cleanAfterCompleted_Switch_CheckedChanged(object sender, EventArgs e)
        {
            Program.setting.cleanAfterCompleted = cleanAfterCompleted_Switch.Checked;
        }

        private void dataExportAfterCompleted_Switch_CheckedChanged(object sender, EventArgs e)
        {
            Program.setting.dataExportAfterCompleted = dataExportAfterCompleted_Switch.Checked;
        }
    }
}
