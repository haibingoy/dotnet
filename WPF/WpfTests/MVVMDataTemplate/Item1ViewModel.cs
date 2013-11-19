using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDataTemplate
{
    public class Item1ViewModel : INotifyPropertyChanged
    {
        private string _Message;

        public string Message
        {
            get { return _Message; }
            set 
            { 
                _Message = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Message"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
