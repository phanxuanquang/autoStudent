using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;
using App.DataServices;
using App.Models;

namespace App.ViewModels
{
    public class BaseSectorViewModel
    {
        protected ISoftwareRepository _repository;

        public BaseSectorViewModel() { }

        public BaseSectorViewModel(IDataAccess context)
        {
            _repository = new SoftwareReponsitory(context);
        }

        public virtual List<Software> ListSoftware()
        {
            return _repository.GetAll();
        }

        public void InstallAll()
        {

        }
    }
}
