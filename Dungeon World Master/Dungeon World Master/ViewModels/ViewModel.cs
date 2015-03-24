using Dungeon_World_Master.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.ViewModels {
    public class ViewModel {
        public ObservableCollection<Campaign> Campaigns { get; private set; }

        public ViewModel() {
            Campaigns = new ObservableCollection<Campaign>() {
                new Campaign {
                    Name = "Test"
                }
            };
        }
    }
}
