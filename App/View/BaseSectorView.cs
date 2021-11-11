using App.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;

namespace App.View
{
    public partial class BaseSectorView : BaseView
    {
        protected BaseSectorViewModel _model;
        protected List<Software> softwares;
        public BaseSectorView()
        {
            InitializeComponent();
            this.Load += delegate { ShowList(); };
        }
        public void ShowList()
        {
            if (_model != null)
            {
                softwares = _model.ListSoftware();
                for (int index = 0; index < softwares.Count; index++)
                {
                    softList.Items.Add(softwares[index].Name);
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cài đặt những phần mềm này?", "XÁC NHẬN CÀI ĐẶT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.mainForm.Hide();
                List<Software> selectedInstall = new List<Software>();
                
                CheckedListBox.CheckedIndexCollection selected = softList.CheckedIndices;
                for (int index = 0; index < selected.Count; index++)
                {
                    selectedInstall.Add(softwares[selected[index]]);
                }
                InstallWindow installProgressWindow = new InstallWindow(selectedInstall);
                installProgressWindow.InstallAll();
                //installProgressWindow.ShowDialog();
                Program.mainForm.Show();
            }
        }
    }
}
