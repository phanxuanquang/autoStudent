using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;


namespace App.ViewModels
{
    public class DesignSectorViewModel : BaseSectorViewModel
    {
        public DesignSectorViewModel()
        {
        }

        public DesignSectorViewModel(IDataAccess context) : base(context) { }
    }
}
