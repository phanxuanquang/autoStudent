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
    public partial class DesignSectorView : BaseSectorView
    {
        public DesignSectorView(DesignSectorViewModel model = null)
        {
            _model = model ?? new DesignSectorViewModel();
            InitializeComponent();
            //this.Load += delegate { ShowList(); };
        }

    }
}
