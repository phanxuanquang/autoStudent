using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App.Models
{
    public class InstallControlHander
    {
        private string _keyPress;
        public string keyPress
        {
            get
            {
                return _keyPress;
            }
        }
        private int _threadSleep;
        public int threadSleep
        {
            get
            {
                return _threadSleep;
            }
        }
        public InstallControlHander(string keyPress, string threadSleep)
        {
            if (String.IsNullOrEmpty(threadSleep) || !int.TryParse(threadSleep, out _threadSleep))
            {
                _threadSleep = 100;
            }
            if (!String.IsNullOrEmpty(keyPress))
            {
                _keyPress = keyPress;
            }
        }
    }
}
