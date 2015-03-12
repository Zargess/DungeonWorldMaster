using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interfaces {
    public interface IStat {
        string Name { get; }
        int Value { get; set; }
        int Modifier { get; }
    }
}
