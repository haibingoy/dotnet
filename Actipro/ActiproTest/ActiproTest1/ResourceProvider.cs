using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.Ribbon;

namespace ActiproTest1
{
    public static class ResourceProvider
    {
        public static bool HasProjectOpen { get; set; }

        public static Ribbon Ribbon { get; set; }

        public static MainView MainView { get; set; }

        public static StartPage StartPage { get; set; }

        public static ContentControl MainRegion { get; set; }
    }
}
