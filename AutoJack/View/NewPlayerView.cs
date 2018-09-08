using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoJack.Model;
using AutoJack.Controller;

namespace AutoJack.View {

    public partial class NewPlayerView : Form {
        private Engine Engine = new Engine();

        public NewPlayerView() {
            InitializeComponent();

            OkButton.Click += new EventHandler(CreateNewPlayer);
            BackButton.Click += new EventHandler(CancelCreate);
        }

        private void CreateNewPlayer(object sender, EventArgs e) {
            String PlayerName = NameInput.Text;

            if ("Your Name...".Contains(PlayerName))
                MessageBox.Show("Please enter your name to continue.");
            else {
                List<Player> Players = Engine.GetSavedPlayers();
                int.TryParse(Players.ElementAt(Players.Count - 1).Id, out int id);

                Player NewPlayer = new Player(
                        (id + 1).ToString(),
                        PlayerName
                    );

                Players.Add(NewPlayer);
                Engine.WritePlayersJSON(Players);

                this.Close();
                GameController GameController = new GameController(NewPlayer);
                GameController.StartGame();
            }
        }

        private void CancelCreate(object sender, EventArgs e) {
            this.Close();
            SelectController SelectController = new SelectController();
            SelectController.AllowSelectPlayer();
        }
    }
}
