using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Computer : IConnectable
    {
        public string IPAddress { get; }
        public int Power { get; }
        public string OperatingSystem { get; }

        public Computer(string ipAddress, int power, string os)
        {
            IPAddress = ipAddress;
            Power = power;
            OperatingSystem = os;
        }

        public void Connect(IConnectable device)
        {
            Console.WriteLine($"{this.GetType().Name} with IP-Address {IPAddress} connected to {device.GetType().Name}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"{this.GetType().Name} with IP-Address {IPAddress} disconnected");
        }

        public void SendData(string data)
        {
            Console.WriteLine($"{this.GetType().Name} with IP-Address {IPAddress} sent data: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"{this.GetType().Name} with IP-Address {IPAddress} recieve data: {data}");
        }
    }

}
