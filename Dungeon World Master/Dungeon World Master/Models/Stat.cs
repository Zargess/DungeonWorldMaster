using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models {
    public class Stat : INotifyPropertyChanged {
        public int Modifier {
            get {
                if (Score <= 8) return -1;
                if (Score >= 13 && Score <= 15) return 1;
                if (Score == 16 || Score == 17) return 2;
                if (Score == 18) return 3;
                return 0;
            }
        }
        public string Name { get; private set; }
        private int _score;
        public int Score {
            get {
                return _score;
            }
            set {
                _score = value;
                if (PropertyChanged == null) return;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                PropertyChanged(this, new PropertyChangedEventArgs("Modifier"));
            }
        }

        public Stat(string name, int value) {
            Name = name;
            Score = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
