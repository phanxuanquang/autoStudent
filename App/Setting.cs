using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Setting
    {
        public DateTime timeSetter;
        public string activatingAction;
        public string activatedAction;
        public bool cleanAfterCompleted;
        public bool excelExportAfterCompleted;

        public Setting()
        {
            timeSetter = DateTime.Now;
            activatingAction = "Không làm gì";
            activatedAction = "Không làm gì";
            cleanAfterCompleted = false;
            excelExportAfterCompleted = false;
        }

        void exec_activatingAction()
        {

        }

        void exec_activatedAction()
        {

        }

        void exec_cleanAfterCompleted()
        {

        }

        void exec_excelExportAfterCompleted()
        {

        }
    }
    
}
