using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;
using App.Models;

namespace App.ViewModels
{
    public class DesignSectorViewModel : BaseSectorViewModel
    {
        public DesignSectorViewModel()
        {
        }

        public DesignSectorViewModel(IDataAccess context) : base(context) { }

        public override List<Software> ListSoftware()
        {
            return _repository.GetAllByTypeOfSoftware(TypeOfSoftware.Design);
        }
    }
}
