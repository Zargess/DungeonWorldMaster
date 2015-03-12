using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interfaces {
    public interface IQuest {
        string Name { get; }
        string Background { get; set; }
        ICollection<string> Notes { get; }
    }
}
