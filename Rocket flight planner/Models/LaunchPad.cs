using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{

    public class LaunchPad : ObservableObject
    {
        private int _launchTubeDiameter;
        private int _launchAngle;
        private int _launchHeight;

        private Rocket _rocket;
        private RocketFlight _rocketFlight;
        private CompressorTank _compressorTank;

        public LaunchPad()
        {
            _compressorTank = new CompressorTank {LaunchPressure = 6};
            _rocket = new Rocket { Mass = 100 };
            _rocketFlight = new RocketFlight(_rocket);
        }

        public int LaunchTubeDiameter
        {
            get { return _launchTubeDiameter; }
            set { _launchTubeDiameter = value; OnPropertyChanged("LaunchTubeDiameter"); }
        }

        public int LaunchTubeLength
        {
            get { return _launchAngle; }
            set { _launchAngle = value; OnPropertyChanged("LaunchTubeLength"); }
        }

        public int LaunchAngle
        {
            get { return _launchAngle; }
            set { _launchAngle = value; OnPropertyChanged("LaunchAngle"); }
        }

        public int LaunchHeight
        {
            get { return _launchHeight; }
            set { _launchHeight = value; OnPropertyChanged("LaunchHeight"); }
        }

        public Rocket Rocket
        {
            get { return _rocket; }
            set { _rocket = value; OnPropertyChanged("Rocket"); }
        }

        public RocketFlight RocketFlight
        {
            get { return _rocketFlight; }
            set { _rocketFlight = value; OnPropertyChanged("RocketFlight"); }
        }

        public CompressorTank CompressorTank
        {
            get { return _compressorTank; }
            set { _compressorTank = value; OnPropertyChanged("CompressorTank"); }
        }
    }
}