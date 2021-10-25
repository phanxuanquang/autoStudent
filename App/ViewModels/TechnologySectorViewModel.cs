using App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DataServices;
using App.Models;

namespace App.ViewModels
{
    public class TechnologySectorViewModel : BaseSectorViewModel
    {
        public TechnologySectorViewModel()
        {
        }

        public TechnologySectorViewModel(IDataAccess context) : base(context) { }

        public override List<Software> ListSoftware()
        {
            return _repository.GetAllByTypeOfSoftware(TypeOfSoftware.Tech);
        }
    }
}
