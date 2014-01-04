using LoveBees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoveBees.View
{
    /// <summary>
    /// RegistView.xaml 的交互逻辑
    /// </summary>
    public partial class RegistView : Window
    {
        public RegistView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text))
            {
                MessageBox.Show("User name is invalid.");
                return;
            }

            if (string.IsNullOrEmpty(Password1.Password) || !Password1.Password.Equals(Password2.Password))
            {
                MessageBox.Show("Two passwords are not equal or you have not input any password!");
            }

            var user = new User()
            {
                Name = UserName.Text,
                PW = Password2.Password
            };

            UserDataProvider.Instance.AddUser(user);
        }
    }
}
