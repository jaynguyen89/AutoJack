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

    public partial class GameView : Form {
        public GameController GameController;

        public GameView(GameController GameController) {
            this.GameController = GameController;
            InitializeComponent();

            StartButton.Click += new EventHandler(BeginGameEvent);
            QuitButton.Click += new EventHandler(QuitGameEvent);
            BetButton.Click += new EventHandler(PlaceBetEvent);
            AutoBetButton.Click += new EventHandler(AutoBetEvent);
            this.KeyDown += new KeyEventHandler(KeyCombinationQuit);
        }

        public void SetLabels(Game Game) {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            PlayerName.Text = Game.Player.Name.ToUpper();
            PlayerBet.Text = Game.Player.Bet.ToString();
            PlayerWager.Text = Game.Player.Insurance.ToString();
            PlayerBalance.Text = Game.Player.Balance == 0 ? "-" + Game.Player.Owing.ToString() : Game.Player.Balance.ToString();
            PlayerStreak.Text = Game.Player.CurrentStreak.ToString();
            PlayerHands.Text = "Hands: " + (Game.ShouldWarn ?
                ((Game.Player.Hand1.Count == 0 && Game.Player.Hand2.Count != 0) ||
                (Game.Player.Hand1.Count != 0 && Game.Player.Hand2.Count == 0) ? "1" : "2") : "0");
            PlayerHand1Count.Text = "Hand1 Count: " + (Game.ShouldWarn ? Game.Player.Hand1.Count.ToString() : "0");
            PlayerHand1Sum.Text = "Hand1 Sum: " + Game.GetHandSumFor(Game.Player.Hand1).ToString();
            PlayerHand2Count.Text = "Hand2 Count: " + (Game.ShouldWarn ? Game.Player.Hand2.Count.ToString() : "0");
            PlayerHand2Sum.Text = "Hand2 Sum: " + Game.GetHandSumFor(Game.Player.Hand2).ToString();

            HouseBet.Text = Game.Machine.Bet.ToString();
            HouseWager.Text = Game.Machine.Insurance.ToString();
            CardCount.Text = Game.ShouldWarn ? Game.Deck.Count.ToString() : "SEALED";
            HouseHands.Text = "Hands: " + (Game.ShouldWarn ? 
                ((Game.Machine.Hand1.Count == 0 && Game.Machine.Hand2.Count != 0) ||
                (Game.Machine.Hand1.Count != 0 && Game.Machine.Hand2.Count == 0) ? "1" : "2") : "0");
            HouseHand1Count.Text = "Hand1 Count: " + (Game.ShouldWarn ? Game.Machine.Hand1.Count.ToString() : "0");
            HouseHand1Sum.Text = "Hand1 Sum: " + Game.GetHandSumFor(Game.Machine.Hand1).ToString();
            HouseHand2Count.Text = "Hand2 Count: " + (Game.ShouldWarn ? Game.Machine.Hand2.Count.ToString() : "0");
            HouseHand2Sum.Text = "Hand2 Sum: " + Game.GetHandSumFor(Game.Machine.Hand2).ToString();
        }

        public void ToggleButtonsOnGameBegin() {
            BetButton.Enabled = true;
            AutoBetButton.Enabled = true;

            StartButton.Enabled = false;
        }

        public void ToggleButtonsOnBetPlaced() {
            BetButton.Enabled = false;
            AutoBetButton.Enabled = false;

            StandButton.Enabled = true;
            HitButton.Enabled = true;
            DoubleButton.Enabled = true;
            SplitButton.Enabled = true;
            SurrenderButton.Enabled = true;
        }

        public void DisableQuit() {
            QuitButton.Enabled = false;
        }

        public void EnableQuit() {
            QuitButton.Enabled = true;
        }

        public void EnableSurrender() {
            SurrenderButton.Enabled = true;
        }

        private void PlaceBetEvent(object sender, EventArgs e) {
            GameController.TakeBet();
        }

        private void AutoBetEvent(object sender, EventArgs e) {
            GameController.AutoSetBet();
        }

        private void BeginGameEvent(object sender, EventArgs e) {
            GameController.BeginGame();
        }

        private void QuitGameEvent(object sender, EventArgs e) {
            if (GameController.Game.ShouldWarn) {
                DialogResult result = MessageBox.Show("A game is currently active. Continue?", "Quit Game",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK))
                    this.Close();
            }
            else
                this.Close();
        }

        private void KeyCombinationQuit(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4) {
                e.Handled = true;
                QuitButton.PerformClick();
            }
        }
    }
}
