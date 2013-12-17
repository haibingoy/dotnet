using System;
using System.Windows;

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for Backstage.xaml
    /// </summary>
    public partial class Backstage
    {
        public Backstage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ResourceProvider.HasProjectOpen = true;
        }
    }
}
