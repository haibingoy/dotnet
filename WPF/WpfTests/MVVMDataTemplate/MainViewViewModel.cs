using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVVMDataTemplate
{
    public class MainViewViewModel
    {
        public MainViewViewModel()
        {
            Item1 = new Item1ViewModel();
            Item2 = new Item2ViewModel();
            Button = new Button();
            Button.Content = "Test Button";
        }

        public object Item1 { get; set; }

        public object Item2 { get; set; }

        public Button Button { get; set; }
    }
}
