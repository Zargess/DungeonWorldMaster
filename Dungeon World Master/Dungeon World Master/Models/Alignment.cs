using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Alignment {
        public string Goal { get; private set; }
        public string Name { get; private set; }

        public Alignment(string name, string goal) {
            Name = name;
            Goal = goal;
        }
    }
}
