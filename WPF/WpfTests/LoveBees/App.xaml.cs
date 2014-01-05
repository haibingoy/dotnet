using LoveBees.Model;
using LoveBees.View;
using LoveBees.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LoveBees
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            RegistAllViews();
            LoginViewModel viewModel = new LoginViewModel();
            DialogService.Instance.OpenView(viewModel);
        }

        private void RegistAllViews()
        {
            DialogService.Instance.RegistView(typeof(LoginViewModel), typeof(Login));
            DialogService.Instance.RegistView(typeof(RegistViewModel), typeof(RegistView));
            DialogService.Instance.RegistView(typeof(PWViewModel), typeof(PWView));
        }
    }
}
