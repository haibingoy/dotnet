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
using System.Windows.Controls;
using System.Windows;

namespace LoveBees
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private int _SelectedIndex;
        public LoginViewModel()
        {
            RegistCommand = new SimpleCommand<object, object>(Regist);
            OkCommand = new SimpleCommand<object, object>(OnOkExcute);
            Users = new ObservableCollection<User>();
            LoadUserInfos();
        }

        private void OnOkExcute(object obj)
        {
            if (!PasswordBox.Password.Equals(Users[SelectedIndex].PW))
            {
                MessageBox.Show("Password is invalid!");
                return;
            }

            UserDataProvider.Instance.SelectedUser = Users[SelectedIndex];
        }

        private void LoadUserInfos()
        {
            foreach (var user in UserDataProvider.Instance.Users)
            {
                Users.Add(user);
            }
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

        public int SelectedIndex
        {
            get 
            {
                return _SelectedIndex;
            }
            set
            {
                _SelectedIndex = value;
                NotifyPropertyChanged("SelectedIndex");
            }
        }

        public PasswordBox PasswordBox { get; set; }

        public ICommand RegistCommand { get; set; }

        public ICommand OkCommand { get; set; }

        private void NotifyPropertyChanged(string prop)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
