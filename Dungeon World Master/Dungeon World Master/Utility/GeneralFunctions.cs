using Dungeon_World_Master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Utility {
    public class GeneralFunctions {
        public static Stat[] GenerateStats() {
            return new Stat[] {
                new Stat("Strength", 0),
                new Stat("Dexterity", 0),
                new Stat("Constitution", 0),
                new Stat("Intelligense", 0),
                new Stat("Wisdom", 0),
                new Stat("Charisma", 0)
            };
        }
    }
}
