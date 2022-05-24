using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace some_console_game
{
    class Inventory
    {
        public List<Item> items = new List<Item>();
        public Item[] equipment = new Item[2];
        public int carryWeigtht { get; set; }
        
    }
}
