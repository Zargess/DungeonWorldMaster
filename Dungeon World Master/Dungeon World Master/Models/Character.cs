using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Character : ICharacter {
        public IAlignment Alignment { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public ICollection<IQuest> Quests { get; set; }
        public string Race { get; set; }
        public IStat[] Stats { get; set; }

        public Character() {
            // TODO : Make default character
        }

        public Character(string path) {
            // TODO : Load Character from xml file or the like
        }

        // TODO : Consider removing this
        public Character(IAlignment alignment, string Class, int level, string name, ICollection<IQuest> quests, string race, IStat[] stats) {
            alignment = Alignment;
            this.Class = Class;
            Level = level;
            Name = name;
            Quests = quests;
            Race = race;
            Stats = stats;
        }

        public bool LevelUp(string statname) {
            return true;
        }

        public override string ToString() {
            return Name + " " + Level;
        }
    }
}
