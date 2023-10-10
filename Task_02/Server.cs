using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Server : Computer
    {
        public int StorageCapacity { get; }

        public Server(string ipAddress, int power, string os, int storageCapacity)
            : base(ipAddress, power, os)
        {
            StorageCapacity = storageCapacity;
        }
    }
}
