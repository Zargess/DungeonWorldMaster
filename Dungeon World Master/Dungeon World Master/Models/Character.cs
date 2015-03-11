using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Character : ICharacter {
        public IAlignment Alignment { get; set; }
        public string Class { get; private set; }
        public int Level { get; set; }
        public List<string> Missions { get; private set; }
        public string Name { get; set; }
        public List<string> Notes { get; private set; }
        public string PlayerName { get; set; }
        public string Race { get; private set; }
        public IStat[] Stats { get; private set; }
    }
}
