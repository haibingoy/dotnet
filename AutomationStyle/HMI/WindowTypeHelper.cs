using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HMI
{
    public class WindowTypeHelper
    {
        public static readonly DependencyProperty WindowKindProperty = DependencyProperty.RegisterAttached(
            "WindowKind",
            typeof(WindowType),
            typeof(WindowTypeHelper),
            new FrameworkPropertyMetadata(WindowType.Auto, FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetWindowKind(DependencyObject element, WindowType value)
        {
            element.SetValue(WindowKindProperty, value);
        }

        public static WindowType GetWindowKind(DependencyObject element)
        {
            return (WindowType)element.GetValue(WindowKindProperty);
        }
    }
}
