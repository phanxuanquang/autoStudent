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
        private string _controlClass;
        private string _controlText;
        private int _controlId;
        private Point _mousePosition;
        private int _threadSleep;
        public string controlClass
        {
            get
            {
                return _controlClass;
            }
        }
        public string controlText
        {
            get
            {
                return _controlText;
            }
        }
        public int controlId
        {
            get
            {
                return _controlId;
            }
        }
        public Point mousePosition
        {
            get
            {
                return _mousePosition;
            }
        }
        public int threadSleep
        {
            get
            {
                return _threadSleep;
            }
        }
        public InstallControlHander(string controlClass, string controlText, string controlId, string mousePosition, string threadSleep)
        {
            _controlClass = controlClass;
            _controlText = controlText;
            if (String.IsNullOrEmpty(controlId) || !int.TryParse(controlId, out _controlId))
            {
                _controlId = -1;
            }
            if (String.IsNullOrEmpty(threadSleep) || !int.TryParse(threadSleep, out _threadSleep))
            {
                _threadSleep = 100;
            }

            if (!String.IsNullOrEmpty(mousePosition))
            {
                string[] temp = mousePosition.Split(',');
                _mousePosition.X = int.Parse(temp[0]);
                _mousePosition.Y = int.Parse(temp[1]);
            }
        }
    }
}
