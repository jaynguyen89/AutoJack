using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Model;

namespace AutoJack.Controller {

    class GameController {
        GameView GameView = new GameView();
        public Player Player { get; set; }
        
        public GameController(Player Player) {
            this.Player = Player;
        }

        public void StartGame() {
            GameView.Player = Player;
            GameView.Show();
        }
    }
}
