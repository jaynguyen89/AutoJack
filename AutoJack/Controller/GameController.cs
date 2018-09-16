using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Model;
using AutoJack.common;

namespace AutoJack.Controller {

    public class GameController {
        public GameView GameView { get; }
        public Game Game { get; }
        internal GameCallback Callback = new GameCallback();

        public GameController(User User) {
            Machine Machine = new Machine();

            Player Player = new Player(
                User.Id, User.Name, User.Balance,
                User.Winstreak, User.WinCount,
                User.LoseCount, User.Games,
                User.Owing, User.AverageBet,
                User.MaxBet, User.MinBet,
                User.LastPlay, User.CurrentStreak);

            Game = new Game(Player, Machine);
            Game.Deck = Callback.PrepareDeck();
            GameView = new GameView(this);
        }

        public void StartGame() {
            GameView.Show();
            GameView.SetLabels(Game);
        }

        ~GameController() { }

        public void BeginGame() {
            DeckShuffle ShufflingView = new DeckShuffle();
            ShufflingView.Show();

            Game.ShouldWarn = true;
            Game.Deck = Callback.ShuffleDeck(Game.Deck);

            GameView.SetLabels(Game);
            GameView.ToggleButtonsOnGameBegin();
        }

        public void TakeBet() {
            BetController BetController = new BetController(this);
            GameView.DisableQuit();
            GameView.DisableBetButtons();
            BetController.TakeBet();
        }

        public async Task AutoSetBetAsync() {
            Random rand = new Random();
            int Bet = 0;
            if (Game.Player.Balance > 0)
                Bet = rand.Next((int)(Game.Player.Balance * 0.05), (int)(Game.Player.Balance * 0.25));
            else
                Bet = rand.Next(100, 1001);

            Game.Player.Bet = Bet;
            await ContinueGameAsync(true);
        }

        public async Task ContinueGameAsync(bool context) {
            GameView.EnableQuit();

            if (context) {
                GameView.DisableBetButtons();
                SetMachineBet();

                GameView.EnableSurrender();
                await Callback.DealCardsSingleHand(this);

                Game.TurnWho++;
                GameView.SetLabels(Game);

                GameView.EnableHitAndDoubleButtons();
                GameView.ToogleGameButtonsState(Game);
            }
            else
                GameView.EnableBetButtons();
        }

        private void SetMachineBet() {
            double difference = Utility.RandDoubleInRange(-0.15, 0.15);

            int Bet = (int)(Game.Player.Bet * (1 + difference));
            Game.Machine.Bet = Bet;
        }

        public void ControlButtonsClick(string ClickedButton) {
            switch (ClickedButton) {
                case "StandButton":
                    Callback.PassPlayerTurn(this);
                    break;
                case "HitButton":
                    Callback.AllowDraw1Card(this);
                    break;
                case "DoubleButton":
                    Callback.DoubleBetThenFlipHands(this);
                    break;
                case "SplitButton":
                    Callback.SplitPlayerHandThenDraw(this);
                    break;
                case "FlipButton":
                    Callback.FlipPlayerHands(this);
                    break;
                default:
                    Game.Winner = nameof(Game.Machine);
                    break;
            }

            if (Game.Winner != String.Empty)
                Callback.CalculateBalance(Game);
        }
    }
}