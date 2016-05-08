using Rocket_flight_planner.Models;

namespace Rocket_flight_planner
{
    public class RocketFlight
    {
        public RocketFlight(Rocket rocket)
        {
            Rocket = rocket;
        }

        public Rocket Rocket { get; set; }

        public double Acceleration { get; set; }

        public double LiftOffTime { get; set; }

        public double Velocity { get; set; }
    }
}