﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthSimulator.CreatureActions
{
    public class HumanActions : Action
    {
        public void Hunt(int hours, int energyCost)
        {
            actionName = "hunt";
            actionTimeCost = hours;
            actionEnergyCost = energyCost;
        }
    }
}
