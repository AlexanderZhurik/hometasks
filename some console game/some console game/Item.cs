using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace some_console_game
{
    class Item
    {
        
        public string name;
        public int cost;
        public enum type { Armor, Weapon, Food, Other };
        public type ItemType;
        public Item(string n, int c, type t) { name = n; cost = c; ItemType = t; }
        public int activeValue;
        public Item(string n, int c, type t, int av) { name = n; cost = c; ItemType = t; activeValue = av; }
    }
}
