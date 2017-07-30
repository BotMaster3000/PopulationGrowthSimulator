using PopulationGrowthSimulator.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            World.World world = new World.World(200, 200);
            world.InitializeCreatures();
            foreach(Human human in world.humans)
            {
                Console.WriteLine(human.name + ", " + human.gender + ", " + human.energy + ", " +  human.maxEnergy);
            }
        }
    }
}
