using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Controller;
using AutoJack.Model;

namespace AutoJack.View {
    public partial class EngineView : Form {

        public EngineView() {
            InitializeComponent();

            SelectPlayer.Click += new EventHandler(SelectPlayerEvent);
            ExitButton.Click += new EventHandler(QuitApp);
        }

        private void SelectPlayerEvent(object sender, System.EventArgs e) {
            EngineController EngineController = new EngineController();
            EngineController.GetSavedPlayers();
        }

        private void QuitApp(object sender, System.EventArgs e) {
            this.Close();
        }
    }
}
