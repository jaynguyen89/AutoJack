using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Controller;

namespace AutoJack.Controller {

    public class BetController {
        public GameController GameController { get; set; }

        public BetController(GameController GameController) {
            this.GameController = GameController;
        }

        public void TakeBet() {
            BetView BetView = new BetView(this);
            BetView.Show();
        }

        public async void NotifyGameControllerAsync(bool context) {
            await GameController.ContinueGameAsync(context);
        }
    }
}
