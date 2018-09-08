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

    public partial class PlayerDetailsView : Form {
        Player Player;

        public PlayerDetailsView(Player player) {
            Player = player;
            InitializeComponent();
            FillDetailsIntoForm();

            UpdateButton.Click += new EventHandler(UpdatePlayerName);
            CloseButton.Click += new EventHandler(CloseDetailsView);
        }

        private void FillDetailsIntoForm() {
            NameInput.Text = Player.Name;
            BalanceInput.Text = Player.Balance.ToString();
            OwingInput.Text = Player.Owing.ToString();
            StreakInput.Text = Player.Winstreak.ToString();
            GamesInput.Text = Player.Games.ToString();
            WinsInput.Text = Player.WinCount.ToString();
            LosesInput.Text = Player.LoseCount.ToString();
            AvgBetInput.Text = Player.AverageBet.ToString();
            MinBetInput.Text = Player.MinBet.ToString();
            MaxBetInput.Text = Player.MaxBet.ToString();
            LastPlayInput.Text = Player.LastPlay;

            string EarningPerGame = (Player.Games == 0 ? "N/A" : (
                    Player.Balance > 0 ? (Math.Ceiling((1.0 * Player.Balance) / Player.Games * 1000) / 1000).ToString() :
                    (Math.Round((-1.0 * Player.Owing) / Player.Games, 3)).ToString()
                ));

            EarnInput.Text = EarningPerGame;

            double WinRate = Math.Round((1.0 * Player.WinCount) / Player.Games, 3)*100;
            double LoseRate = Math.Round((1.0 * Player.LoseCount) / Player.Games, 3)*100;

            WinRatio.Text = WinRate.ToString() + "%";
            LoseRatio.Text = LoseRate.ToString() + "%";
            DrawRatio.Text = Math.Round((100 - WinRate - LoseRate), 1).ToString() + "%";

            CurStreakInput.Text = Player.CurrentStreak.ToString();
            NextEarnInput.Text = (Player.Games == 0 ? "N/A" :
                    (Math.Round((1.0 * Player.CurrentStreak) / 100, 2) + Math.Round((1.0 * Player.Games) / 1000, 2) + 1).ToString());
        }

        private void UpdatePlayerName(object sender, EventArgs e) {
            string NewName = NameInput.Text;

            if (NewName == Player.Name)
                MessageBox.Show("Name has not been changed.");
            else {
                Player.Name = NewName;

                Engine Engine = new Engine();
                Engine.Update(Player);
            }
        }

        private void CloseDetailsView(object sender, EventArgs e) {
            this.Close();
            SelectController SelectController = new SelectController();
            SelectController.AllowSelectPlayer();
        }
    }
}
