using LoveBees.Model;
using LoveBees.ViewModel;
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
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var registViewModel = this.DataContext as RegistViewModel;
            registViewModel.PasswordBox1 = Password1;
            registViewModel.PasswordBox2 = Password2;
        }
    }
}
