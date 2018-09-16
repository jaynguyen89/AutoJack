using System.Collections.Generic;
using System.Threading.Tasks;
using AutoJack.Model;
using AutoJack.Controller;

namespace AutoJack.Interface {

    interface IHelper {
        List<Card> PrepareDeck();

        List<Card> ShuffleDeck(List<Card> Deck);

        Task DealCardsSingleHand(GameController GameController);

        void PassPlayerTurn(GameController GameController);

        void AllowDraw1Card(GameController GameController);

        void DoubleBetThenFlipHands(GameController GameController);

        void SplitPlayerHandThenDraw(GameController GameController);

        void FlipPlayerHands(GameController GameController);
    }
}
