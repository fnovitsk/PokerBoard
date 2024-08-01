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
            for (int i = 0; i < 3; i++) { this.Cards[i].CardType = CardType.Flop; }
            this.Cards[3].CardType = CardType.Turn;
            this.Cards[4].CardType = CardType.River;

        }
    }
}
