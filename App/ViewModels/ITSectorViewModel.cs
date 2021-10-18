using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;

namespace App.ViewModels
{
    public class ITSectorViewModel : BaseSectorViewModel
    {
        public ITSectorViewModel()
        {
        }

        public ITSectorViewModel(IDataAccess context) : base(context) { }
    }
}
