using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Quest {
        public string Background { get; set; }
        public string Name { get; private set; }
        public ObservableCollection<string> Notes { get; private set; }

        public Quest(string name, string background, IEnumerable<string> notes) {
            Name = name;
            Background = background;
            Notes = new ObservableCollection<string>();
            foreach (var item in notes) {
                Notes.Add(item);
            }
        }
    }
}
