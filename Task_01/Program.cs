using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();

            Animal lion = new Animal(80, 7, 1.5, "Lion");
            Animal wolf = new Animal(70, 5, 1.2, "Wolf");
            Plant tree = new Plant(40, 10, 5, "Tree");
            Microorganism bacteria = new Microorganism(10, 1, 0.01, "Bacteria");

            ecosystem.AddOrganism(lion);
            ecosystem.AddOrganism(wolf);
            ecosystem.AddOrganism(tree);
            ecosystem.AddOrganism(bacteria);

            for (int i = 0; i < 10; i++)
            {
                ecosystem.SimulateEcosystem();
                Console.WriteLine();
            }
        }
    }
}