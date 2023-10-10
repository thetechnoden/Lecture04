using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Animal : LivingOrganism, IReproducible, IPredator
    {
        public string Species { get; set; }

        public Animal(double energy, int age, double size, string species)
            : base(energy, age, size)
        {
            Species = species;
        }

        public void Reproduce()
        {
            Console.WriteLine($"Animal species {Species} is multiyplying.");
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine($"Animal species {Species} preys on the body.");
            if (Energy < 100)
            {
                Energy += prey.Size * 2;
                Console.WriteLine($"Animal species {Species} gains energy.");
            }
        }
    }
}
