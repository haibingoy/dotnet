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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            ResourceProvider.Ribbon = ribbon;
            Loaded += MainView_Loaded;
            ResourceProvider.Ribbon.IsApplicationMenuOpenChanged += Ribbon_IsApplicationMenuOpenChanged;
        }

        private void MainView_Loaded(object sender, RoutedEventArgs e)
        {
            ResourceProvider.Ribbon.IsApplicationMenuOpen = true;
        }

        void Ribbon_IsApplicationMenuOpenChanged(object sender, ActiproSoftware.Windows.BooleanPropertyChangedRoutedEventArgs e)
        {
            if (!ResourceProvider.HasProjectOpen && !ResourceProvider.Ribbon.IsApplicationMenuOpen)
            {
                ResourceProvider.MainRegion.Content = ResourceProvider.StartPage;
            }
        }
    }
}
