using System;
using System.Windows;
using System.Windows.Input;
using Rocket_flight_planner.Models;
using Rocket_flight_planner.Interfaces;

namespace Rocket_flight_planner.ViewModels
{

    class LaunchPadViewModel : ObservableObject
    {
        private LaunchPad _launchPadModel;
        private int _launchTubeDiameter;


        private const double GravitationalConstant = 9.81;

        private ICommand _test;
        private ICommand _calculate;

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
                return _test ?? (_test = new RelayCommand(
                    param => Weep()
                    ));
            }
        }

        public void Weep()
        {
            LaunchPadModel.Rocket.Mass += 100;
        }

        public void CalculateRocketVelocity()
        {
            // Calculate surface area launch tube
            var r = Convert.ToDouble(LaunchPadModel.LaunchTubeDiameter) / 2;
            var rocketTubeSurfaceArea = Math.Pow(r * Math.Pow(10, -3), 2) * Math.PI;

            // Calculate rocket velocity
            var d = LaunchPadModel.RocketFlight.PreferredDistance; //m
            var a = (Math.PI / 180) * LaunchPadModel.LaunchAngle;
            var y0 = LaunchPadModel.LaunchHeight * Math.Pow(10, -2); //cm

            LaunchPadModel.RocketFlight.Velocity =
                Math.Sqrt((Math.Pow(d, 2) * GravitationalConstant) / (2 * (d * Math.Sin(a) * Math.Cos(a) - y0 * Math.Pow(Math.Cos(a), 2))));

            // Calculate needed pressure
            var w = LaunchPadModel.Rocket.Mass * GravitationalConstant * Math.Pow(10, -3); //grams
            var v = LaunchPadModel.RocketFlight.Velocity;
            var l = LaunchPadModel.LaunchTubeLength * Math.Pow(10, -3); //mm

            //Correctiefactor
            var c = 2;

            var launchPressure = (int)(w / rocketTubeSurfaceArea *
                                                                  (GravitationalConstant +
                                                                   Math.Pow(v, 2) / (2 * l * GravitationalConstant))) * 2;

            LaunchPadModel.CompressorTank.LaunchPressure = launchPressure;


            // Calculate max height
            LaunchPadModel.RocketFlight.Acceleration = v/d;
            var acc = LaunchPadModel.RocketFlight.Acceleration;
            LaunchPadModel.RocketFlight.MaxHeight = y0 + (acc*Math.Tan(a)) -
                                                    (GravitationalConstant*Math.Pow(acc, 2))/
                                                     (2*Math.Pow(v*Math.Cos(a), 2));

        }

        public ICommand Calculate
        {
            get
            {
                return _calculate ?? (_calculate = new RelayCommand(
                    param => CalculateRocketVelocity()
                    ));
            }
        }
    }
}
