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
        public BaseSectorView()
        {
            InitializeComponent();
        }
        public void ShowList()
        {
            List<Software> softwares = _model.ListSoftware();
            foreach (var software in softwares)
            {
                
            }
        }
    }
}
