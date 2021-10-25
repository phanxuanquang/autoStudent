using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;

namespace App.Interface
{
    public interface ISoftwareRepository
    {
        List<Software> GetAll();
        List<Software> GetAllByTypeOfSoftware(TypeOfSoftware type);
    }
}
