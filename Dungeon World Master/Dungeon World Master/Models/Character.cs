using Dungeon_World_Master.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Character : INotifyPropertyChanged {
        private string _notes;
        public string Notes {
            get {
                return _notes;
            }
            set {
                _notes = value;
                RaisePropertyChanged("Notes");
            }
        }

        public Stat[] Stats { get; private set; }

        private string _alignment;
        public string Alignment {
            get {
                return _alignment;
            }
            set {
                _alignment = value;
                RaisePropertyChanged("Alignment");
            }
        }

        private string _class;
        public string Class {
            get {
                return _class;
            }
            set {
                _class = value;
                RaisePropertyChanged("Class");
            }
        }

        private int _level;
        public int Level {
            get {
                return _level;
            }
            set {
                _level = value;
                RaisePropertyChanged("Level");
            }
        }

        private string _name;
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _playername;
        public string PlayerName {
            get {
                return _playername;
            }
            set {
                _playername = value;
                RaisePropertyChanged("PlayerName");
            }
        }

        private string _race;
        public string Race {
            get {
                return _race;
            }
            set {
                _race = value;
                RaisePropertyChanged("Race");
            }
        }

        public Character() {
            Alignment = "";
            Class = "";
            Level = 1;
            Name = "";
            Notes = "Humus \r\n LOL";
            Race = "";
            Stats = GeneralFunctions.GenerateStats();
        }

        public Character(string path) {
            // TODO : Load Character from xml file or the like. Do this from GeneralFunctions
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name) {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString() {
            return Name + " " + Level;
        }
    }
}
