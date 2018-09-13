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
            GameController.Game.TurnWho = nameof(GameController.Game.Machine);
            GameController.GameView.SetLabels(GameController.Game);

            SimulateMachineRoundAsync(GameController);
        }

        public void AllowDraw1Card(string Hand, GameController GameController) {
            Draw1CardFor(nameof(GameController.Game.Player), Hand, true, GameController);
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

        private async void SimulateMachineRoundAsync(GameController GameController) {
            if (GameController.Game.Machine.Hand2.Count == 0) {
                bool canSplit = GameController.Game.CheckIdenticalHand(nameof(GameController.Game.Machine),
                                nameof(GameController.Game.Machine.Hand1));

                if (canSplit) {
                    Card SplittedCard = GameController.Game.Machine.Hand1.ElementAt(1);

                    GameController.Game.Machine.Hand1.RemoveAt(1);
                    GameController.Game.Machine.Hand2.Add(SplittedCard);
                    GameController.GameView.RenderDoubleHandsFor(nameof(GameController.Game.Machine), GameController.Game);

                    await Task.Delay(1500);

                    Draw1CardFor(nameof(GameController.Game.Machine), nameof(GameController.Game.Machine.Hand1), false, GameController);
                    GameController.GameView.RenderDoubleHandsFor(nameof(GameController.Game.Machine), GameController.Game);

                    await Task.Delay(1500);

                    Draw1CardFor(nameof(GameController.Game.Machine), nameof(GameController.Game.Machine.Hand2), true, GameController);
                    GameController.GameView.RenderDoubleHandsFor(nameof(GameController.Game.Machine), GameController.Game);

                    await Task.Delay(1500);
                }
                else
                    SimulateMachine1HandAsync(GameController, nameof(GameController.Game.Machine.Hand1), false);
            }

            if (GameController.Game.Machine.Hand2.Count != 0) {
                SimulateMachine1HandAsync(GameController, nameof(GameController.Game.Machine.Hand1), true);
                SimulateMachine1HandAsync(GameController, nameof(GameController.Game.Machine.Hand2), true);
            }
        }

        //RenderContext: false -- 1 hand, true -- 2 hands
        private async void SimulateMachine1HandAsync(GameController GameController, string Hand, bool RenderContext) {
            if (Hand == "Hand1") {
                while (GameController.Game.GetHandSumFor(GameController.Game.Machine.Hand1) < 11) {
                    Draw1CardFor(nameof(GameController.Game.Machine), nameof(GameController.Game.Machine.Hand1), true, GameController);

                    if (RenderContext)
                        GameController.GameView.RenderDoubleHandsFor(nameof(GameController.Game.Machine), GameController.Game);
                    else
                        GameController.GameView.RenderSingleHandFor(nameof(GameController.Game.Machine), GameController.Game.Machine.Hand1);

                    GameController.GameView.SetLabels(GameController.Game);

                    await Task.Delay(1500);
                }

                if (GameController.Game.GetHandSumFor(GameController.Game.Machine.Hand1) >= 11 &&
                    GameController.Game.GetHandSumFor(GameController.Game.Machine.Hand1) < 16)
            }
            else {

            }
        }

        private void Draw1CardFor(string Who, string Hand, bool Set, GameController GameController) {
            Card DrawnCard = GameController.Game.Deck.ElementAt(0);
            GameController.Game.Deck.RemoveAt(0);

            if (Who == "Player") {
                if (Hand == "Hand1")
                    GameController.Game.Player.Hand1.Add(DrawnCard);
                else
                    GameController.Game.Player.Hand2.Add(DrawnCard);
            }
            else {
                if (Hand == "Hand1")
                    GameController.Game.Machine.Hand1.Add(DrawnCard);
                else
                    GameController.Game.Machine.Hand2.Add(DrawnCard);
            }
        }
    }
}
