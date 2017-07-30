using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.Creatures
{
    public class Deer : Creature
    {
        public Deer(int deerAge, char deerGender, int deerEnergy, int deerMaxEnergy)
        {
            speciesName = "deer";
            age = deerAge;
            gender = deerGender;
            energy = deerEnergy;
            maxEnergy = deerMaxEnergy;
        }
        
    }
}
