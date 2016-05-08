using System.Globalization;
using System.Threading;
using Rocket_flight_planner.Models;
using Rocket_flight_planner.Services;

namespace Rocket_flight_planner.Views
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

            var rocketFlightService = new RocketFlightService();
            DataContext = rocketFlightService.LaunchPad;
        }
    }
}
