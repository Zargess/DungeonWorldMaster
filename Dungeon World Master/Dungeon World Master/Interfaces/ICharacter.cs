using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interfaces {
    public interface ICharacter {
        string Name { get; set; }
        IStat[] Stats { get; }
        int Level { get; set; }
        string Race { get; set; }
        string Class { get; }
        string Alignment { get; set; }
        List<string> Notes { get; }
    }
}
