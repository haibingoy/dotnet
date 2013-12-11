using System.Windows;
using ActiproSoftware.Windows.Themes;

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ThemesMetroThemeCatalogRegistrar.Register();
            RibbonThemeCatalogRegistrar.Register();

            ThemeManager.CurrentTheme = ThemeName.MetroWhite.ToString();
            ThemeManager.AreNativeThemesEnabled = true;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PersonDataProvider personDataProvider = new PersonDataProvider();
            personDataProvider.PrepareData();
            DataContext = personDataProvider;
        }
    }
}
