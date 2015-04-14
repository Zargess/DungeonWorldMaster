using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Master.Models
{
    public class Front : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        private ObservableCollection<Danger> _dangers;
        public ObservableCollection<Danger> Dangers
        {
            get
            {
                return _dangers;
            }
            set
            {
                _dangers = value;
                RaisePropertyChanged("Dangers");
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                RaisePropertyChanged("Description");
            }
        }

        private string _grimportents;
        public string GrimPotents
        {
            get
            {
                return _grimportents;
            }
            set
            {
                _grimportents = value;
                RaisePropertyChanged("GrimPotents");
            }
        }
        
        public Front()
        {
            Name = "Insert name";
            Dangers = new ObservableCollection<Danger>();
            Description = "Write a description for your front";
            GrimPotents = "Write some grim potents that might come to pass";
        }

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
