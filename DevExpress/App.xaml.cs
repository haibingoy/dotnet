using System.Threading.Tasks;
using System.Windows;

namespace DXGridSample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: Application {
        public App()
        {
            Task.Factory.StartNew(PersonDataProvider.Instance.PrepareData);
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            // The following line provides localization for data formats. 
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("zh-CN");

            // The following line provides localization for the 
            // application's user interface. 
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("zh-CN");
        }
    }
}
