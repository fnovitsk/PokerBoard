using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace PokerBoard
{
    class CardViewModel: INotifyPropertyChanged
    {
        #region Properties
        public string Suit { get; set; }
        public string Value { get; set; }

        public CardType CardType { get; set; }
        private Visibility _imageVisibility;

        public event PropertyChangedEventHandler PropertyChanged;

        public Visibility Visability
        {
            get { return _imageVisibility; }
            set
            {
                if (_imageVisibility != value)
                {
                    _imageVisibility = value;
                    OnPropertyChanged(nameof(Visability));
                }
            }
        }
        #endregion
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        

        public CardViewModel(string suit, string value)
        {
            this.Suit = suit;
            this.Value = value;

            _imageVisibility = Visibility.Collapsed;
        }
    }


}
