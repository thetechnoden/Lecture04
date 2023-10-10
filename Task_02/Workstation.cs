using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Workstation : Computer
    {
        public string WorkstationType { get; }

        public Workstation(string ipAddress, int power, string os, string workstationType)
            : base(ipAddress, power, os)
        {
            WorkstationType = workstationType;
        }
    }
}
