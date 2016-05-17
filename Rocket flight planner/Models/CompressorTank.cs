using System;
using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{
    public class CompressorTank : ObservableObject
    {
        private int _launchPressure;

        public double LaunchPressure
        {
            get { return Math.Round(_launchPressure * Math.Pow(10, -5), 2); }
            set { _launchPressure = (int)value; OnPropertyChanged("LaunchPressure"); }
        }
    }
}