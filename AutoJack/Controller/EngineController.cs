using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.View;

namespace AutoJack.Controller {

    class EngineController {
        private EngineView EngineView = new EngineView();

        public void StartApplication() {
            Application.Run(EngineView);
        }

        public void GetSavedUsers() {
            SelectController SelectController = new SelectController();
            SelectController.AllowSelectUser();
        }
    }
}
