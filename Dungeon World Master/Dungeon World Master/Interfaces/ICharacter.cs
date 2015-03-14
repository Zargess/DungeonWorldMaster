using System.Collections.Generic;

namespace Dungeon_World_Master.Interfaces {
    public interface ICharacter {
        IAlignment Alignment { get; set; }
        string Class { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        ICollection<IQuest> Quests { get; set; }
        string Race { get; set; }
        IStat[] Stats { get; set; }

        bool LevelUp(string statname);
    }
}