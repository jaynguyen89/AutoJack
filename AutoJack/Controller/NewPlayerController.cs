using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoJack.View;

namespace AutoJack.Controller {

    class NewPlayerController {
        NewPlayerView NewPView = new NewPlayerView();

        public void AllowCreatePlayer() {
            NewPView.Show();
        }
    }
}
