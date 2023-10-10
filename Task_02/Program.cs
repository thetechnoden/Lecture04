using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("192.168.0.1", 1000, "Windows Server", 10000);
            Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 11", "Manager");
            Router router = new Router("192.168.1.3", 200, "Xiaomi", 4);

            Network network = new Network();
            network.AddDevice(server);
            network.AddDevice(workstation);
            network.AddDevice(router);

            network.ConnectDevices();
            network.DisconnectDevices();

            server.SendData("Hello, workstation!");
            workstation.ReceiveData("Hi, server!");
        }
    }
}