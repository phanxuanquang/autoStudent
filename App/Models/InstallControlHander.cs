using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class InstallControlHander
    {
        public int Id { get; set; }

        public string ControlClass { get; set; }
        public string ControlText { get; set; }

        public int? ControlId { get; set; }

        Tuple<int, int> MouPosition { get; set; }

        public int ThreadSleep { get; set; }

    }
}
