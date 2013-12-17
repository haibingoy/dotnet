using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Themes;

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            ThemesMetroThemeCatalogRegistrar.Register();
            RibbonThemeCatalogRegistrar.Register();

            ThemeManager.CurrentTheme = ThemeName.MetroWhite.ToString();
            ThemeManager.AreNativeThemesEnabled = true;
        }
    }
}
