using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;
using App.Models;

namespace App.DataServices
{
    class SoftwareReponsitory : ISoftwareRepository
    {
        protected readonly IDataAccess _context;
        public SoftwareReponsitory(IDataAccess context)
        {
            _context = context;
            _context.Load();
        }

        public List<Software> GetAll()
        {
            return new List<Software>
            {
                new Software {Id = 1, Name = "K"},
                new Software {Id = 2, Name = "T"},
                new Software {Id = 2, Name = "H"},
                new Software {Id = 2, Name = "U"},
            };
        }

    }
}
