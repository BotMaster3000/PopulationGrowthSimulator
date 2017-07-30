using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.CreatureActions
{
    public class BasicActions : Action
    {
        public void Sleep(int hours, int energyCost)
        {
            actionName = "sleep";
            actionTimeCost = hours;
            actionEnergyCost = energyCost;
        }
        public void Eat(int hours, int energyCost)
        {
            actionName = "eat";
            actionTimeCost = hours;
            actionEnergyCost = energyCost;
        }
        public void Die(Creatures.Creature creature)
        {
            actionName = "die";
            actionTimeCost = 0;
            creature.isAlive = false;
        }
        public void Reproduce(int hours, int energyCost)
        {
            actionName = "reproduce";
            actionTimeCost = hours;
            actionEnergyCost = energyCost;
        }
        public void GiveBirth(int hours, int energyCost)
        {
            actionName = "give birth";
            actionTimeCost = hours;
            actionEnergyCost = energyCost;
        }
    }
}
