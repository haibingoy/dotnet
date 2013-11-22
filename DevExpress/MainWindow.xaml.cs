
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Net.Mime;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DXGridSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }

        private void MainWindow_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            FieldInfo mostRecentInputDeviceField = typeof(InputManager).GetMember("_mostRecentInputDevice", MemberTypes.Field, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)[0] as FieldInfo;

            mostRecentInputDeviceField.SetValue(InputManager.Current, InputManager.Current.PrimaryKeyboardDevice);
        }
    }
}