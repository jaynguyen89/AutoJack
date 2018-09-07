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

    public partial class SelectView : Form {
        private Engine Engine = new Engine();
        private List<Player> Players;

        public SelectView() {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 30);
            PlayersList.SmallImageList = imgList;

            Players = Engine.GetSavedPlayers();
            foreach (Player Player in Players) {
                ListViewItem ListItem = new ListViewItem(new string[] {
                    Player.Id,
                    Player.Name,
                    Player.Balance.ToString(),
                    Player.Winstreak.ToString(),
                    Player.WinCount.ToString(),
                    Player.LoseCount.ToString(),
                    Player.Owing.ToString(),
                    Player.LastPlay
                });

                PlayersList.Items.Add(ListItem);
            }

            OkButton.Click += new EventHandler(PlayerSelected);
            NewPButton.Click += new EventHandler(NewPlayer);
            BackButton.Click += new EventHandler(CancelSelect);
        }

        private void PlayerSelected(object sender, EventArgs e) {
            bool ShouldStartGame = true;
            string SelectedId = "";
            try {
                SelectedId = PlayersList.SelectedItems[0].SubItems[0].Text;
            } catch (ArgumentOutOfRangeException E) {
                ShouldStartGame = false;
            }

            this.Close();
            if (ShouldStartGame) {
                int.TryParse(SelectedId, out int id);
                Player Player = Players.ElementAt(id - 100 - 1);

                GameController GameController = new GameController(Player);
                GameController.StartGame();
            }
            else {
                MessageBox.Show("No player was selected.");

                SelectController SelectController = new SelectController();
                SelectController.AllowSelectPlayer();
            }
        }

        private void NewPlayer(object sender, EventArgs e) {
            this.Close();
            PlayerController PlayerController = new PlayerController();
            PlayerController.AllowCreatePlayer();
        }

        private void CancelSelect(object sender, EventArgs e) {
            this.Close();
        }
    }
}
