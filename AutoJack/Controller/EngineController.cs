using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Model;

namespace AutoJack.Controller {

    class EngineController {
        public Engine Engine = new Engine();

        public void startApplication() {
            Application.Run(new View.EngineView());
        }

        public List<Player> getSavedPlayers() {
            return Engine.getSavedPlayers();
        }
    }
}
