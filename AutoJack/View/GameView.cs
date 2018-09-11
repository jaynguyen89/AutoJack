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

namespace AutoJack.View {

    public partial class GameView : Form {
        public Game Game;

        public GameView(Game Game) {
            this.Game = Game;

            InitializeComponent();
            SetLabels(Game);

            QuitButton.Click += new EventHandler(QuitGameEvent);
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

        private void QuitGameEvent(object sender, EventArgs e) {
            if (Game.ShouldWarn) {
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
