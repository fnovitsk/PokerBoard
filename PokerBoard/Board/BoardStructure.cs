using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBoard
{
    public static class BoardStructure
    {
        //Create full deck of cards
        public static List<Card> CreateDeck()
        {
            string[] suits = { "hearts", "diamonds", "clubs", "spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

            List<Card> deck = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Add(new Card { Suit = suit, Value = value });
                }
            }
            return deck;
        }
        //Generate 5 Random Cards from full deck
        public static List<Card> generateCards()
        {
            var deck = CreateDeck();
            Random random = new Random();
            return deck.OrderBy(x => random.Next()).Take(5).ToList();
        }

    }
}
