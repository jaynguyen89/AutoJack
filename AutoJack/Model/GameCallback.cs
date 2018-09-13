using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.Interface;
using AutoJack.Controller;

namespace AutoJack.Model {

    class GameCallback : IHelper {
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

        public async Task DealCardsSingleHand(GameController GameController) {
            Random rand = new Random();
            bool SwitchTurn = false;

            while (GameController.Game.Player.Hand1.Count != 2 ||
                   GameController.Game.Machine.Hand1.Count != 2) {
                Card DrawnCard = GameController.Game.Deck.ElementAt(0);
                GameController.Game.Deck.RemoveAt(0);

                if (SwitchTurn) {
                    if (GameController.Game.Machine.Hand1.Count != 0)
                        DrawnCard.Set = false;

                    GameController.Game.Machine.Hand1.Add(DrawnCard);

                    SwitchTurn = false;
                    GameController.GameView.RenderSingleHandFor(nameof(GameController.Game.Machine), GameController.Game.Machine.Hand1);
                }
                else {
                    if (GameController.Game.Player.Hand1.Count != 0)
                        DrawnCard.Set = false;

                    GameController.Game.Player.Hand1.Add(DrawnCard);

                    SwitchTurn = true;
                    GameController.GameView.RenderSingleHandFor(nameof(GameController.Game.Player), GameController.Game.Player.Hand1);
                }

                GameController.GameView.SetLabels(GameController.Game);
                await Task.Delay(1500);
            }
        }

        public void PassPlayerTurn(GameController GameController) {

        }

        public void AllowDraw1Card(GameController GameController) {

        }

        public void DoubleBetThenTurnOver(GameController GameController) {

        }

        public void SplitPlayerHandThenDraw(GameController GameController) {

        }

        public void TurnUpPlayerHands(GameController GameController) {

        }

        public void PlayerLooseImmediately(GameController GameController) {

        }

        public string CheckForWinner(Game Game) {
            return String.Empty;
        }
    }
}
