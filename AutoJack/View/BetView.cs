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

namespace AutoJack.View {

    public partial class BetView : Form {
        BetController BetController;

        public BetView(BetController BetController) {
            this.BetController = BetController;
            InitializeComponent();

            int Balance = BetController.GameController.Game.Player.Balance;
            BalanceInput.Text = Balance > 0 ? Balance.ToString() :
                                BetController.GameController.Game.Player.Owing.ToString();

            BetInput.KeyPress += new KeyPressEventHandler(BetInputEnterKey);
            DoneButton.Click += new EventHandler(GetBetInput);
            CancelButton.Click += new EventHandler(CancelBetEvent);
        }

        private void BetInputEnterKey(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                DoneButton.PerformClick();
            }
        }

        private void GetBetInput(object sender, EventArgs e) {
            int Bet = 0;
            string BetText = BetInput.Text;
            if (BetText.Length == 0 || BetText == "Enter a number")
                MessageBox.Show("No bet has been placed.");
            else {
                if (int.TryParse(BetText, out Bet)) {
                    if (CheckBet(Bet)) {
                        BetController.GameController.Game.Player.Bet = Bet;
                        BetController.NotifyGameControllerAsync(true);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Invalid input.");
            }
        }

        private void CancelBetEvent(object sender, EventArgs e) {
            BetController.NotifyGameControllerAsync(false);
            this.Close();
        }

        private bool CheckBet(int Bet) {
            if (Bet < 0)
                MessageBox.Show("Bet must be a positive number.");
            else {
                int Balance = BetController.GameController.Game.Player.Balance;
                if (Balance <= 0 && (Bet > 1000 || Bet < 50)) {
                    MessageBox.Show("Negative Balance: Bet should should be in range [50, 1000].");
                    return false;
                }
                else if (Balance > 0 && Bet > Balance) {
                    MessageBox.Show("Bet must be lower than Balance.");
                    return false;
                }
                else if (Bet < (int)(Balance * 0.05)) {
                    MessageBox.Show("Bet must be higher than " + (int)(Balance * 0.05) + ".");
                    return false;
                }
                else
                    return true;
            }

            return false;
        }
    }
}
