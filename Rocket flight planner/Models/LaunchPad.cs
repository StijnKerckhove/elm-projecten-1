namespace Rocket_flight_planner.Models
{

    public class LaunchPad
    {
        public LaunchPad()
        {
            CompressorTank = new CompressorTank();
            Rocket = new Rocket();
            RocketFlight = new RocketFlight(Rocket);
        }

        public Rocket Rocket { get; set; }

        public CompressorTank CompressorTank { get; set; }

        public int LaunchTubeDiameter { get; set; }

        public int LaunchTubeLength { get; set; }

        public int LaunchAngle { get; set; }

        public int LaunchHeight { get; set; }

        public RocketFlight RocketFlight { get; set; }
    }
}