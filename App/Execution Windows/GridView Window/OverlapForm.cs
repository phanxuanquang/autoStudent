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
    public partial class OverlapForm : BaseExecutionForm
    {
        public OverlapForm()
        {
            InitializeComponent();
            base.menuPanel.Visible = false;
        }
    }
}
