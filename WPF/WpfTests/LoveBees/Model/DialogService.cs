using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoveBees.Model
{
    public class DialogService
    {
        private static DialogService _DialogService;
        private Dictionary<Type, Type> ViewModelViewMappings;

        public DialogService()
        {
            ViewModelViewMappings = new Dictionary<Type, Type>();
        }

        public static DialogService Instance
        {
            get
            {
                if (_DialogService == null)
                {
                    _DialogService = new DialogService();
                }

                return _DialogService;
            }
        }

        public void OpenView(object viewModel)
        {
            var view = ViewModelViewMappings[viewModel.GetType()];
            Window window = Activator.CreateInstance(view) as Window;
            window.DataContext = viewModel;
            window.ShowDialog();
        }

        public void RegistView(Type viewModelType, Type ViewType)
        {
            if (ViewModelViewMappings.ContainsKey(viewModelType))
            {
                return;
            }

            ViewModelViewMappings.Add(viewModelType, ViewType);
        }
    }
}
