using System.Windows;
using ActiproSoftware.Windows.Controls.Ribbon;
using ActiproSoftware.Windows.Themes;

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var startPage = new StartPage();
            ContentControl.Content = startPage;
            ResourceProvider.StartPage = startPage;
            ResourceProvider.MainRegion = ContentControl;
        }
    }
}
