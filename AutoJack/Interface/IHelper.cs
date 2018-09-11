using System.Collections.Generic;
using AutoJack.Model;

namespace AutoJack.Interface {

    interface IHelper {
        List<Card> PrepareDeck();

        void ShuffleDeck(List<Card> Deck);
    }
}
