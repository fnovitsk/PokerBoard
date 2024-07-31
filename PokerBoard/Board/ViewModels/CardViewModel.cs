using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBoard
{
    class CardViewModel: BaseViewModel
    {
        #region Properties
        public string Suit { get; set; }
        public string Value { get; set; }
        
        #endregion

        public CardViewModel(string suit, string value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }


}
