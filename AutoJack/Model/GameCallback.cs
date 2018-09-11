using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.Interface;

namespace AutoJack.Model {

    class GameCallback : IHelper {
        Card Card = new Card();
        const int BURST = 21;

        public List<Card> PrepareDeck() {
            List<Card> Deck = new List<Card>();

            foreach (Pip Pip in Enum.GetValues(typeof(Pip)))
                foreach (Suit Suit in Enum.GetValues(typeof(Suit))) {
                    Card Card = new Card(Suit, Pip);
                    Deck.Add(Card);
                }

            return Deck;
        }

        public void ShuffleDeck(List<Card> Deck) {
            throw new NotImplementedException();
        }
    }
}
