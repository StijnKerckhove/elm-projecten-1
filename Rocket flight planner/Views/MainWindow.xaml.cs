using System;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace Rocket_flight_planner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            // Overwrite system locale
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
        }
    }
}
