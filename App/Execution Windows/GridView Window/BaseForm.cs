using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace App
{
    public partial class BaseExecutionForm : Form
    {
        protected List<Package> softwareList = new List<Package>();
        protected List<Package> selectedSoftwareList = new List<Package>();
        public BaseExecutionForm()
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
        protected void loadSoftwareToGridView_Role(List<Package> softwareList, Role role)
        {
            softwareGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                if (softwareList[i].Role == role)
                    softwareGridView.Rows.Add(softwareList[i].Displayname, softwareList[i].Version);
            }
        }
        protected virtual void exec() { }

        private void selectedSoftwareView_Button_Click(object sender, EventArgs e)
        {
            selectedSoftwareView_Button.Tag = "clicked";
            loadSoftwareToGridView(selectedSoftwareList);
        }
        private void allSoftwareView_Button_Click(object sender, EventArgs e)
        {
            selectedSoftwareView_Button.Tag = "unclicked";
            loadSoftwareToGridView(softwareList);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < softwareGridView.RowCount; i++)
            {
                if (softwareGridView.Rows[i].Cells[0].Value != null && softwareGridView.Rows[i].Cells[0].Value.ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    softwareGridView.Rows[i].Visible = true;
                else softwareGridView.Rows[i].Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (selectedSoftwareList.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "THOÁT", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width != 300)
                menuPanel.Width = 300;
            else menuPanel.Width = 78;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (selectedSoftwareList.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn tiếp tục?", "TIẾP TỤC", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    softwareList = selectedSoftwareList;
                    this.Hide();
                    exec();
                }
            }
            else MessageBox.Show("Bạn chưa chọn phần mềm nào");
        }

        private void IT_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView_Role(softwareList, Role.It);
        }
        private void Tech_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView_Role(softwareList, Role.Tech);
        }
        private void Graphic_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView_Role(softwareList, Role.Graphic);
        }
        private void None_Button_Click(object sender, EventArgs e)
        {
            loadSoftwareToGridView_Role(softwareList, Role.None);
        }

        private void softwareGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedSoftwareView_Button.Tag.ToString() == "unclicked" && e.RowIndex >= 0)
            {
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (softwareList[i].Displayname == softwareGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        selectedSoftwareList.Add(softwareList[i]);
                        softwareList.RemoveAt(i);
                        loadSoftwareToGridView(softwareList);
                        return;
                    }
                }
            }
            else if (selectedSoftwareView_Button.Tag.ToString() == "clicked" && e.RowIndex >= 0)
            {
                {
                    for (int i = 0; i < selectedSoftwareList.Count; i++)
                    {
                        if (selectedSoftwareList[i].Displayname == softwareGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                        {
                            softwareList.Add(selectedSoftwareList[i]);
                            selectedSoftwareList.RemoveAt(i);
                            softwareGridView.Rows.Remove(softwareGridView.Rows[e.RowIndex]);
                            loadSoftwareToGridView(selectedSoftwareList);
                            return;
                        }
                    }
                }
            }
        }
    }
}
