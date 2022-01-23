using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public abstract  class Enemy : ElementOfMap
    {
        public double force;
        public void attack(Character ch)
        {
            ch.health -= force;
        }
        
    }
}
