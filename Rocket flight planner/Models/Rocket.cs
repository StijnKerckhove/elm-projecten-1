using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{
    public class Rocket : ObservableObject
    {
        private double _mass;

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; OnPropertyChanged("Mass"); }
        }
    }
}