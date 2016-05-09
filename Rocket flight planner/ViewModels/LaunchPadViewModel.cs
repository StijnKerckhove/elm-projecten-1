using System.Windows.Input;
using Rocket_flight_planner.Models;
using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.ViewModels
{

    class LaunchPadViewModel : ObservableObject
    {
        private LaunchPad _launchPadModel;
        private int _launchTubeDiameter;

        private ICommand _test;

        public LaunchPad LaunchPadModel
        {
            get { return _launchPadModel; }
            set
            {
                _launchPadModel = value;
                OnPropertyChanged("LaunchPadModel");
            }
        }

        public int LaunchTubeDiameter
        {
            get { return _launchTubeDiameter; }
            set
            {
                _launchTubeDiameter = value;
                OnPropertyChanged("LaunchTubeDiameter");
            }
        }

        public ICommand Test
        {
            get
            {
                if (_test == null)
                {
                    _test = new RelayCommand(
                        param => Weep()
                    );
                }
                return _test;
            }
        }

        public void Weep()
        {
            LaunchPadModel.Rocket.Mass += 100;
        }
    }
}
