using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace some_console_game
{
    abstract class Entity
    {
        public int health { get; set; }
        public int maxHealth
        {
            get
            {
                return baseDamage;
            }
            set
            {
                if (value > 0) baseDamage = value;

                else
                {
                    throw new Exception("Здоровье не может быть неположительным!");
                }
            }
        }
        public string name { get; set; }

        public int baseDamage { get; set; }

        public Random Randomizer = new Random();
       }
}
