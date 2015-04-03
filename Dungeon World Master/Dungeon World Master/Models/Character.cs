using Dungeon_World_Master.Collections;
using Dungeon_World_Master.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models
{
    public class Character : INotifyPropertyChanged
    {
        private ObservableCollection<Note> _notes;
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

        private Stat[] _stats;
        public Stat[] Stats
        {
            get
            {
                return _stats; ;
            }
            set
            {
                _stats = value;
                RaisePropertyChanged("Stats");
            }
        }

        private string _alignment;
        public string Alignment
        {
            get
            {
                return _alignment;
            }
            set
            {
                _alignment = value;
                RaisePropertyChanged("Alignment");
            }
        }

        private string _class;
        public string Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
                RaisePropertyChanged("Class");
            }
        }

        private int _level;
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
                RaisePropertyChanged("Level");
            }
        }

        private string _looks;
        public string Looks
        {
            get
            {
                return _looks;
            }
            set
            {
                _looks = value;
                RaisePropertyChanged("Looks");
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private string _playername;
        public string PlayerName
        {
            get
            {
                return _playername;
            }
            set
            {
                _playername = value;
                RaisePropertyChanged("PlayerName");
            }
        }

        private string _race;
        public string Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
                RaisePropertyChanged("Race");
            }
        }

        public Character()
        {
            Alignment = "";
            Class = "";
            Level = 1;
            Name = "";
            Notes = new ObservableCollection<Note>();
            Race = "";
            PlayerName = "";
            Looks = "";
            Stats = GeneralFunctions.GenerateStats();
        }

        public Character(string alignment, string Class, int level, string name, IEnumerable<Note> notes, string race, string playername, string looks, Stat[] stats)
        {
            Alignment = alignment;
            this.Class = Class;
            Level = level;
            Name = name;
            Notes = new ObservableCollection<Note>(notes);
            Race = race;
            PlayerName = playername;
            Looks = looks;
            Stats = stats;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return Name + " " + Level;
        }
    }
}