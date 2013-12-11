using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculator;

namespace CalculatorCustomer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            if (int.TryParse(arg1.Text, out a) && int.TryParse(arg2.Text, out b))
            {
                result.Text = Calculator.Calculate.Add(a, b).ToString();
            }
            else
            {
                result.Text = "Parameter error.";
                Log4NetService.Instance.LogError(this, "Parameter error.");
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MySettings.Default.Reset();
            MySettings.Default.Save();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySettings.Default.TestString = "new value";
            MySettings.Default.Save();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }
    }
}
