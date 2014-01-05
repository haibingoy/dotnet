using LoveBees.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cinch;
using LoveBees.ViewModel;

namespace LoveBees
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            RegistCommand = new SimpleCommand<object, object>(Regist);
        }

        private void Regist(object obj)
        {
            var registViewModel = new RegistViewModel();
            DialogService.Instance.OpenView(registViewModel);
        }

        public ObservableCollection<User> Users
        {
            get; 
            set;
        }

        public ICommand RegistCommand { get; set; }
    }
}
