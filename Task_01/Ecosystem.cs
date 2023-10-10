using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem()
        {
            foreach (var organism in organisms)
            {
                if (organism is IPredator)
                {
                    var predators = organisms.OfType<IPredator>().ToList();
                    var prey = organisms.Where(o => o != organism && o.Age < 10).ToList();

                    if (predators.Count > 0 && prey.Count > 0)
                    {
                        var randomPredator = predators[new Random().Next(predators.Count)];
                        var randomPrey = prey[new Random().Next(prey.Count)];

                        ((IPredator)organism).Hunt(randomPrey);
                    }
                }

                if (organism.Age > 5 && organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }
            }
        }
    }
}
