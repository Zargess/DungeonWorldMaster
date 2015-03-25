using Dungeon_World_Master.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interface {
    public interface ISteading {
        string Type { get; }
        string Name { get; }
        Wealth Wealth { get; set; }
        Population Population { get; set; }
        Defenses Defense { get; set; }
        string Problem { get; set; }
        ObservableCollection<string> Tags { get; }
        List<string> Options { get; }
        List<string> Problems { get; }
    }
}
