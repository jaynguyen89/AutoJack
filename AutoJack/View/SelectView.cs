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

        public SelectView() {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 30);
            PlayersList.SmallImageList = imgList;

            List<Player> Players = Engine.GetSavedPlayers();
            foreach (Player Player in Players) {
                ListViewItem ListItem = new ListViewItem(new string[] {
                    Player.Id,
                    Player.Name,
                    Player.Balance.ToString(),
                    Player.Winstreak.ToString(),
                    Player.WinCount.ToString(),
                    Player.LoseCount.ToString(),
                    Player.GameCount.ToString(),
                    Player.Owing.ToString()
                });

                PlayersList.Items.Add(ListItem);
            }

            OkButton.Click += new EventHandler(PlayerSelected);
            NewPButton.Click += new EventHandler(NewPlayer);
            BackButton.Click += new EventHandler(CancelSelect);
        }

        private void PlayerSelected(object sender, EventArgs e) {
            bool ShouldStartGame = true;

            try {
                String SelectedId = PlayersList.SelectedItems[0].SubItems[0].Text;
            } catch (ArgumentOutOfRangeException E) {
                ShouldStartGame = false;
            }

            this.Close();
            if (ShouldStartGame) {
                GameController GameController = new GameController();
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
            NewPlayerController NewPController = new NewPlayerController();
            NewPController.AllowCreatePlayer();
        }

        private void CancelSelect(object sender, EventArgs e) {
            this.Close();
        }
    }
}
