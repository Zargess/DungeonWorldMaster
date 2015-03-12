using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Quest : IQuest {
        public string Background { get; set; }
        public string Name { get; private set; }
        public ICollection<string> Notes { get; private set; }

        public Quest(string name, string background, ICollection<string> notes) {
            Name = name;
            Background = background;
            Notes = notes;
        }
    }
}
