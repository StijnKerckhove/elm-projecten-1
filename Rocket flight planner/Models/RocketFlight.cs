using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.Models
{
    public class RocketFlight : ObservableObject
    {
        private double _acceleration;
        private double _liftOffTime;
        private double _velocity;

        private Rocket _rocket;

        public RocketFlight(Rocket rocket)
        {
            _rocket = rocket;
        }

        public Rocket Rocket
        {
            get { return _rocket; }
            set { _rocket = value; OnPropertyChanged("Rocket"); }
        }

        public double Acceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; OnPropertyChanged("Acceleration"); }
        }

        public double LiftOffTime
        {
            get { return _liftOffTime; }
            set { _liftOffTime = value; OnPropertyChanged("LiftOffTime"); }
        }

        public double Velocity
        {
            get { return _velocity; }
            set { _velocity = value; OnPropertyChanged("Velocity"); }
        }
    }
}