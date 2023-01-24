using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWareApp
{
    /// <summary>
    /// Класс, для получения списка запущенных процессов
    /// </summary>
    public class Dispatcher
    {
        public string GetApp()
        {
            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();

            string text = string.Empty;

            foreach (System.Diagnostics.Process process in processList)
            {
                try
                {
                    if (!process.MainModule.FileName.Contains("Windows"))
                    {
                        text += process.ProcessName + "\n";
                    }
                }
                catch
                {

                }
            }

            return text;
        }

    }

}
