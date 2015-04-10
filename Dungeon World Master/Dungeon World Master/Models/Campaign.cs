using Dungeon_World_Master.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Campaign : INotifyPropertyChanged {
        public ObservableCollection<Character> Characters { get; private set; }
        public ObservableCollection<ISteading> Cities { get; private set; }
        public ObservableCollection<Front> Fronts { get; private set; }

        private ObservableCollection<Note> _notes;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Note> Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                RaisePropertyChanged("Notes");
            }
        }

        public string Name { get; set; }

        public Campaign(string name) {
            Name = name;
            Characters = new ObservableCollection<Character>();
            Cities = new ObservableCollection<ISteading>();
            Notes = new ObservableCollection<Note>();
            Fronts = new ObservableCollection<Front>();
        }

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
