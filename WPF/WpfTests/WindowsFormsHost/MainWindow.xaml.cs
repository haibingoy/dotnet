using System;
using System.Collections.Generic;
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
            var winformButton = new Windows.Button();
            winformButton.Width = 200;
            winformButton.Height = 30;
            winformButton.Text = "OK";
            winformButton.Click += winformButton_Click;
            WindowsFormsHost.Child = winformButton;
        }

        void winformButton_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
        }
    }
}
