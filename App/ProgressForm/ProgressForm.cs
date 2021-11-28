using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.ProgressForm
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            AddProgress(null);
        }

        private void AddProgress(List<Package> listSoftware)
        {
            for(int index = 0; index < 50; index++)
            {
                new Components(this.flowLayoutPanel1);
            }
        }
    }
}
