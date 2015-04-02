using System;
using System.ComponentModel;

namespace Dungeon_World_Master.Models
{
    public class Note : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        private string _body;
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
                RaisePropertyChanged("Body");
            }
        }

        public Note(string title, string body)
        {
            Title = title;
            Body = body;
        }

        private void RaisePropertyChanged(string v)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public override string ToString()
        {
            return Title;
        }
    }
}