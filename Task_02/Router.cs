using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Router : Computer
    {
        public int Ports { get; }

        public Router(string ipAddress, int power, string os, int ports)
            : base(ipAddress, power, os)
        {
            Ports = ports;
        }
    }
}
