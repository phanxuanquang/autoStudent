using Microsoft.WindowsAPICodePack.Dialogs;
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
        Setting newSetting = new Setting();
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

        private void SettingForm_Load(object sender, EventArgs e)
        {
            timeSetter.Value = Program.setting.timeSetter;
            timeSetter.Checked = Program.setting.isSetTime;
            activatedAction.SelectedIndex = ((int)Program.setting.afterAction);
            cleanAfterCompleted_Switch.Checked = Program.setting.cleanAfter;
            saveDownload.Text = Program.setting.saveDownloadPath;
            exportPath.Visible = exportPath_Button.Visible = dataExportAfterCompleted_Switch.Checked = Program.setting.dataExport;
            exportPath.Text = Program.setting.exportPath;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (Program.setting == newSetting)
                this.Close();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Các thiết lập chưa được lưu, bạn có chắc chắn muốn thoát?", "THOÁT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void timeSetter_ValueChanged(object sender, EventArgs e)
        {
            newSetting.timeSetter = timeSetter.Value;
        }
        private void activatedAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSetting.afterAction = ((Setting.AfterAction)activatedAction.SelectedIndex);
        }
        private void cleanAfterCompleted_Switch_CheckedChanged(object sender, EventArgs e)
        {
            newSetting.cleanAfter = cleanAfterCompleted_Switch.Checked;
        }
        
        private void dataExportAfterCompleted_Switch_CheckedChanged(object sender, EventArgs e)
        {
            newSetting.dataExport = dataExportAfterCompleted_Switch.Checked;
            exportPath.Visible = exportPath_Button.Visible = dataExportAfterCompleted_Switch.Checked;
        }
        private void exportPath_TextChanged(object sender, EventArgs e)
        {
            newSetting.exportPath = exportPath.Text;
        }
        private void exportPath_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath.Text = saveFileDialog.FileName;
            }
        }
        
        private void saveDownload_TextChanged(object sender, EventArgs e)
        {
            newSetting.saveDownloadPath = saveDownload.Text;
        }
        private void saveDownload_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog destinationPathdlg = new CommonOpenFileDialog();
            destinationPathdlg.IsFolderPicker = true;
            if (destinationPathdlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                saveDownload.Text = destinationPathdlg.FileName;
            }
        }

        private void defaultSetting_Button_Click(object sender, EventArgs e)
        {
            timeSetter.Value = Program.setting.timeSetter;
            timeSetter.Checked = false;
            activatedAction.SelectedIndex = 0;
            cleanAfterCompleted_Switch.Checked = false;
            dataExportAfterCompleted_Switch.Checked = false;
            saveDownload.Text = @"C:\";
        }
        private void settingSaved_Button_Click(object sender, EventArgs e)
        {
            Program.setting = newSetting;
            this.Close();
        }
    }
}

