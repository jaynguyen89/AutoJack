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

        void DoubleBetThenTurnOver(GameController GameController);

        void SplitPlayerHandThenDraw(GameController GameController);

        void TurnUpPlayerHands(GameController GameController);

        void PlayerLooseImmediately(GameController GameController);

        string CheckForWinner(Game Game);
    }
}
