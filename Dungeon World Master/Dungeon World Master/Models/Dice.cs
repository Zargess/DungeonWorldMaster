using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Dice : IDice {
        public int Sides { get; private set; }

        public Dice(int sides) {
            Sides = sides;
        }
    }
}
