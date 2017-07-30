using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.Creatures
{
    public class Creature
    {
        public string speciesName;
        public int age;
        public char gender;
        public bool isAlive = true;
        public int energy;
        public int maxEnergy;

        public Creature()
        {
        }
    }
}
