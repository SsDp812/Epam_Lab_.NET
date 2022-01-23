using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public class Character : ElementOfMap
    {
        public int wallet;
        public double health;
       
            /*
        {
            get
            {
                return health;
            }
            set
            {
                if(value < 0)
                {
                    health = 0;
                }
                else if(value > 100)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
                
            }
            */
        
        public Character()
        {
            health = 100;
            wallet = 0;
            icon = "+";
        }

        public void getBuff(Food buff)
        {
            this.health += buff.bonusHealth;
            if (health > 100)
            {
                health = 100;
            }
        }
        public string checkWinOrLoose()
        {
            if (this.wallet == 3)
            {
                return "win";
            }
            else if(this.health <= 0)
            {
                return "loose";
            }
            else
            {
                return "pass";
            }
        }
        public void getCoin()
        {
            this.wallet += 1;
        }
    }

    
}
