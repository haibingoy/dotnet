using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveBees
{
    public class LoginViewModel
    {
        public ObservableCollection<User> Users
        {
            get; 
            set;
        }
    }
}
