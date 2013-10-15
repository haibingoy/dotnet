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

namespace BusyCursor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mouse.OverrideCursor = Cursors.Wait;
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void UIElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Title = "Popup window";
            window.Owner = this;
            window.Height = 50;
            window.Width = 90;
            window.ShowDialog();
        }
    }
}
