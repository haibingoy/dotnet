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
    }
}
