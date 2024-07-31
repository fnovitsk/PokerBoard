using System.ComponentModel;

namespace PokerBoard
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };
    }
}
