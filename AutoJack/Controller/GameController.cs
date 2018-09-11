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
        GameView GameView;
        public Game Game { get; }
        GameCallback Callback = new GameCallback();

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

        public void BeginGame() {
            DeckShuffle ShufflingView = new DeckShuffle();
            ShufflingView.Show();

            Game.ShouldWarn = true;
            Game.Deck = Callback.ShuffleDeck(Game.Deck);

            GameView.ToggleButtonsOnGameBegin();
            GameView.SetLabels(Game);
        }

        public void TakeBet() {
            BetController BetController = new BetController(this);
            GameView.DisableQuit();
            BetController.TakeBet();
        }

        public void AutoSetBet() {
            Random rand = new Random();
            int Bet = 0;
            if (Game.Player.Balance > 0)
                Bet = rand.Next((int)(Game.Player.Balance * 0.1), (int)(Game.Player.Balance * 0.5));
            else
                Bet = rand.Next(100, 1000);

            Game.Player.Bet = Bet;
            SetMachineBet();
            ContinueGame(true);
        }

        public void ContinueGame(bool context) {
            if (context) {
                SetMachineBet();
                GameView.SetLabels(Game);

                GameView.EnableSurrender();
                Callback.DealCards(this.Game);
            }

            GameView.EnableQuit();
        }

        private void SetMachineBet() {
            Random rand = new Random();
            double difference = rand.NextDouble() * 0.6 - 0.3;

            int Bet = (int)(Game.Player.Bet * (1 + difference));
            Game.Machine.Bet = Bet;
        }
    }
}