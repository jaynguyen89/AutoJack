using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;

namespace AutoJack.Controller {

    class GameController {
        GameView GameView = new GameView();

        public void StartGame() {
            GameView.Show();
        }
    }
}
