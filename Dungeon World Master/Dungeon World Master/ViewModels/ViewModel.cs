using Dungeon_World_Master.Models;
using Dungeon_World_Master.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Campaign> Campaigns { get; private set; }

        private Campaign _selectedCampaign;
        public Campaign SelectedCampaign
        {
            get
            {
                return _selectedCampaign;
            }
            set
            {
                _selectedCampaign = value;
                RaisePropertyChanged("SelectedCampaign");
            }
        }

        private Character _selectedCharacter;
        public Character SelectedCharacter
        {
            get
            {
                return _selectedCharacter;
            }
            set
            {
                _selectedCharacter = value;
                RaisePropertyChanged("SelectedCharacter");
            }
        }

        private Note _selectedNote;
        public Note SelectedNote
        {
            get
            {
                return _selectedNote;
            }
            set
            {
                _selectedNote = value;
                RaisePropertyChanged("SelectedNote");
            }
        }

        public ViewModel()
        {
            Campaigns = new ObservableCollection<Campaign>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
