using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Microorganism : LivingOrganism, IReproducible
    {
        public string Genus { get; set; }

        public Microorganism(double energy, int age, double size, string genus)
            : base(energy, age, size)
        {
            Genus = genus;
        }

        public void Reproduce()
        {
            Console.WriteLine($"Microorganism genus {Genus} multiyplying.");
        }
    }
}
