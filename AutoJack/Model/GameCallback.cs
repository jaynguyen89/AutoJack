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

        public List<Card> ShuffleDeck(List<Card> Deck) {
            Random rand = new Random();

            int tail = Deck.Count - 1;
            Card temp = null;
            int randIndex = -1;

            while (tail != 0) {
                randIndex = rand.Next(0, tail--);
                temp = Deck.ElementAt(tail + 1);
                Deck[tail + 1] = Deck.ElementAt(randIndex);
                Deck[randIndex] = temp;
            }

            return Deck;
        }

        public void DealCards(Game Game) {
            throw new NotImplementedException();
        }
    }
}
