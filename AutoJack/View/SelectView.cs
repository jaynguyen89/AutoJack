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
            PlayerDetails.Click += new EventHandler(ShowPlayerDetails);
            DeletePlayer.Click += new EventHandler(DoDeletePlayer);
        }

        private void PlayerSelected(object sender, EventArgs e) {
            int SelectedId = GetSelectedPlayer();
            this.Visible = false;

            if (SelectedId > 0) {
                Player Player = Players.ElementAt(SelectedId - 100 - 1);

                this.Close();
                GameController GameController = new GameController(Player);
                GameController.StartGame();
            }
            else
                this.Visible = true;
        }

        private void NewPlayer(object sender, EventArgs e) {
            this.Close();
            PlayerController PlayerController = new PlayerController();
            PlayerController.AllowCreatePlayer();
        }

        private void CancelSelect(object sender, EventArgs e) {
            this.Close();
        }

        private void ShowPlayerDetails(object sender, EventArgs e) {
            int SelectedId = GetSelectedPlayer();
            this.Visible = false;

            if (SelectedId > 0) {
                this.Close();

                PlayerController PlayerController = new PlayerController();
                PlayerController.DisplayPlayerDetails(SelectedId);
            }
            else
                this.Visible = true;
        }

        private void DoDeletePlayer(object sender, EventArgs e) {
            int SelectedId = GetSelectedPlayer();

            if (SelectedId > 0) {
                this.Close();

                Engine Engine = new Engine();
                Player Player = Engine.GetPlayerById(SelectedId);

                Engine.Delete(Player);
                SelectController SelectController = new SelectController();
                SelectController.AllowSelectPlayer();
            }
        }

        private int GetSelectedPlayer() {
            string SelectedId = String.Empty;
            bool success = true;

            try {
                SelectedId = PlayersList.SelectedItems[0].SubItems[0].Text;
            } catch (ArgumentOutOfRangeException E) {
                success = false;
            }

            if (success) {
                int.TryParse(SelectedId, out int id);
                return id;
            }

            MessageBox.Show("No player was selected.");
            return -1;
        }
    }
}
