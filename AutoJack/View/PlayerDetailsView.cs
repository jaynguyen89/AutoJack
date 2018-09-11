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

    public partial class UserDetailsView : Form {
        User User;

        public UserDetailsView(User User) {
            this.User = User;
            InitializeComponent();
            FillDetailsIntoForm();

            UpdateButton.Click += new EventHandler(UpdateUserName);
            CloseButton.Click += new EventHandler(CloseDetailsView);
            NameInput.KeyPress += new KeyPressEventHandler(EnterKeyPressed);
        }

        private void FillDetailsIntoForm() {
            NameInput.Text = User.Name;
            BalanceInput.Text = User.Balance.ToString();
            OwingInput.Text = User.Owing.ToString();
            StreakInput.Text = User.Winstreak.ToString();
            GamesInput.Text = User.Games.ToString();
            WinsInput.Text = User.WinCount.ToString();
            LosesInput.Text = User.LoseCount.ToString();
            AvgBetInput.Text = User.AverageBet.ToString();
            MinBetInput.Text = User.MinBet.ToString();
            MaxBetInput.Text = User.MaxBet.ToString();
            LastPlayInput.Text = User.LastPlay;

            string EarningPerGame = (User.Games == 0 ? "N/A" : (
                    User.Balance > 0 ? (Math.Ceiling((1.0 * User.Balance) / User.Games * 1000) / 1000).ToString() :
                    (Math.Round((-1.0 * User.Owing) / User.Games, 3)).ToString()
                ));

            EarnInput.Text = EarningPerGame;

            double WinRate = Math.Round((1.0 * User.WinCount) / User.Games, 3)*100;
            double LoseRate = Math.Round((1.0 * User.LoseCount) / User.Games, 3)*100;

            WinRatio.Text = WinRate.ToString() + "%";
            LoseRatio.Text = LoseRate.ToString() + "%";
            DrawRatio.Text = Math.Round((100 - WinRate - LoseRate), 1).ToString() + "%";

            CurStreakInput.Text = User.CurrentStreak.ToString();
            NextEarnInput.Text = (User.Games == 0 ? "N/A" :
                    (Math.Round((1.0 * User.CurrentStreak) / 100, 2) + Math.Round((1.0 * User.Games) / 1000, 2) + 1).ToString());
        }

        private void UpdateUserName(object sender, EventArgs e) {
            string NewName = NameInput.Text;

            if (NewName == User.Name)
                MessageBox.Show("Name has not been changed.");
            else {
                User.Name = NewName;

                Engine Engine = new Engine();
                Engine.Update(User);
            }
        }

        private void EnterKeyPressed(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                UpdateButton.PerformClick();
            }
        }

        private void CloseDetailsView(object sender, EventArgs e) {
            this.Close();
            SelectController SelectController = new SelectController();
            SelectController.AllowSelectUser();
        }
    }
}
