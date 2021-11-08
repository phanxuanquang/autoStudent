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
    public class OptionalSectorViewModel : BaseSectorViewModel
    {
        public OptionalSectorViewModel()
        {
        }

        public OptionalSectorViewModel(IDataAccess context) : base(context) { }

        public override List<Software> ListSoftware()
        {
            return _repository.GetAllByTypeOfSoftware(TypeOfSoftware.Tech);
        }
    }
}
