using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Dungeon_World_Master.Models
{
    public class Danger : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _cast;
        public string Cast
        {
            get
            {
                return _cast;
            }
            set
            {
                _cast = value;
                RaisePropertyChanged("Cast");
            }
        }

        private string _doom;
        public string Doom
        {
            get
            {
                return _doom;
            }
            set
            {
                _doom = value;
                RaisePropertyChanged("Doom");
            }
        }

        private string _impulse;
        public string Impulse
        {
            get
            {
                return _impulse;
            }
            set
            {
                _impulse = value;
                RaisePropertyChanged("Impulse");
            }
        }

        private string _stakes;
        public string Stakes
        {
            get
            {
                return _stakes;
            }
            set
            {
                _stakes = value;
                RaisePropertyChanged("Stakes");
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
        }

        private string _typeOfDanger;
        public string TypeOfDanger
        {
            get
            {
                return _typeOfDanger;
            }
            set
            {
                _typeOfDanger = value;
                RaisePropertyChanged("TypeOfDanger");
            }
        }

        public Danger()
        {
            Cast = "Insert cast";
            Doom = "Insert a type of doom";
            Impulse = "Insert impulse";
            Stakes = "Write some stakes";
            Title = "Insert a title";
            TypeOfDanger = "Write a type of danger";
        }

        public void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}