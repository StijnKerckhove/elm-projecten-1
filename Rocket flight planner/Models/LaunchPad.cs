namespace Rocket_flight_planner.Models
{
    public class LaunchPad
    {
        public Rocket Rocket { get; set; }

        public CompressorTank CompressorTank { get; set; }

        public int LaunchTubeDiameter { get; set; }

        public int LaunchTubeLength { get; set; }

        public int LaunchAngle { get; set; }

        public int LaunchHeight { get; set; }
    }
}