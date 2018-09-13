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
using AutoJack.common;

namespace AutoJack.View {

    public partial class GameView : Form {
        public GameController GameController;

        public GameView(GameController GameController) {
            this.GameController = GameController;
            InitializeComponent();

            StartButton.Click += new EventHandler(BeginGameEvent);
            QuitButton.Click += new EventHandler(QuitGameEvent);
            BetButton.Click += new EventHandler(PlaceBetEvent);
            AutoBetButton.Click += new EventHandler(AutoBetEventAsync);
            this.KeyDown += new KeyEventHandler(KeyCombinationQuit);

            StandButton.Click += new EventHandler(PlayerStandEvent);
            HitButton.Click += new EventHandler(PlayerHitEvent);
            DoubleButton.Click += new EventHandler(PlayerDoubleEvent);
            SplitButton.Click += new EventHandler(PlayerSplitEvent);
            TurnButton.Click += new EventHandler(PlayerTurnOverEvent);
            SurrenderButton.Click += new EventHandler(PlayerGiveUpEvent);
        }

        public void SetLabels(Game Game) {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TurnLabel.Text = (Game.TurnWho == String.Empty ? "Waiting" : Game.TurnWho);

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

        public void ToogleGameButtonsState(Game Game) {
            if (Game.Player.Hand2.Count <= 1) {
                if (Game.GetHandSumFor(Game.Player.Hand1) < 16) {
                    StandButton.Enabled = false;
                    TurnButton.Enabled = false;
                }
                else if (Game.GetHandSumFor(Game.Player.Hand1) < 21) {
                    StandButton.Enabled = true;
                    TurnButton.Enabled = true;
                }
                else {
                    StandButton.Enabled = false;
                    TurnButton.Enabled = false;
                }

                SplitButton.Enabled = Game.CheckIdenticalHand(nameof(Game.Player), nameof(Game.Player.Hand1));
            }
            else {
                bool shouldEnableStandBtnHand1 = false;
                bool shouldEnableStandBtnHand2 = false;
                bool shouldEnableTurnBtnHand1 = false;
                bool shouldEnableTurnBtnHand2 = false;

                if (Game.GetHandSumFor(Game.Player.Hand1) >= 16 && Game.GetHandSumFor(Game.Player.Hand1) <= 21) {
                    shouldEnableStandBtnHand1 = true;
                    shouldEnableTurnBtnHand1 = true;
                }

                if (Game.GetHandSumFor(Game.Player.Hand2) >= 16 && Game.GetHandSumFor(Game.Player.Hand2) <= 21) {
                    shouldEnableStandBtnHand2 = true;
                    shouldEnableTurnBtnHand2 = true;
                }

                StandButton.Enabled = (shouldEnableStandBtnHand1 || shouldEnableStandBtnHand2);
                TurnButton.Enabled = (shouldEnableTurnBtnHand1 || shouldEnableTurnBtnHand2);


                SplitButton.Enabled = (Game.CheckIdenticalHand(nameof(Game.Player), nameof(Game.Player.Hand1)) &&
                    Game.CheckIdenticalHand(nameof(Game.Player), nameof(Game.Player.Hand2)));
            }
        }

        public void DisableHitAndDoubleButtons() {
            HitButton.Enabled = false;
            DoubleButton.Enabled = false;
        }

        public void EnableHitAndDoubleButtons() {
            HitButton.Enabled = true;
            DoubleButton.Enabled = true;
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

        public void DisableBetButtons() {
            BetButton.Enabled = false;
            AutoBetButton.Enabled = false;
        }

        public void EnableBetButtons() {
            BetButton.Enabled = true;
            AutoBetButton.Enabled = true;
        }

        private void PlaceBetEvent(object sender, EventArgs e) {
            GameController.TakeBet();
        }

        internal void RenderSingleHandFor(string Who, List<Card> Hand) {
            if (Who == "Player")
                PlayerHandCards.Controls.Clear();
            else
                HouseHandCards.Controls.Clear();

            foreach (Card Card in Hand) {
                PictureBox CardPhoto = new PictureBox();

                if (Who == "Player") {
                    Panel HandCard = new Panel();

                    HandCard.SuspendLayout();
                    PlayerHandCards.Controls.Add(HandCard);

                    HandCard.Location = new Point(3, 3);
                    HandCard.Size = new Size(200, 299);
                    HandCard.TabIndex = 0;
                    HandCard.ResumeLayout();

                    PictureBox CardSet = new PictureBox();
                    ((ISupportInitialize)CardSet).BeginInit();
                    CardSet.Image = Card.Set ? Properties.Resources.cardback : Properties.Resources.joker;

                    CardSet.Location = new Point(87, 3);
                    CardSet.Size = new Size(25, 35);
                    CardSet.SizeMode = PictureBoxSizeMode.StretchImage;
                    CardSet.TabIndex = 1;
                    CardSet.TabStop = false;
                    ((ISupportInitialize)CardSet).EndInit();
                    
                    ((ISupportInitialize)CardPhoto).BeginInit();
                    CardPhoto.Image = Image.FromFile(Utility.GetBasePath() +
                        @"resources\deck\" + Card.Pip.ToString() + Card.Suit.ToString() + ".png");

                    CardPhoto.Location = new Point(13, 42);
                    CardPhoto.Size = new Size(173, 257);
                    CardPhoto.TabIndex = 0;
                    CardPhoto.TabStop = false;
                    ((ISupportInitialize)CardPhoto).EndInit();

                    HandCard.Controls.Add(CardSet);
                    HandCard.Controls.Add(CardPhoto);
                }
                else {
                    ((ISupportInitialize)CardPhoto).BeginInit();
                    CardPhoto.Image = !Card.Set ? Image.FromFile(Utility.GetBasePath() +
                        @"resources\deck\" + Card.Pip.ToString() + Card.Suit.ToString() + ".png") : Properties.Resources.cardback;

                    CardPhoto.Location = new Point(13, 42);
                    CardPhoto.Size = new Size(173, 257);
                    CardPhoto.TabIndex = 0;
                    CardPhoto.TabStop = false;
                    ((ISupportInitialize)CardPhoto).EndInit();

                    HouseHandCards.Controls.Add(CardPhoto);
                }
            }
        }

        private async void AutoBetEventAsync(object sender, EventArgs e) {
            await GameController.AutoSetBetAsync();
        }

        private void BeginGameEvent(object sender, EventArgs e) {
            GameController.BeginGame();
        }

        private void PlayerStandEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(StandButton));
        }

        private void PlayerHitEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(HitButton));
        }

        private void PlayerDoubleEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(DoubleButton));
        }

        private void PlayerSplitEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(SplitButton));
        }

        private void PlayerTurnOverEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(TurnButton));
        }

        private void PlayerGiveUpEvent(object sender, EventArgs e) {
            GameController.ControlGameLoop(nameof(SurrenderButton));
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
