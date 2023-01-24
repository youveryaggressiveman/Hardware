using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HardWareApp
{
    /// <summary>
    /// Класс, который позволяет получить локальные IP для работы с сетью
    /// </summary>
    public class LocalIp
    {
        public string GetLocalIp()
        {
            var macAddresses = NetworkInterface.GetAllNetworkInterfaces()
                                              .Where(x => x.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                                                       && x.OperationalStatus == OperationalStatus.Up)
                                                           .ToList();

            var text = string.Empty;

            foreach (var item in macAddresses)
            {
                foreach (var item2 in item.GetIPProperties().UnicastAddresses.ToList())
                {
                    text += $"{item.Name}: {item2.Address} \n";
                }
            }

            return text;
        }
    }
}
