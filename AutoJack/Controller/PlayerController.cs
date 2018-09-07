using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;

namespace AutoJack.Controller {

    class PlayerController {
        PlayerView PlayerView = new PlayerView();

        public void AllowCreatePlayer() {
            PlayerView.Show();
        }
    }
}
