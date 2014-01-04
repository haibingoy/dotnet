using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveBees
{
    public class Account
    {
        private string _Site;
        public string Site
        {
            get
            {
                return _Site;
            }
            set
            {
                _Site = value;
                NotifyPropertyChanged("Site");
            }
        }

        private string _Usage;
        public string Usage
        {
            get
            {
                return _Usage;
            }
            set
            {
                _Usage = value;
                NotifyPropertyChanged("Usage");
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


        private void NotifyPropertyChanged(string prop)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
