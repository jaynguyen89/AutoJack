using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.Interface;
using AutoJack.Controller;
using AutoJack.common;

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
                    GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                        GameController.Game.Machine.Hand1, GameController.Game.Machine.Hand1Flipped);
                }
                else {
                    if (GameController.Game.Player.Hand1.Count != 0)
                        DrawnCard.Set = false;

                    GameController.Game.Player.Hand1.Add(DrawnCard);

                    SwitchTurn = true;
                    GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                        GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);
                }

                GameController.GameView.SetLabels(GameController.Game);
                await Task.Delay(1000);
            }
        }

        public void PassPlayerTurn(GameController GameController) {
            GameController.Game.TurnWho++;
            GameController.GameView.SetLabels(GameController.Game);

            SimulateMachineRoundAsync(GameController);
        }

        public void AllowDraw1Card(GameController GameController) {
            if (GameController.Game.Player.Hand2.Count != 0) {
                SelectHand SelectHand = new SelectHand(GameController);
                SelectHand.ShowDialog();
            }
            else {
                Draw1CardFor(nameof(GameController.Game.Player), "Hand1", true, GameController);
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                    GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);

                GameController.GameView.SetLabels(GameController.Game);
                GameController.GameView.ToogleGameButtonsState(GameController.Game);
            }
        }

        public void DrawToSelectedHand(string Hand, GameController GameController) {
            if (Hand == "Hand1") {
                Draw1CardFor(nameof(GameController.Game.Player), "Hand1", true, GameController);
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                    GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);
            }
            else {
                Draw1CardFor(nameof(GameController.Game.Player), "Hand2", true, GameController);
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            }

            GameController.GameView.SetLabels(GameController.Game);
            GameController.GameView.ToogleGameButtonsState(GameController.Game);
        }

        public void DoubleBetThenFlipHands(GameController GameController) {
            GameController.Game.Player.Bet *= 2;
            GameController.GameView.SetLabels(GameController.Game);

            if (GameController.Game.Player.Hand2.Count == 0) {
                Draw1CardFor(nameof(GameController.Game.Player), "Hand1", true, GameController);
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game.Player.Hand1,
                    GameController.Game.Player.Hand1Flipped);
                GameController.GameView.SetLabels(GameController.Game);

                if (GameController.Game.GetHandSumFor(GameController.Game.Player.Hand1) > 21)
                    LooseBurstHand(GameController, nameof(GameController.Game.Player), nameof(GameController.Game.Player.Hand1));
                else
                    FlipPlayerHands(GameController);
            }
            else {
                Draw1CardFor(nameof(GameController.Game.Player), "Hand1", true, GameController);
                Draw1CardFor(nameof(GameController.Game.Player), "Hand2", true, GameController);

                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                GameController.GameView.SetLabels(GameController.Game);

                if (GameController.Game.GetHandSumFor(GameController.Game.Player.Hand1) > 21)
                    LooseBurstHand(GameController, nameof(GameController.Game.Player), nameof(GameController.Game.Player.Hand1));

                if (GameController.Game.GetHandSumFor(GameController.Game.Player.Hand2) > 21)
                    LooseBurstHand(GameController, nameof(GameController.Game.Player), nameof(GameController.Game.Player.Hand2));

                if (!GameController.Game.Player.Hand1Flipped || !GameController.Game.Player.Hand2Flipped)
                    FlipPlayerHands(GameController);
            }
        }

        public void SplitPlayerHandThenDraw(GameController GameController) {
            Card SplittedCard = GameController.Game.Player.Hand1.ElementAt(1);
            GameController.Game.Player.Hand1.RemoveAt(1);

            GameController.Game.Player.Hand2.Add(SplittedCard);
            Draw1CardFor(nameof(GameController.Game.Player), nameof(GameController.Game.Player.Hand1), true, GameController);
            Draw1CardFor(nameof(GameController.Game.Player), nameof(GameController.Game.Player.Hand2), true, GameController);

            GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);

            GameController.GameView.SetLabels(GameController.Game);
            GameController.GameView.ToogleGameButtonsState(GameController.Game);
        }

        public void FlipPlayerHands(GameController GameController) {
            //SimulateMachineRoundAsync(GameController);

            GameController.Game.Player.Hand1Flipped = true;

            if (GameController.Game.Player.Hand2.Count != 0) {
                GameController.Game.Player.Hand2Flipped = true;
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            }
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                    GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);

            GameController.Game.Machine.Hand1Flipped = true;

            if (GameController.Game.Machine.Hand2.Count != 0) {
                GameController.Game.Machine.Hand2Flipped = true;
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            }
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                    GameController.Game.Machine.Hand1, GameController.Game.Player.Hand1Flipped);

            CalculateBalance(GameController.Game);
        }

        public void LooseBurstHand(GameController GameController, string Who, string Hand) {
            if (Who == nameof(GameController.Game.Player))
                PlayerBurstAsync(GameController, Hand);
            else
                MachineBurstAsync(GameController, Hand);
        }

        private async void PlayerBurstAsync(GameController GameController, string Hand) {
            if (Hand == "Hand1") {
                GameController.Game.Player.Hand1Flipped = true;

                if (GameController.Game.Player.Hand2.Count == 0) { // player has only 1 hand
                    GameController.Game.Winner = nameof(GameController.Game.Machine);
                    GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                        GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);

                    await Task.Delay(2000);

                    GameController.Game.Machine.Hand1Flipped = true;
                    GameController.Game.Machine.Hand2Flipped = true;

                    if (GameController.Game.Machine.Hand2.Count == 0)
                        GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                            GameController.Game.Machine.Hand1, GameController.Game.Player.Hand1Flipped);
                    else
                        GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                            GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);

                    await Task.Delay(2000);

                    CalculateBalance(GameController.Game);
                }
                else {
                    GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                        GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                    await Task.Delay(2000);

                    if (GameController.Game.Player.Hand2Flipped)
                        CalculateBalance(GameController.Game);
                }
            }
            else { //player hand2
                GameController.Game.Player.Hand2Flipped = true;
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                await Task.Delay(2000);

                if (GameController.Game.Player.Hand1Flipped)
                    CalculateBalance(GameController.Game);
            }
        }

        private async void MachineBurstAsync(GameController GameController, string Hand) {
            if (Hand == "Hand1") {
                GameController.Game.Machine.Hand1Flipped = true;

                if (GameController.Game.Machine.Hand2.Count == 0) { // player has only 1 hand
                    GameController.Game.Winner = nameof(GameController.Game.Player);
                    GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                        GameController.Game.Machine.Hand1, GameController.Game.Player.Hand1Flipped);

                    await Task.Delay(2000);

                    GameController.Game.Player.Hand1Flipped = true;
                    GameController.Game.Player.Hand2Flipped = true;

                    if (GameController.Game.Player.Hand2.Count == 0)
                        GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                            GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);
                    else
                        GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                            GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);

                    await Task.Delay(2000);

                    CalculateBalance(GameController.Game);
                }
                else {
                    GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                        GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                    await Task.Delay(2000);

                    if (GameController.Game.Machine.Hand2Flipped)
                        CalculateBalance(GameController.Game);
                }
            }
            else { //player hand2
                GameController.Game.Machine.Hand2Flipped = true;
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                await Task.Delay(2000);

                if (GameController.Game.Machine.Hand1Flipped)
                    CalculateBalance(GameController.Game);
            }
        }

        public void CalculateBalance(Game Game) { // calculate then end game

        }

        private async void SimulateMachineRoundAsync(GameController GameController) {
            if (GameController.Game.Machine.Hand2.Count == 0) {
                bool canSplit = GameController.Game.CheckIdenticalHand(nameof(GameController.Game.Machine),
                                nameof(GameController.Game.Machine.Hand1));

                if (canSplit) {
                    Card SplittedCard = GameController.Game.Machine.Hand1.ElementAt(1);

                    GameController.Game.Machine.Hand1.RemoveAt(1);
                    GameController.Game.Machine.Hand2.Add(SplittedCard);

                    Draw1CardFor(nameof(GameController.Game.Machine), nameof(GameController.Game.Machine.Hand1), false, GameController);
                    Draw1CardFor(nameof(GameController.Game.Machine), nameof(GameController.Game.Machine.Hand2), true, GameController);

                    GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                        GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
                    GameController.GameView.SetLabels(GameController.Game);
                }
                else
                    RunGame1Hand(GameController, nameof(GameController.Game.Machine.Hand1), false);
            }

            if (GameController.Game.Machine.Hand2.Count != 0) {
                RunGame1Hand(GameController, nameof(GameController.Game.Machine.Hand1), true);
                RunGame1Hand(GameController, nameof(GameController.Game.Machine.Hand2), true);
            }

            await Task.Delay(2000);
            GameController.Game.TurnWho++;
            GameController.GameView.SetLabels(GameController.Game);
        }

        private void RunGame1Hand(GameController GameController, string Hand, bool RenderContext) {
            if (Hand == "Hand1")
                SimulateMachine1Hand(GameController, Hand, RenderContext);
            else
                SimulateMachine1Hand(GameController, Hand, RenderContext);
        }

        //RenderContext: false -- 1 hand, true -- 2 hands
        private void SimulateMachine1Hand(GameController GameController, string Hand, bool RenderContext) {
            while (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) < 11) {
                Draw1CardFor(nameof(GameController.Game.Machine), Hand, true, GameController);
                RenderMachine1HandAsync(GameController, Hand, RenderContext);
            }

            if (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) == 20)
                SimulateMachineFlipHand(GameController, Hand, RenderContext);

            if (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) >= 11 &&
                GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) <= 16) {
                double hitProp = Utility.RandDoubleInRange(0.4, 1.0);
                double doubleProp = Utility.RandDoubleInRange(0.0, 0.6);

                if (hitProp >= doubleProp) {
                    Draw1CardFor(nameof(GameController.Game.Machine), Hand, true, GameController);
                    RenderMachine1HandAsync(GameController, Hand, RenderContext);

                    CheckMachineBurst(GameController, Hand, RenderContext);
                }
                else
                    SimulateMachineDoubleBetAsync(GameController, Hand, RenderContext);
            }

            if (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) >= 17 &&
                GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) <= 19) {
                double standProp = Utility.RandDoubleInRange(0.0, 1.0);
                double hitProp = Utility.RandDoubleInRange(0.0, 0.5);
                double doubleProp = Utility.RandDoubleInRange(0.0, 0.25);
                double flipProp = Utility.RandDoubleInRange(0.0, 0.75);

                double max = Utility.Max(new double[] { standProp, hitProp, doubleProp, flipProp });
                if (max == standProp)
                    return;
                else if (max == hitProp) {
                    Draw1CardFor(nameof(GameController.Game.Machine), Hand, true, GameController);
                    RenderMachine1HandAsync(GameController, Hand, RenderContext);

                    CheckMachineBurst(GameController, Hand, RenderContext);
                }
                else if (max == doubleProp)
                    SimulateMachineDoubleBetAsync(GameController, Hand, RenderContext);
                else {
                    GameController.Game.Machine.Hand1Flipped = (Hand == "Hand1");
                    GameController.Game.Machine.Hand2Flipped = (Hand == "Hand2");

                    SimulateMachineFlipHand(GameController, Hand, RenderContext);
                }
            }
        }

        private void CheckMachineBurst(GameController GameController, string Hand, bool RenderContext) {
            if (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) == 21) {
                GameController.Game.Machine.Hand1Flipped = (Hand == "Hand1");
                GameController.Game.Machine.Hand2Flipped = (Hand == "Hand2");

                SimulateMachineFlipHand(GameController, Hand, RenderContext);
            }

            if (GameController.Game.GetHandSumFor(Hand == "Hand1" ? GameController.Game.Machine.Hand1 : GameController.Game.Machine.Hand2) > 21)
                LooseBurstHand(GameController, nameof(GameController.Game.Machine), Hand);
        }

        private async void RenderMachine1HandAsync(GameController GameController, string Hand, bool RenderContext) {
            if (RenderContext)
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                    GameController.Game.Machine.Hand1, GameController.Game.Player.Hand1Flipped);

            GameController.GameView.SetLabels(GameController.Game);

            await Task.Delay(2000);
        }

        private async void SimulateMachineDoubleBetAsync(GameController GameController, string Hand, bool RenderContext) {
            GameController.Game.Machine.Bet *= 2;
            GameController.GameView.SetLabels(GameController.Game);

            Draw1CardFor(nameof(GameController.Game.Machine), Hand, true, GameController);
            CheckMachineBurst(GameController, Hand, RenderContext);

            if (RenderContext)
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                    GameController.Game.Machine.Hand1,GameController.Game.Player.Hand1Flipped);

            await Task.Delay(2000);
            SimulateMachineFlipHand(GameController, Hand, RenderContext);
        }

        private void SimulateMachineFlipHand(GameController GameController, string Hand, bool RenderContext) {
            GameController.Game.Machine.Hand1Flipped = (Hand == "Hand1");
            GameController.Game.Machine.Hand2Flipped = (Hand == "Hand2");

            if (RenderContext)
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Machine), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Machine),
                    GameController.Game.Machine.Hand1, GameController.Game.Player.Hand1Flipped);

            GameController.Game.Player.Hand1Flipped = true;

            if (GameController.Game.Player.Hand2.Count != 0) {
                GameController.Game.Player.Hand2Flipped = true;
                GameController.GameView.RenderDoubleHandAsyncFor(nameof(GameController.Game.Player), GameController.Game,
                    GameController.Game.Player.Hand1Flipped, GameController.Game.Player.Hand2Flipped);
            }
            else
                GameController.GameView.RenderSingleHandAsyncFor(nameof(GameController.Game.Player),
                    GameController.Game.Player.Hand1, GameController.Game.Player.Hand1Flipped);

            CalculateBalance(GameController.Game);
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
