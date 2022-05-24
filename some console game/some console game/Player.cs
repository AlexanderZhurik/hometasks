using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace some_console_game
{
    class Player : Entity
    {
        public bool isDead = false;
        public Inventory inventory = new Inventory();
        public Player()
        {
            health = 20;
            maxHealth = 20;
            baseDamage = 1;
            name = "Игрок";
            goldAmount = 10; 
        }
        public int goldAmount { get; set; }
      

    }
}
