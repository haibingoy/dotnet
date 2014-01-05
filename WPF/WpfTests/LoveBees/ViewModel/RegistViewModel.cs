using Cinch;
using LoveBees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoveBees.ViewModel
{
    public class RegistViewModel : INotifyPropertyChanged
    {
        public RegistViewModel()
        {
            OkCommand = new SimpleCommand<object, object>(OnOkClicked);
        }

        public PasswordBox PasswordBox1 { get; set; }

        public PasswordBox PasswordBox2 { get; set; }

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        private void OnOkClicked(object obj)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("User name is invalid.");
                return;
            }

            if (string.IsNullOrEmpty(PasswordBox1.Password) || !PasswordBox1.Password.Equals(PasswordBox2.Password))
            {
                MessageBox.Show("Two passwords are not equal or you have not input any password!");
                return;
            }

            if (UserDataProvider.Instance.Users.Any(x => x.Name.Equals(UserName)))
            {
                MessageBox.Show("This user name is already registered!");
                return;
            }

            var user = new User()
            {
                Name = UserName,
                PW = PasswordBox1.Password
            };

            UserDataProvider.Instance.AddUser(user);
        }

        public ICommand OkCommand { get; set; }

        private void NotifyPropertyChanged(string prop)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string _UserName;
    }
}
