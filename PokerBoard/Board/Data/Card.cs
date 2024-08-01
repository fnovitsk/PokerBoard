using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBoard
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public CardType Type { get; set; }

        public override string ToString()
        {
            return "${value} of {suit}";
        }
    }
}
