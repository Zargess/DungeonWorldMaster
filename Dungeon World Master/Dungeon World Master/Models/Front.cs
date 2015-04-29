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

        private Danger _danger1;
        public Danger Danger1
        {
            get
            {
                return _danger1;
            }
            set
            {
                _danger1 = value;
                RaisePropertyChanged("Danger1");
            }
        }

        private Danger _danger2;
        public Danger Danger2
        {
            get
            {
                return _danger2;
            }
            set
            {
                _danger2 = value;
                RaisePropertyChanged("Danger2");
            }
        }

        private Danger _danger3;
        public Danger Danger3
        {
            get
            {
                return _danger3;
            }
            set
            {
                _danger3 = value;
                RaisePropertyChanged("Danger3");
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

        private ObservableCollection<string> _grimportents;
        public ObservableCollection<string> GrimPotents
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
            Danger1 = new Danger();
            Danger2 = new Danger();
            Danger3 = new Danger();
            Description = "Write a description for your front";
            GrimPotents = new ObservableCollection<string>();
        }

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
