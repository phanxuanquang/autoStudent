using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.InstallUninstall
{
    class Uninstall : BaseProcess
    {
        protected override void isCompletedItem()
        {
            if (isContinue && listSoftware != null)
            {
                index++;
                MessageBox.Show(index.ToString());
                if (listSoftware.Count > index)
                {
                    if (CreateProcess(GetPath.CommandUninstall(listSoftware[index])))
                    {
                        Task.Factory.StartNew(() =>
                        {
                            while (!tracking.isCompleted)
                            {
                                Thread.Sleep(250);
                            }
                            isCompletedItem();
                        });
                    }
                    else
                    {
                        isCompletedItem();
                    }
                }
            }
        }
    }
}
