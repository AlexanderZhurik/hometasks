using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace some_console_game
{
    internal class Monster : Entity
    {
        public Monster(string n, int h, int d) 
        {
            name = n;
            health = h;
            baseDamage = d;
        }
    }
}
