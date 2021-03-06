﻿using System;
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
        System.Timers.Timer Timer;
        int hour, minute, second;

        public GameView(GameController GameController) {
            this.GameController = GameController;
            InitializeComponent();

            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            SetTimeValues(DateTime.Now.ToString("HH mm ss"));

            Timer = new System.Timers.Timer { Interval = 1000 };
            Timer.Elapsed += TimeWrapEvent;

            Timer.Start();

            StartButton.Click += new EventHandler(BeginGameEvent);
            QuitButton.Click += new EventHandler(QuitGameEvent);
            BetButton.Click += new EventHandler(PlaceBetEvent);
            AutoBetButton.Click += new EventHandler(AutoBetEventAsync);
            this.KeyDown += new KeyEventHandler(KeyCombinationQuit);

            StandButton.Click += new EventHandler(PlayerStandEvent);
            HitButton.Click += new EventHandler(PlayerHitEvent);
            DoubleButton.Click += new EventHandler(PlayerDoubleEvent);
            SplitButton.Click += new EventHandler(PlayerSplitEvent);
            FlipButton.Click += new EventHandler(PlayerFlipHandEvent);
            SurrenderButton.Click += new EventHandler(PlayerGiveUpEvent);
        }

        private void SetTimeValues(string Time) {
            string[] tokens = Time.Split(' ');

            int.TryParse(tokens[0], out hour);
            int.TryParse(tokens[1], out minute);
            int.TryParse(tokens[2], out second);
        }

        private void TimeWrapEvent(object sender, System.Timers.ElapsedEventArgs e) {
            Invoke(new Action(() => {
                if (++second == 60) {
                    second = 0;
                    minute++;
                }

                if (minute == 60) {
                    minute = 0;
                    hour += 1;
                }

                TimeLabel.Text = (hour < 10 ? "0" : "") + hour.ToString() + (minute < 10 ? ":0" : ":") +
                                 minute.ToString() + (second < 10 ? ":0" : ":") + second.ToString();
            }));
        }

        public void SetLabels(Game Game) {
            TurnLabel.Text = (Game.TurnWho == -1 ? "Waiting" : (Game.TurnWho % 2 == 0 ? "Player" : "House"));

            PlayerName.Text = Game.Player.Name.ToUpper();
            PlayerBet.Text = Game.Player.Bet.ToString();

            while (PlayerBet.Width < TextRenderer.MeasureText(PlayerBet.Text,
                   new Font(PlayerBet.Font.FontFamily, PlayerBet.Font.Size, PlayerBet.Font.Style)).Width) {
                PlayerBet.Font = new Font(PlayerBet.Font.FontFamily, PlayerBet.Font.Size - 0.5f, PlayerBet.Font.Style);
            }

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

            while (HouseBet.Width < TextRenderer.MeasureText(HouseBet.Text,
                   new Font(HouseBet.Font.FontFamily, HouseBet.Font.Size, HouseBet.Font.Style)).Width) {
                HouseBet.Font = new Font(HouseBet.Font.FontFamily, HouseBet.Font.Size - 0.5f, HouseBet.Font.Style);
            }

            HouseWager.Text = Game.Machine.Insurance.ToString();
            CardCount.Text = Game.ShouldWarn ? Game.Deck.Count.ToString() : "SEALED";
            HouseHands.Text = "Hands: " + (Game.ShouldWarn ? 
                ((Game.Machine.Hand1.Count == 0 && Game.Machine.Hand2.Count != 0) ||
                (Game.Machine.Hand1.Count != 0 && Game.Machine.Hand2.Count == 0) ? "1" : "2") : "0");
            HouseHand1Count.Text = "Hand1 Count: " + (Game.ShouldWarn ? Game.Machine.Hand1.Count.ToString() : "0");
            HouseHand2Count.Text = "Hand2 Count: " + (Game.ShouldWarn ? Game.Machine.Hand2.Count.ToString() : "0");
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
                    FlipButton.Enabled = false;
                }
                else if (Game.GetHandSumFor(Game.Player.Hand1) <= 21) {
                    StandButton.Enabled = true;
                    FlipButton.Enabled = true;
                }
                else {
                    StandButton.Enabled = false;
                    FlipButton.Enabled = false;
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
                FlipButton.Enabled = (shouldEnableTurnBtnHand1 || shouldEnableTurnBtnHand2);
                
                SplitButton.Enabled = false;//(Game.CheckIdenticalHand(nameof(Game.Player), nameof(Game.Player.Hand1)) &&
                    //Game.CheckIdenticalHand(nameof(Game.Player), nameof(Game.Player.Hand2)));
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

        public void SetLogText(string Logs) {
            string[] tokens = Logs.Split(';');

            HouseActionLabel.Text = "Last Action: " + tokens[tokens.Length - 2];
            string tooltip = string.Empty;

            for (int i = 0; i < tokens.Length - 1; i++)
                tooltip += (i + 1).ToString() + ". " + tokens[i] + ";\n";
           
            LogTooltip.SetToolTip(LogLabel, tooltip);
        }

        internal async void RenderSingleHandAsyncFor(string Who, List<Card> Hand, bool IsFlip) {
            if (Who == "Player")
                PlayerHandCards.Controls.Clear();
            else
                HouseHandCards.Controls.Clear();

            foreach (Card Card in Hand) {
                PictureBox CardPhoto = new PictureBox();

                if (Who == "Player") {
                    Panel HandCard = new Panel();
                    PlayerHandCards.Controls.Add(HandCard);

                    RenderCardToPanelForPlayer(Card, CardPhoto, HandCard, IsFlip);
                }
                else {
                    RenderCardToPanelForHouse(Card, CardPhoto, IsFlip);
                    HouseHandCards.Controls.Add(CardPhoto);
                }

                await Task.Delay(1000);
            }
        }

        internal async void RenderDoubleHandAsyncFor(string Who, Game Game, bool IsFlip1, bool IsFlip2) {
            FlowLayoutPanel Hand1Panel = new FlowLayoutPanel();
            FlowLayoutPanel Hand2Panel = new FlowLayoutPanel();

            Hand1Panel.Location = new Point(3, 3);
            Hand1Panel.Size = new Size(427, 299);
            Hand1Panel.TabIndex = 0;

            Hand2Panel.Location = new Point(436, 3);
            Hand2Panel.Size = new Size(427, 299);
            Hand2Panel.TabIndex = 1;

            if (Who == "Player") {
                PlayerHandCards.Controls.Clear();

                PlayerHandCards.Controls.Add(Hand1Panel);
                PlayerHandCards.Controls.Add(Hand2Panel);
                
                Panel HandCard = new Panel();

                foreach (Card Card in Game.Player.Hand1.ToList()) {
                    Hand1Panel.Controls.Add(HandCard);

                    PictureBox CardPhoto = new PictureBox();
                    RenderCardToPanelForPlayer(Card, CardPhoto, HandCard, IsFlip1);

                    await Task.Delay(1500);
                }

                foreach (Card Card in Game.Player.Hand2.ToList()) {
                    Hand2Panel.Controls.Add(HandCard);

                    PictureBox CardPhoto = new PictureBox();
                    RenderCardToPanelForPlayer(Card, CardPhoto, HandCard, IsFlip2);

                    await Task.Delay(1500);
                }
            }
            else {
                HouseHandCards.Controls.Clear();

                HouseHandCards.Controls.Add(Hand1Panel);
                HouseHandCards.Controls.Add(Hand2Panel);

                foreach (Card Card in Game.Machine.Hand1.ToList()) {
                    PictureBox CardPhoto = new PictureBox();

                    RenderCardToPanelForHouse(Card, CardPhoto, IsFlip1);
                    Hand1Panel.Controls.Add(CardPhoto);

                    await Task.Delay(1500);
                }

                foreach (Card Card in Game.Machine.Hand2.ToList()) {
                    PictureBox CardPhoto = new PictureBox();

                    RenderCardToPanelForHouse(Card, CardPhoto, IsFlip2);
                    Hand2Panel.Controls.Add(CardPhoto);

                    await Task.Delay(1500);
                }
            }
        }

        private void RenderCardToPanelForPlayer(Card Card, PictureBox CardPhoto, Panel HandCard, bool IsFlipped) {
            HandCard.SuspendLayout();
            HandCard.Location = new Point(3, 3);
            HandCard.Size = new Size(200, 299);
            HandCard.TabIndex = 0;
            HandCard.ResumeLayout();

            PictureBox CardSet = new PictureBox();
            ((ISupportInitialize)CardSet).BeginInit();
            CardSet.Image = IsFlipped ? Properties.Resources.joker : (Card.Set ? Properties.Resources.cardback : Properties.Resources.joker);

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

        private void RenderCardToPanelForHouse(Card Card, PictureBox CardPhoto, bool IsFlipped) {
            ((ISupportInitialize)CardPhoto).BeginInit();
            CardPhoto.Image = (IsFlipped ? Image.FromFile(Utility.GetBasePath() +
                @"resources\deck\" + Card.Pip.ToString() + Card.Suit.ToString() + ".png") :
                    (!Card.Set ? Image.FromFile(Utility.GetBasePath() +
                    @"resources\deck\" + Card.Pip.ToString() + Card.Suit.ToString() + ".png") :
                        Properties.Resources.cardback));
                
            CardPhoto.Location = new Point(13, 42);
            CardPhoto.Size = new Size(173, 257);
            //CardPhoto.TabIndex = 0;
            CardPhoto.TabStop = false;
            ((ISupportInitialize)CardPhoto).EndInit();
        }

        private async void AutoBetEventAsync(object sender, EventArgs e) {
            await GameController.AutoSetBetAsync();
        }

        private void BeginGameEvent(object sender, EventArgs e) {
            GameController.BeginGame();
        }

        private void PlayerStandEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(StandButton));
        }

        private void PlayerHitEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(HitButton));
        }

        private void PlayerDoubleEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(DoubleButton));
        }

        private void PlayerSplitEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(SplitButton));
        }

        private void PlayerFlipHandEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(FlipButton));
        }

        private void PlayerGiveUpEvent(object sender, EventArgs e) {
            GameController.ControlButtonsClick(nameof(SurrenderButton));
        }

        private void QuitGameEvent(object sender, EventArgs e) {
            if (GameController.Game.ShouldWarn) {
                DialogResult result = MessageBox.Show("A game is currently active. Continue?", "Quit Game",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK)) {
                    GC.Collect();
                    Timer.Stop();
                    this.Close();
                }
            }
            else {
                GC.Collect();
                Timer.Stop();
                this.Close();
            }
        }

        private void KeyCombinationQuit(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4) {
                e.Handled = true;
                QuitButton.PerformClick();
            }
        }
    }
}
