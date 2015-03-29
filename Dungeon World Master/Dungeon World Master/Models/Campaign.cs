using Dungeon_World_Master.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Campaign {
        public ObservableCollection<Character> Characters { get; private set; }
        public ObservableCollection<ISteading> Cities { get; private set; }

        public string Name { get; set; }

        public Campaign() {
        }
    }
}
