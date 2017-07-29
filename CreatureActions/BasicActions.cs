using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.CreatureActions
{
    public class BasicActions : Action
    {
        public void Sleep(int hours)
        {
            actionName = "sleep";
            actionTimeCost = hours;
        }
        public void Eat(int hours)
        {
            actionName = "eat";
            actionTimeCost = hours;
        }
    }
}
