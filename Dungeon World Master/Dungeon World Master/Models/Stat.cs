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
                if (Value <= 8) return -1;
                if (Value >= 13 && Value <= 15) return 1;
                if (Value == 16 || Value == 17) return 2;
                if (Value == 18) return 3;
                return 0;
            }
        }
        public string Name { get; private set; }
        private int _value;
        public int Value {
            get {
                return _value;
            }
            set {
                _value = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                PropertyChanged(this, new PropertyChangedEventArgs("Modifier"));
            }
        }

        public Stat(string name, int value) {
            Name = name;
            Value = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
