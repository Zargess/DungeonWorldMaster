using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Interfaces {
    public interface ICampaign {
        string Name { get; set; }
        ObservableCollection<ICharacter> Characters { get; }
        ObservableCollection<IFront> CampaignFronts { get; }
        ObservableCollection<IFront> AdventureFronts { get; }
        ObservableCollection<IEnemy> Enemies { get; }
    }
}
