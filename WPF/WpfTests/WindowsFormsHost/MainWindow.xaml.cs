using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var panel = new Windows.Panel();
            panel.Size = new System.Drawing.Size(534, 318);
            panel.BackColor = System.Drawing.SystemColors.ControlDark;
            var listBox = new Windows.ListBox();
            listBox.Items.Add("item 1");
            listBox.Items.Add("item 2");
            listBox.Height = 200;
            listBox.Width = 200;
            listBox.Location = new System.Drawing.Point(0, 0);
            panel.Controls.Add(listBox);
            var button = new Windows.Button();
            button.Height = 100;
            button.Width = 100;
            button.Text = "Click me.";
            button.Location = new System.Drawing.Point(200, 0);
            panel.Controls.Add(button);
            WindowsFormsHost.Child = panel;
        }
    }
}
