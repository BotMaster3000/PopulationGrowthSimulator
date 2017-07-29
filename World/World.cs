using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PopulationGrowthSimulator.Creatures;

namespace PopulationGrowthSimulator.World
{
    public class World
    {
        int hour;        
        public int Hour
        {
            get
            {
                return Hour;
            }
            set
            {
                hour = value;
                if(hour > 24)
                {
                    hour = hour - 24;
                }
            }
        }
        int day = 0;
        int humansToInitialize;
        int deersToInitialize;
        
        public World()
        {
            
        }
        public void InitializeCreatures()
        {

        }
        public void NextDay()
        {

        }
        public void NextHour()
        {

        }
    }
}
