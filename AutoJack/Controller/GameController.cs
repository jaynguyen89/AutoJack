using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Model;

namespace AutoJack.Controller {

    class GameController {
        GameView GameView;
        Game Game;
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
            GameView = new GameView(Game);
        }

        public void StartGame() {
            GameView.Show();
        }
    }
}