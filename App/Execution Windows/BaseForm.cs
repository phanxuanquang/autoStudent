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
        protected List<Software> softwareList = new List<Software>();
        protected List<Software> selectedSoftwareList = new List<Software>();
        List<string> keys = new List<string>() {
             @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
             @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };
        public BaseForm()
        {
            InitializeComponent();
            findInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, softwareList);
            findInstalledSofware(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32), keys, softwareList);
            softwareList = softwareList.Where(s => !string.IsNullOrWhiteSpace(s.name)).Distinct().ToList();
            // The list of ALL installed applications
            loadSoftwareToGridView(softwareList);
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

        protected void loadSoftwareToGridView(List<Software> softwareList)
        {
            for (int i = 0; i < softwareList.Count; i++)
            {
                softwareGridView.Rows.Add(softwareList[i].name, softwareList[i].version);
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
            for (int i = 0; i < softwareGridView.Rows.Count; i++)
            {
                if (!softwareGridView.Rows[i].Selected)
                    softwareGridView.Rows[i].Visible = false;
            }
        }
        private void allSoftwareView_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < softwareGridView.Rows.Count; i++)
            {
                softwareGridView.Rows[i].Visible = true;
            }
        }
        private void softwareGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (softwareGridView.CurrentCell.Selected == true)
            {
                softwareGridView.CurrentCell.Selected = false;
                for (int i = 0; i < softwareList.Count; i++)
                {
                    if (softwareGridView.CurrentCell.Value.ToString() == softwareList[i].name || softwareGridView.CurrentCell.Value.ToString() == softwareList[i].version)
                        softwareList.RemoveAt(i);
                }
            }
            else
            {
                selectedSoftwareList.Add(new Software(softwareGridView.CurrentCell.Value.ToString()));
            }
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
        private void findInstalledSofware(RegistryKey regKey, List<string> keys, List<Software> installed)
        {
            foreach (string key in keys)
            {
                try
                {
                    using (RegistryKey rk = regKey.OpenSubKey(key))
                    {
                        if (rk == null)
                        {
                            continue;
                        }
                        foreach (string skName in rk.GetSubKeyNames())
                        {
                            using (RegistryKey sk = rk.OpenSubKey(skName))
                            {
                                try
                                {
                                    installed.Add(new Software()
                                    {
                                        name = Convert.ToString(sk.GetValue("DisplayName")),
                                        version = Convert.ToString(sk.GetValue("DisplayVersion"))
                                    });
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                }
                catch (Exception ex2)
                {

                }
            }
        }
    }
}
