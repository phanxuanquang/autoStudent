using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Execution_Windows.GridView_Window
{
    public partial class OverlapForm : Form
    {
        List<Package> softwareList;
        List<Package> selectedSoftwareList = new List<Package>();

        public OverlapForm(List<Package> softList)
        {
            InitializeComponent();
            softwareList = softList;
            loadSoftwareToGridView(softList);
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
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (softwareList[i].Displayname == originalGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        selectedSoftwareList.Add(softwareList[i]);
                        finalGridView.Rows.Add(selectedSoftwareList[selectedSoftwareList.Count].Displayname);
                        softwareList.RemoveAt(i);
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
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (selectedSoftwareList[i].Displayname == finalGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        softwareList.Add(selectedSoftwareList[i]);
                        originalGridView.Rows.Add(softwareList[softwareList.Count].Displayname);
                        selectedSoftwareList.RemoveAt(i);
                        finalGridView.Rows.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
