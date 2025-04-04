using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;

        public string Name {get; }


        public Player(string name)
        {
            Name = name;
            xp = 0;
            health = MaxHealth;
        }

        public int XP 
        {
            set
            {
                xp ++;
            }
            get
            {
                return xp;
            }
        }

        public int Level 
        {
            get
            {
                return 1 + xp / 1000;
            }

        }

        public float Health
        {
            set
            {
                if (health < 0)
                {
                    health = 0;
                }
                else if (health > MaxHealth)
                {
                    health = MaxHealth;
                }
            }

            get
            {
                return health;
            }
        }

        public float MaxHealth
        {
            get
            {
                return 100 + (Level - 1) * 20;
            }
        }

        public void TakeDamage(float damage)
        {
            if (damage > 0)
            {
                health --;
            }

            xp += xp + (int) damage /20;
        }
        
    }
}