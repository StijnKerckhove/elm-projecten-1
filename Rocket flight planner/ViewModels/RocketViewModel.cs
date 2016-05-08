using System.ComponentModel;
using System.Runtime.CompilerServices;
using Rocket_flight_planner.Annotations;

namespace Rocket_flight_planner.ViewModels
{
    class RocketViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
