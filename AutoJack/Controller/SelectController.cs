using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.View;
using AutoJack.Model;

namespace AutoJack.Controller {
    
    class SelectController {
        SelectView SelectView = new SelectView();

        public void AllowSelectPlayer() {
            SelectView.Show();
        }
    }
}
