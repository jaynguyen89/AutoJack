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
        private EngineController EngineController = new EngineController();

        public EngineView() {
            InitializeComponent();

            SelectPlayer.Click += new EventHandler(SelectPlayerEvent);
        }

        private void SelectPlayerEvent(object sender, System.EventArgs e) {
            List<Player> Players = EngineController.getSavedPlayers();
            
            
        }
    }
}
