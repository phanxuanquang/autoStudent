using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.ViewModels;

namespace App.View
{
    public partial class ITSectorView : BaseSectorView
    {
        public ITSectorView(ITSectorViewModel model = null)
        {
            _model = model ?? new ITSectorViewModel();
            InitializeComponent();
        }
    }
}
