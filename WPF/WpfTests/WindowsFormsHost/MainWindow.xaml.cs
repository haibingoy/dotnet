using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
using Windows = System.Windows.Forms;

namespace WindowsFormsHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Windows.Application.EnableVisualStyles();
            Loaded += MainWindow_Loaded;
            Grid.ContextMenu = new ContextMenu();
            Grid.ContextMenu.Items.Add(new MenuItem {Header = "_Test"});
            Thread.Sleep(2000);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            password.Focus();
            //var panel = new Windows.Panel();
            //panel.Size = new System.Drawing.Size(534, 318);
            //panel.BackColor = System.Drawing.SystemColors.ControlDark;
            //var listBox = new Windows.ListBox();
            //listBox.Items.Add("item 1");
            //listBox.Items.Add("item 2");
            //listBox.Height = 200;
            //listBox.Width = 200;
            //listBox.Anchor = Windows.AnchorStyles.Left | Windows.AnchorStyles.Top;
            //panel.Controls.Add(listBox);
            //var button = new Windows.Button();
            //button.Height = 100;
            //button.Width = 100;
            //button.Text = "Click me.";
            //button.Location = new System.Drawing.Point(250, 200);
            //button.Anchor = Windows.AnchorStyles.Bottom | Windows.AnchorStyles.Right;
            //button.Click += button_Click;
            //panel.Controls.Add(button);
            //panel.Dock = Windows.DockStyle.Fill;

            //WindowsFormsHost.Child = panel;
        }

        void button_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Focused Element: " + FocusManager.GetFocusedElement(this));
        }

        private void MainWindow_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            FieldInfo mostRecentInputDeviceField = typeof(InputManager).GetMember("_mostRecentInputDevice", MemberTypes.Field, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)[0] as FieldInfo;

            mostRecentInputDeviceField.SetValue(InputManager.Current, InputManager.Current.PrimaryKeyboardDevice);
        }
    }
}
