using Microsoft.Win32;
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
    public partial class BaseForm : Form
    {
        protected List<Package> softwareList = new List<Package>();
        protected List<Package> selectedSoftwareList = new List<Package>();
        public BaseForm()
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

        protected void loadSoftwareToGridView(List<Package> softwareList)
        {
            softwareGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                softwareGridView.Rows.Add(softwareList[i].Displayname, softwareList[i].Version);
            }
        }
        protected void loadSoftwareToGridViewUninstall(List<SystemSoftware> softwareList)
        {
            softwareGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                softwareGridView.Rows.Add(softwareList[i].DisplayName, softwareList[i].Version);
            }
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < softwareGridView.RowCount; i++)
            {
                if (softwareGridView.Rows[i].Cells[1].Value != null && softwareGridView.Rows[i].Cells[1].Value.ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    softwareGridView.Rows[i].Visible = true;
                else softwareGridView.Rows[i].Visible = false;
            }
        }

        private void selectedSoftwareView_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView(selectedSoftwareList);
        }
        private void allSoftwareView_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView(softwareList);
        }

        private void softwareGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSoftwareList.Add(new Package()
            {
                Displayname = softwareGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Version = softwareGridView.Rows[e.RowIndex].Cells[1].Value.ToString()
            });
        } 

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (selectedSoftwareList.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "THOÁT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }

        private void unlectedSoftware_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
