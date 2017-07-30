﻿using System;
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
        public List<Human> humans = new List<Human>();
        public List<Deer> deers = new List<Deer>();
        
        public World(int numberOfHumans, int numberOfDeers)
        {
            humansToInitialize = numberOfHumans;
            deersToInitialize = numberOfDeers;
        }
        public void InitializeCreatures()
        {
            for(int i = 0; i < humansToInitialize; ++i)
            {
                if(i <= humansToInitialize / 2)
                {
                    humans.Add(new Human(20, 'w', "human" + i));
                }
                else
                {
                    humans.Add(new Human(20, 'm', "human" + i));
                }
            }
            for(int i = 0; i < deersToInitialize; ++i)
            {
                if(i <= deersToInitialize / 2)
                {
                    deers.Add(new Deer(10, 'w'));
                }
                else
                {
                    deers.Add(new Deer(10, 'm'));
                }
            }
        }
        public void NextDay()
        {

        }
        public void NextHour()
        {

        }
    }
}
