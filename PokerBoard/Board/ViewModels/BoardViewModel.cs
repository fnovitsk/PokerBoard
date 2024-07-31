using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBoard
{
    class BoardViewModel : BaseViewModel

    {
        public List<CardViewModel> Cards { get; set; }

        public BoardViewModel()
        {
            var cards = BoardStructure.generateCards();
            this.Cards = new List<CardViewModel>(cards.Select(card => new CardViewModel(card.Suit, card.Value)));
        }
    }
}
