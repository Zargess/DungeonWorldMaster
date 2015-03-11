using System.Collections.ObjectModel;

namespace Dungeon_World_Master.Interfaces {
    public interface IDanger {
        string Name { get; set; }
        IDangerType TypeOfDanger { get; set; }
        string Doom { get; set; }
        IMoves GameMasterMoves { get; }
        ObservableCollection<string> Stakes { get; }
    }
}