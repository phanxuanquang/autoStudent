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
    public partial class OverlapForm : Form
    {
        List<Package> overlapList;
        List<Package> softwareList;
        List<Package> selectedSoftwareList = new List<Package>();
        public bool isExitByButton = true;

        public OverlapForm(List<Package> overlapList, List<Package> softwareList)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.Icon = Properties.Resources.mainIcon;
            this.overlapList = overlapList;
            this.softwareList = softwareList;
            loadSoftwareToGridView(overlapList);
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

        protected void loadSoftwareToGridView(List<Package> softwareList)
        {
            originalGridView.Rows.Clear();
            for (int i = 0; i < softwareList.Count; i++)
            {
                originalGridView.Rows.Add(softwareList[i].Displayname);
            }
        }

        private void originalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < overlapList.Count; i++)
                {
                    if (overlapList[i].Displayname == originalGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        selectedSoftwareList.Add(overlapList[i]);
                        finalGridView.Rows.Add(selectedSoftwareList[selectedSoftwareList.Count - 1].Displayname);
                        overlapList.RemoveAt(i);
                        originalGridView.Rows.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        private void finalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < selectedSoftwareList.Count; i++)
                {
                    if (selectedSoftwareList[i].Displayname == finalGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        overlapList.Add(selectedSoftwareList[i]);
                        originalGridView.Rows.Add(overlapList[overlapList.Count - 1].Displayname);
                        selectedSoftwareList.RemoveAt(i);
                        finalGridView.Rows.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            isExitByButton = false;
            if (overlapList.Count > 0)
            {
                ProgressWindow_Uninstall progressWindow_Uninstall = new ProgressWindow_Uninstall(overlapList, this);
                progressWindow_Uninstall.isOverlap = true;
                progressWindow_Uninstall.Show();
            }
        }

        public List<Package> DeleteSoftware()
        {
            if (finalGridView.Rows.Count > 0)
            {
                for (int j = 0; j < finalGridView.Rows.Count; j++)
                {
                    for (int i = 0; i < softwareList.Count; i++)
                    {
                        if (softwareList[i].Displayname == finalGridView.Rows[j].Cells[0].Value.ToString())
                        {
                            softwareList.RemoveAt(i);
                            i--;
                        }
                    }
                }    
            }
            return softwareList;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            isExitByButton = true;
            this.Close();
        }
    }
}
