using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.Creatures
{
    public class Deer : Creature
    {
        public Deer(int deerAge, char deerGender)
        {
            speciesName = "deer";
            age = deerAge;
            gender = deerGender;
        }
    }
}
