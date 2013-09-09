using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace HMI
{
    public class KButton : Button
    {
        static KButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KButton), new FrameworkPropertyMetadata(typeof(KButton)));
        }

        public KButton()
        {
            Loaded += new RoutedEventHandler(KButton_Loaded);
        }

        void KButton_Loaded(object sender, RoutedEventArgs e)
        {
            if (WindowType.Equals(WindowType.Auto))
            { 
                DependencyObject element = VisualTreeHelper.GetParent(this);
                while (element != null && !(element is Window))
                {
                    element = VisualTreeHelper.GetParent(element);
                }

                if (WindowTypeHelper.GetWindowKind(element).Equals(WindowType.MainWindow))
                {
                    WindowType = WindowType.MainWindow;
                }
                else
                {
                    WindowType = WindowType.SecWindow;
                }
            }
        }

        public WindowType WindowType
          {
              get { return (WindowType)this.GetValue(WindowTypeProperty); }
              set { this.SetValue(WindowTypeProperty, value); } 
          }

        public static readonly DependencyProperty WindowTypeProperty = DependencyProperty.Register(
        "WindowType", typeof(WindowType), typeof(KButton), new PropertyMetadata(WindowType.Auto));        

        }
}
