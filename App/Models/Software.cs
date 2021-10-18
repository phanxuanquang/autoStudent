using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public enum TypeOfFileInstall
    {
        msi,
        exe,
        zip,
    }
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkDownload { get; set; }

        public List<InstallControlHander> InstallControlHanders { get; set; }

        public TypeOfFileInstall Type {get; set;}

    }
}
