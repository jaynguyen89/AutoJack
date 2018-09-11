using System.Collections.Generic;
using AutoJack.Model;

namespace AutoJack.Interface {

    interface IHelper {
        List<Card> PrepareDeck();

        List<Card> ShuffleDeck(List<Card> Deck);

        void DealCards(Game Game);
    }
}
