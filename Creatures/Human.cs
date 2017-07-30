using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.Creatures
{
    public class Human : Creature
    {
        public string name;
        public string surName;

        public Human(int humanAge, char humanGender, string humanName = "", string humanSurName = "")
        {
            speciesName = "human";
            age = humanAge;
            gender = humanGender;
            name = humanName;
            surName = humanSurName;
        }
    }
}
