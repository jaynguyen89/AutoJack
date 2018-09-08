using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;
using AutoJack.Model;

namespace AutoJack.Controller {

    class PlayerController {

        public void AllowCreatePlayer() {
            NewPlayerView NewPlayerView = new NewPlayerView();
            NewPlayerView.Show();
        }

        public void DisplayPlayerDetails(int Id) {
            Engine Engine = new Engine();
            Player Player = Engine.GetPlayerById(Id);

            PlayerDetailsView PlayerDetailsView = new PlayerDetailsView(Player);
            PlayerDetailsView.Show();
        }
    }
}
