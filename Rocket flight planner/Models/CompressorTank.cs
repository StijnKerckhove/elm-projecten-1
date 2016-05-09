using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{
    public class CompressorTank : ObservableObject
    {
        private int _launchPressure;

        public int LaunchPressure
        {
            get { return _launchPressure; }
            set { _launchPressure = value; OnPropertyChanged("LaunchPressure"); }
        }
    }
}