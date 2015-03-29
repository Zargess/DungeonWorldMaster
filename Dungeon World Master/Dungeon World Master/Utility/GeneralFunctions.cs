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
                new Stat("Strength", 8),
                new Stat("Dexterity", 9),
                new Stat("Constitution", 12),
                new Stat("Intelligense", 13),
                new Stat("Wisdom", 15),
                new Stat("Charisma", 16)
            };
        }
    }
}
