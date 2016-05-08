using Rocket_flight_planner.Models;

namespace Rocket_flight_planner.Services
{
    public class RocketFlightService
    {
        public RocketFlightService()
        {
            LaunchPad = new LaunchPad();       
        }

        public LaunchPad LaunchPad { get; set; }
    }
}