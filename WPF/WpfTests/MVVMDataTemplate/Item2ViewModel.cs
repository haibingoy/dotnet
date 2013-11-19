using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDataTemplate
{
    public class Item2ViewModel
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

        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
