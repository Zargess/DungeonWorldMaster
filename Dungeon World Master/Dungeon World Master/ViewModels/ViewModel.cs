using Dungeon_World_Master.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.ViewModels {
    public class ViewModel {
        public ObservableCollection<ICampaign> Campaigns { get; private set; }

        public ViewModel() {
            Campaigns = new ObservableCollection<ICampaign>();
        }
    }
}
