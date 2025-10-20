using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LoginMVVM.Services
{
    public class BaseNotifyService : INotifyPropertyChanged
    {
        public event 
            PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
