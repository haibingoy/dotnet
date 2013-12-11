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

namespace ActiproTest1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            SR.SetCustomString(SRName.UITabbedMdiContainerCloseButtonToolTip.ToString(), "关闭");
            SR.SetCustomString(SRName.UICommandCloseWindowText.ToString(), "关闭");
            SR.SetCustomString(SRName.UICommandClosePrimaryDocumentText.ToString(), "关闭");
            SR.SetCustomString(SRName.UIWindowControlCloseButtonToolTip.ToString(), "关闭");
            SR.SetCustomString(SRName.UIToolWindowContainerCloseButtonToolTip.ToString(), "关闭");

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
