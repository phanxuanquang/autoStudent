using App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DataServices;

namespace App.ViewModels
{
    public class TechnologySectorViewModel : BaseSectorViewModel
    {
        public TechnologySectorViewModel()
        {
        }

        public TechnologySectorViewModel(IDataAccess context) : base(context) { }
    }
}
