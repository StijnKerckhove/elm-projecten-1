using System.Collections.Generic;
using System.Windows.Documents;
using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{

    public class LaunchPad : ObservableObject
    {
        private double _launchTubeDiameter;
        private int _launchAngle;
        private int _launchHeight;
        private int _launchTubeLength;

        private Rocket _rocket;
        private RocketFlight _rocketFlight;
        private CompressorTank _compressorTank;

        public LaunchPad()
        {
            _compressorTank = new CompressorTank();
            _rocket = new Rocket { Mass = 150 };
            _rocketFlight = new RocketFlight { Rocket = _rocket, PreferredDistance = 8};
            _launchHeight = 10;
            _launchTubeLength = 230;
            _launchAngle = 45;
            PossibleAngles = new List<int> {30,45,60};
            _launchTubeDiameter = 26.9;
        }

        public IEnumerable<int> PossibleAngles { get; set; }


        public double LaunchTubeDiameter
        {
            get { return _launchTubeDiameter; }
            set { _launchTubeDiameter = value; OnPropertyChanged("LaunchTubeDiameter"); }
        }

        public int LaunchTubeLength
        {
            get { return _launchTubeLength; }
            set { _launchTubeLength = value; OnPropertyChanged("LaunchTubeLength"); }
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