using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWareApp
{
    /// <summary>
    /// Класс, для получения сведений об операционной системе
    /// </summary>
    public class PcManager
    {
        public string GetEnviroment()
        {
          var text = $"Версия Windows: {Environment.OSVersion}\n, " +
                    $"64 Bit операционная система? : {Environment.Is64BitOperatingSystem}\n, " +
                    $"Имя компьютера: {Environment.MachineName}\n, " +
                    $"Число процессоров: {Environment.ProcessorCount}\n, " +
                    $"Системная папка : {Environment.SystemDirectory}\n, " +
                    $"Логические диски : {Environment.GetLogicalDrives()}\n";

            return text;
        }
    }
}
