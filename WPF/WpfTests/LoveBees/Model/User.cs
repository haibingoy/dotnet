using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveBees
{
    public class User : INotifyPropertyChanged
    {
        public User()
        {
            Accounts = new ObservableCollection<Account>();
            Id = new Guid().ToString();
        }

        public string Id
        {
            get;
            private set;
        }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string _PW;
        public string PW
        {
            get
            {
                return _PW;
            }
            set
            {
                _PW = value;
                NotifyPropertyChanged("PW");
            }
        }

        public ObservableCollection<Account> Accounts { get; set; }

        private void NotifyPropertyChanged(string prop)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
