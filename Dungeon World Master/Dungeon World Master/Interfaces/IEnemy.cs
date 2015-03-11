using System.Collections.ObjectModel;

namespace Dungeon_World_Master.Interfaces {
    public interface IEnemy {
        string Name { get; set; }
        string Describtion { get; set; }
        ObservableCollection<ITag> Tags { get; }
        IDice Dice { get; set; }
        int HP { get; }
        int Armor { get; }
        string SpecialQuality { get; set; }
        string Instinct { get; set; }
        ObservableCollection<IMoves> Moves { get; }
    }
}