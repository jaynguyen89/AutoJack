namespace AutoJack.View
{
    partial class GameView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TimingPanel = new System.Windows.Forms.Panel();
            this.Seconds = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.UserBetPanel = new System.Windows.Forms.Panel();
            this.AutoBetButton = new System.Windows.Forms.Button();
            this.BetButton = new System.Windows.Forms.Button();
            this.PlayerWager = new System.Windows.Forms.Label();
            this.UserWagerLabel = new System.Windows.Forms.Label();
            this.UserBetLabel = new System.Windows.Forms.Label();
            this.PlayerBet = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.GameControlPanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SurrenderButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.UserStatPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.PlayerStreak = new System.Windows.Forms.Label();
            this.StreakLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.PlayerBalance = new System.Windows.Forms.Label();
            this.DeckPanel = new System.Windows.Forms.Panel();
            this.CardBack = new System.Windows.Forms.PictureBox();
            this.CardCount = new System.Windows.Forms.Label();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.UserSumPanel = new System.Windows.Forms.Panel();
            this.PlayerHand2Sum = new System.Windows.Forms.Label();
            this.PlayerHand2Count = new System.Windows.Forms.Label();
            this.PlayerHand1Sum = new System.Windows.Forms.Label();
            this.PlayerHand1Count = new System.Windows.Forms.Label();
            this.PlayerHands = new System.Windows.Forms.Label();
            this.HouseBetPanel = new System.Windows.Forms.Panel();
            this.HouseWager = new System.Windows.Forms.Label();
            this.HouseWagerLabel = new System.Windows.Forms.Label();
            this.HouseBetLabel = new System.Windows.Forms.Label();
            this.HouseBet = new System.Windows.Forms.Label();
            this.Rule2Label = new System.Windows.Forms.Label();
            this.Rule1Label = new System.Windows.Forms.Label();
            this.HouseLabel = new System.Windows.Forms.Label();
            this.HouseSumPanel = new System.Windows.Forms.Panel();
            this.HouseHand2Count = new System.Windows.Forms.Label();
            this.HouseHand1Count = new System.Windows.Forms.Label();
            this.HouseHand2Sum = new System.Windows.Forms.Label();
            this.HouseHand1Sum = new System.Windows.Forms.Label();
            this.HouseHands = new System.Windows.Forms.Label();
            this.HouseHandPanel = new System.Windows.Forms.Panel();
            this.UserHandPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.TimingPanel.SuspendLayout();
            this.UserBetPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.GameControlPanel.SuspendLayout();
            this.UserStatPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.DeckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardBack)).BeginInit();
            this.MiddlePanel.SuspendLayout();
            this.UserSumPanel.SuspendLayout();
            this.HouseBetPanel.SuspendLayout();
            this.HouseSumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanel.Controls.Add(this.TimingPanel);
            this.LeftPanel.Controls.Add(this.UserBetPanel);
            this.LeftPanel.Location = new System.Drawing.Point(12, 12);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 680);
            this.LeftPanel.TabIndex = 0;
            // 
            // TimingPanel
            // 
            this.TimingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimingPanel.Controls.Add(this.Seconds);
            this.TimingPanel.Controls.Add(this.TimeLabel);
            this.TimingPanel.Controls.Add(this.DateLabel);
            this.TimingPanel.Location = new System.Drawing.Point(-1, 302);
            this.TimingPanel.Name = "TimingPanel";
            this.TimingPanel.Size = new System.Drawing.Size(200, 74);
            this.TimingPanel.TabIndex = 1;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.Location = new System.Drawing.Point(101, 41);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(24, 25);
            this.Seconds.TabIndex = 2;
            this.Seconds.Text = "s";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TimeLabel.Location = new System.Drawing.Point(60, 35);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 31);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "60";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(198, 25);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "08/09/2018";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBetPanel
            // 
            this.UserBetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserBetPanel.Controls.Add(this.AutoBetButton);
            this.UserBetPanel.Controls.Add(this.BetButton);
            this.UserBetPanel.Controls.Add(this.PlayerWager);
            this.UserBetPanel.Controls.Add(this.UserWagerLabel);
            this.UserBetPanel.Controls.Add(this.UserBetLabel);
            this.UserBetPanel.Controls.Add(this.PlayerBet);
            this.UserBetPanel.Controls.Add(this.PlayerName);
            this.UserBetPanel.Location = new System.Drawing.Point(-1, 379);
            this.UserBetPanel.Name = "UserBetPanel";
            this.UserBetPanel.Size = new System.Drawing.Size(200, 300);
            this.UserBetPanel.TabIndex = 0;
            // 
            // AutoBetButton
            // 
            this.AutoBetButton.Location = new System.Drawing.Point(111, 256);
            this.AutoBetButton.Name = "AutoBetButton";
            this.AutoBetButton.Size = new System.Drawing.Size(75, 23);
            this.AutoBetButton.TabIndex = 6;
            this.AutoBetButton.Text = "Auto Bet";
            this.AutoBetButton.UseVisualStyleBackColor = true;
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(11, 256);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 5;
            this.BetButton.Text = "Place A Bet";
            this.BetButton.UseVisualStyleBackColor = true;
            // 
            // PlayerWager
            // 
            this.PlayerWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWager.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerWager.Location = new System.Drawing.Point(-1, 183);
            this.PlayerWager.Name = "PlayerWager";
            this.PlayerWager.Size = new System.Drawing.Size(199, 42);
            this.PlayerWager.TabIndex = 4;
            this.PlayerWager.Text = "0";
            this.PlayerWager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserWagerLabel
            // 
            this.UserWagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWagerLabel.Location = new System.Drawing.Point(-1, 170);
            this.UserWagerLabel.Name = "UserWagerLabel";
            this.UserWagerLabel.Size = new System.Drawing.Size(200, 13);
            this.UserWagerLabel.TabIndex = 3;
            this.UserWagerLabel.Text = "WAGER";
            this.UserWagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBetLabel
            // 
            this.UserBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBetLabel.Location = new System.Drawing.Point(-1, 69);
            this.UserBetLabel.Name = "UserBetLabel";
            this.UserBetLabel.Size = new System.Drawing.Size(200, 13);
            this.UserBetLabel.TabIndex = 2;
            this.UserBetLabel.Text = "BET";
            this.UserBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerBet
            // 
            this.PlayerBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBet.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerBet.Location = new System.Drawing.Point(-1, 82);
            this.PlayerBet.Name = "PlayerBet";
            this.PlayerBet.Size = new System.Drawing.Size(200, 73);
            this.PlayerBet.TabIndex = 1;
            this.PlayerBet.Text = "0";
            this.PlayerBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerName
            // 
            this.PlayerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PlayerName.Location = new System.Drawing.Point(0, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(198, 25);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "PLAYER NAME";
            this.PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightPanel
            // 
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Controls.Add(this.GameControlPanel);
            this.RightPanel.Controls.Add(this.UserStatPanel);
            this.RightPanel.Controls.Add(this.DeckPanel);
            this.RightPanel.Location = new System.Drawing.Point(1092, 12);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(200, 680);
            this.RightPanel.TabIndex = 1;
            // 
            // GameControlPanel
            // 
            this.GameControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameControlPanel.Controls.Add(this.QuitButton);
            this.GameControlPanel.Controls.Add(this.SurrenderButton);
            this.GameControlPanel.Controls.Add(this.StartButton);
            this.GameControlPanel.Location = new System.Drawing.Point(-1, 605);
            this.GameControlPanel.Name = "GameControlPanel";
            this.GameControlPanel.Size = new System.Drawing.Size(200, 74);
            this.GameControlPanel.TabIndex = 2;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.QuitButton.Location = new System.Drawing.Point(120, 46);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            // 
            // SurrenderButton
            // 
            this.SurrenderButton.BackColor = System.Drawing.Color.OrangeRed;
            this.SurrenderButton.Enabled = false;
            this.SurrenderButton.Location = new System.Drawing.Point(3, 46);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(75, 23);
            this.SurrenderButton.TabIndex = 1;
            this.SurrenderButton.Text = "Surrender";
            this.SurrenderButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(27, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 37);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START GAME";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // UserStatPanel
            // 
            this.UserStatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserStatPanel.Controls.Add(this.ControlPanel);
            this.UserStatPanel.Controls.Add(this.PlayerStreak);
            this.UserStatPanel.Controls.Add(this.StreakLabel);
            this.UserStatPanel.Controls.Add(this.BalanceLabel);
            this.UserStatPanel.Controls.Add(this.PlayerBalance);
            this.UserStatPanel.Location = new System.Drawing.Point(-1, 338);
            this.UserStatPanel.Name = "UserStatPanel";
            this.UserStatPanel.Size = new System.Drawing.Size(200, 264);
            this.UserStatPanel.TabIndex = 1;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.DoubleButton);
            this.ControlPanel.Controls.Add(this.HitButton);
            this.ControlPanel.Controls.Add(this.StandButton);
            this.ControlPanel.Controls.Add(this.SplitButton);
            this.ControlPanel.Location = new System.Drawing.Point(-1, 163);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(200, 100);
            this.ControlPanel.TabIndex = 7;
            // 
            // DoubleButton
            // 
            this.DoubleButton.Enabled = false;
            this.DoubleButton.Location = new System.Drawing.Point(13, 61);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(75, 23);
            this.DoubleButton.TabIndex = 3;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = true;
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(107, 13);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 23);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(13, 13);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 1;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            // 
            // SplitButton
            // 
            this.SplitButton.Enabled = false;
            this.SplitButton.Location = new System.Drawing.Point(107, 61);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(75, 23);
            this.SplitButton.TabIndex = 0;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            // 
            // PlayerStreak
            // 
            this.PlayerStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStreak.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerStreak.Location = new System.Drawing.Point(-1, 111);
            this.PlayerStreak.Name = "PlayerStreak";
            this.PlayerStreak.Size = new System.Drawing.Size(200, 42);
            this.PlayerStreak.TabIndex = 6;
            this.PlayerStreak.Text = "0";
            this.PlayerStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreakLabel
            // 
            this.StreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreakLabel.Location = new System.Drawing.Point(-1, 98);
            this.StreakLabel.Name = "StreakLabel";
            this.StreakLabel.Size = new System.Drawing.Size(200, 13);
            this.StreakLabel.TabIndex = 5;
            this.StreakLabel.Text = "Current Streak";
            this.StreakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(-1, 17);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(200, 13);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "BALANCE";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerBalance
            // 
            this.PlayerBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerBalance.Location = new System.Drawing.Point(-1, 26);
            this.PlayerBalance.Name = "PlayerBalance";
            this.PlayerBalance.Size = new System.Drawing.Size(200, 55);
            this.PlayerBalance.TabIndex = 3;
            this.PlayerBalance.Text = "0";
            this.PlayerBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeckPanel
            // 
            this.DeckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeckPanel.Controls.Add(this.CardBack);
            this.DeckPanel.Controls.Add(this.CardCount);
            this.DeckPanel.Location = new System.Drawing.Point(-1, -1);
            this.DeckPanel.Name = "DeckPanel";
            this.DeckPanel.Size = new System.Drawing.Size(200, 340);
            this.DeckPanel.TabIndex = 0;
            // 
            // CardBack
            // 
            this.CardBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardBack.Image = global::AutoJack.Properties.Resources.cardback;
            this.CardBack.Location = new System.Drawing.Point(0, 31);
            this.CardBack.Name = "CardBack";
            this.CardBack.Size = new System.Drawing.Size(198, 307);
            this.CardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardBack.TabIndex = 1;
            this.CardBack.TabStop = false;
            // 
            // CardCount
            // 
            this.CardCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCount.ForeColor = System.Drawing.Color.DarkRed;
            this.CardCount.Location = new System.Drawing.Point(0, 0);
            this.CardCount.Name = "CardCount";
            this.CardCount.Size = new System.Drawing.Size(198, 31);
            this.CardCount.TabIndex = 0;
            this.CardCount.Text = "52";
            this.CardCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddlePanel.Controls.Add(this.UserSumPanel);
            this.MiddlePanel.Location = new System.Drawing.Point(218, 12);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(868, 680);
            this.MiddlePanel.TabIndex = 2;
            // 
            // UserSumPanel
            // 
            this.UserSumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserSumPanel.Controls.Add(this.PlayerHand2Sum);
            this.UserSumPanel.Controls.Add(this.PlayerHand2Count);
            this.UserSumPanel.Controls.Add(this.PlayerHand1Sum);
            this.UserSumPanel.Controls.Add(this.PlayerHand1Count);
            this.UserSumPanel.Controls.Add(this.PlayerHands);
            this.UserSumPanel.Location = new System.Drawing.Point(-1, 649);
            this.UserSumPanel.Name = "UserSumPanel";
            this.UserSumPanel.Size = new System.Drawing.Size(868, 30);
            this.UserSumPanel.TabIndex = 0;
            // 
            // PlayerHand2Sum
            // 
            this.PlayerHand2Sum.AutoSize = true;
            this.PlayerHand2Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHand2Sum.Location = new System.Drawing.Point(769, 9);
            this.PlayerHand2Sum.Name = "PlayerHand2Sum";
            this.PlayerHand2Sum.Size = new System.Drawing.Size(94, 13);
            this.PlayerHand2Sum.TabIndex = 4;
            this.PlayerHand2Sum.Text = "Hand2 Sum: 21";
            // 
            // PlayerHand2Count
            // 
            this.PlayerHand2Count.AutoSize = true;
            this.PlayerHand2Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHand2Count.Location = new System.Drawing.Point(573, 9);
            this.PlayerHand2Count.Name = "PlayerHand2Count";
            this.PlayerHand2Count.Size = new System.Drawing.Size(96, 13);
            this.PlayerHand2Count.TabIndex = 3;
            this.PlayerHand2Count.Text = "Hand2 Count: 3";
            // 
            // PlayerHand1Sum
            // 
            this.PlayerHand1Sum.AutoSize = true;
            this.PlayerHand1Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHand1Sum.Location = new System.Drawing.Point(359, 9);
            this.PlayerHand1Sum.Name = "PlayerHand1Sum";
            this.PlayerHand1Sum.Size = new System.Drawing.Size(90, 13);
            this.PlayerHand1Sum.TabIndex = 2;
            this.PlayerHand1Sum.Text = "Hand1Sum: 15";
            // 
            // PlayerHand1Count
            // 
            this.PlayerHand1Count.AutoSize = true;
            this.PlayerHand1Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHand1Count.Location = new System.Drawing.Point(163, 9);
            this.PlayerHand1Count.Name = "PlayerHand1Count";
            this.PlayerHand1Count.Size = new System.Drawing.Size(96, 13);
            this.PlayerHand1Count.TabIndex = 1;
            this.PlayerHand1Count.Text = "Hand1 Count: 2";
            // 
            // PlayerHands
            // 
            this.PlayerHands.AutoSize = true;
            this.PlayerHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHands.Location = new System.Drawing.Point(3, 9);
            this.PlayerHands.Name = "PlayerHands";
            this.PlayerHands.Size = new System.Drawing.Size(58, 13);
            this.PlayerHands.TabIndex = 0;
            this.PlayerHands.Text = "Hands: 2";
            // 
            // HouseBetPanel
            // 
            this.HouseBetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HouseBetPanel.Controls.Add(this.HouseWager);
            this.HouseBetPanel.Controls.Add(this.HouseWagerLabel);
            this.HouseBetPanel.Controls.Add(this.HouseBetLabel);
            this.HouseBetPanel.Controls.Add(this.HouseBet);
            this.HouseBetPanel.Controls.Add(this.Rule2Label);
            this.HouseBetPanel.Controls.Add(this.Rule1Label);
            this.HouseBetPanel.Controls.Add(this.HouseLabel);
            this.HouseBetPanel.Location = new System.Drawing.Point(12, 12);
            this.HouseBetPanel.Name = "HouseBetPanel";
            this.HouseBetPanel.Size = new System.Drawing.Size(200, 300);
            this.HouseBetPanel.TabIndex = 0;
            // 
            // HouseWager
            // 
            this.HouseWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseWager.ForeColor = System.Drawing.Color.DarkRed;
            this.HouseWager.Location = new System.Drawing.Point(-1, 237);
            this.HouseWager.Name = "HouseWager";
            this.HouseWager.Size = new System.Drawing.Size(200, 42);
            this.HouseWager.TabIndex = 8;
            this.HouseWager.Text = "0";
            this.HouseWager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HouseWagerLabel
            // 
            this.HouseWagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseWagerLabel.Location = new System.Drawing.Point(-1, 224);
            this.HouseWagerLabel.Name = "HouseWagerLabel";
            this.HouseWagerLabel.Size = new System.Drawing.Size(200, 13);
            this.HouseWagerLabel.TabIndex = 7;
            this.HouseWagerLabel.Text = "WAGER";
            this.HouseWagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HouseBetLabel
            // 
            this.HouseBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseBetLabel.Location = new System.Drawing.Point(-1, 123);
            this.HouseBetLabel.Name = "HouseBetLabel";
            this.HouseBetLabel.Size = new System.Drawing.Size(200, 13);
            this.HouseBetLabel.TabIndex = 6;
            this.HouseBetLabel.Text = "BET";
            this.HouseBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HouseBet
            // 
            this.HouseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseBet.ForeColor = System.Drawing.Color.DarkRed;
            this.HouseBet.Location = new System.Drawing.Point(-1, 136);
            this.HouseBet.Name = "HouseBet";
            this.HouseBet.Size = new System.Drawing.Size(200, 73);
            this.HouseBet.TabIndex = 5;
            this.HouseBet.Text = "0";
            this.HouseBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rule2Label
            // 
            this.Rule2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rule2Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Rule2Label.Location = new System.Drawing.Point(-1, 75);
            this.Rule2Label.Name = "Rule2Label";
            this.Rule2Label.Size = new System.Drawing.Size(200, 20);
            this.Rule2Label.TabIndex = 2;
            this.Rule2Label.Text = "Insurance: Pay 2 to 1";
            this.Rule2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rule1Label
            // 
            this.Rule1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rule1Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Rule1Label.Location = new System.Drawing.Point(-1, 48);
            this.Rule1Label.Name = "Rule1Label";
            this.Rule1Label.Size = new System.Drawing.Size(200, 20);
            this.Rule1Label.TabIndex = 1;
            this.Rule1Label.Text = "Black Jack: Pay 3 to 2";
            this.Rule1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HouseLabel
            // 
            this.HouseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HouseLabel.Location = new System.Drawing.Point(0, 0);
            this.HouseLabel.Name = "HouseLabel";
            this.HouseLabel.Size = new System.Drawing.Size(198, 25);
            this.HouseLabel.TabIndex = 0;
            this.HouseLabel.Text = "THE HOUSE";
            this.HouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HouseSumPanel
            // 
            this.HouseSumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HouseSumPanel.Controls.Add(this.HouseHand2Count);
            this.HouseSumPanel.Controls.Add(this.HouseHand1Count);
            this.HouseSumPanel.Controls.Add(this.HouseHand2Sum);
            this.HouseSumPanel.Controls.Add(this.HouseHand1Sum);
            this.HouseSumPanel.Controls.Add(this.HouseHands);
            this.HouseSumPanel.Location = new System.Drawing.Point(218, 12);
            this.HouseSumPanel.Name = "HouseSumPanel";
            this.HouseSumPanel.Size = new System.Drawing.Size(868, 30);
            this.HouseSumPanel.TabIndex = 0;
            // 
            // HouseHand2Count
            // 
            this.HouseHand2Count.AutoSize = true;
            this.HouseHand2Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHand2Count.Location = new System.Drawing.Point(573, 8);
            this.HouseHand2Count.Name = "HouseHand2Count";
            this.HouseHand2Count.Size = new System.Drawing.Size(96, 13);
            this.HouseHand2Count.TabIndex = 4;
            this.HouseHand2Count.Text = "Hand2 Count: 3";
            // 
            // HouseHand1Count
            // 
            this.HouseHand1Count.AutoSize = true;
            this.HouseHand1Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHand1Count.Location = new System.Drawing.Point(163, 8);
            this.HouseHand1Count.Name = "HouseHand1Count";
            this.HouseHand1Count.Size = new System.Drawing.Size(96, 13);
            this.HouseHand1Count.TabIndex = 3;
            this.HouseHand1Count.Text = "Hand1 Count: 2";
            // 
            // HouseHand2Sum
            // 
            this.HouseHand2Sum.AutoSize = true;
            this.HouseHand2Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHand2Sum.Location = new System.Drawing.Point(769, 8);
            this.HouseHand2Sum.Name = "HouseHand2Sum";
            this.HouseHand2Sum.Size = new System.Drawing.Size(94, 13);
            this.HouseHand2Sum.TabIndex = 2;
            this.HouseHand2Sum.Text = "Hand2 Sum: 18";
            // 
            // HouseHand1Sum
            // 
            this.HouseHand1Sum.AutoSize = true;
            this.HouseHand1Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHand1Sum.Location = new System.Drawing.Point(359, 8);
            this.HouseHand1Sum.Name = "HouseHand1Sum";
            this.HouseHand1Sum.Size = new System.Drawing.Size(94, 13);
            this.HouseHand1Sum.TabIndex = 1;
            this.HouseHand1Sum.Text = "Hand1 Sum: 19";
            // 
            // HouseHands
            // 
            this.HouseHands.AutoSize = true;
            this.HouseHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseHands.Location = new System.Drawing.Point(3, 8);
            this.HouseHands.Name = "HouseHands";
            this.HouseHands.Size = new System.Drawing.Size(58, 13);
            this.HouseHands.TabIndex = 0;
            this.HouseHands.Text = "Hands: 2";
            // 
            // HouseHandPanel
            // 
            this.HouseHandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HouseHandPanel.Location = new System.Drawing.Point(218, 45);
            this.HouseHandPanel.Name = "HouseHandPanel";
            this.HouseHandPanel.Size = new System.Drawing.Size(868, 307);
            this.HouseHandPanel.TabIndex = 1;
            // 
            // UserHandPanel
            // 
            this.UserHandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserHandPanel.Location = new System.Drawing.Point(218, 351);
            this.UserHandPanel.Name = "UserHandPanel";
            this.UserHandPanel.Size = new System.Drawing.Size(868, 307);
            this.UserHandPanel.TabIndex = 1;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1304, 704);
            this.ControlBox = false;
            this.Controls.Add(this.UserHandPanel);
            this.Controls.Add(this.HouseHandPanel);
            this.Controls.Add(this.HouseSumPanel);
            this.Controls.Add(this.HouseBetPanel);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.KeyPreview = true;
            this.Name = "GameView";
            this.Text = "AutoJack: Game Play";
            this.LeftPanel.ResumeLayout(false);
            this.TimingPanel.ResumeLayout(false);
            this.TimingPanel.PerformLayout();
            this.UserBetPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.GameControlPanel.ResumeLayout(false);
            this.UserStatPanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.DeckPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardBack)).EndInit();
            this.MiddlePanel.ResumeLayout(false);
            this.UserSumPanel.ResumeLayout(false);
            this.UserSumPanel.PerformLayout();
            this.HouseBetPanel.ResumeLayout(false);
            this.HouseSumPanel.ResumeLayout(false);
            this.HouseSumPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Panel TimingPanel;
        private System.Windows.Forms.Panel UserBetPanel;
        private System.Windows.Forms.Panel GameControlPanel;
        private System.Windows.Forms.Panel UserStatPanel;
        private System.Windows.Forms.Panel DeckPanel;
        private System.Windows.Forms.Panel UserSumPanel;
        private System.Windows.Forms.Panel HouseBetPanel;
        private System.Windows.Forms.Panel HouseSumPanel;
        private System.Windows.Forms.Panel HouseHandPanel;
        private System.Windows.Forms.Panel UserHandPanel;
        private System.Windows.Forms.PictureBox CardBack;
        private System.Windows.Forms.Label CardCount;
        private System.Windows.Forms.Label HouseHand2Sum;
        private System.Windows.Forms.Label HouseHand1Sum;
        private System.Windows.Forms.Label HouseHands;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerWager;
        private System.Windows.Forms.Label UserWagerLabel;
        private System.Windows.Forms.Label UserBetLabel;
        private System.Windows.Forms.Label PlayerBet;
        private System.Windows.Forms.Button SurrenderButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Rule2Label;
        private System.Windows.Forms.Label Rule1Label;
        private System.Windows.Forms.Label HouseLabel;
        private System.Windows.Forms.Label HouseHand2Count;
        private System.Windows.Forms.Label HouseHand1Count;
        private System.Windows.Forms.Button AutoBetButton;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Label PlayerHand2Sum;
        private System.Windows.Forms.Label PlayerHand2Count;
        private System.Windows.Forms.Label PlayerHand1Sum;
        private System.Windows.Forms.Label PlayerHand1Count;
        private System.Windows.Forms.Label PlayerHands;
        private System.Windows.Forms.Label HouseWager;
        private System.Windows.Forms.Label HouseWagerLabel;
        private System.Windows.Forms.Label HouseBetLabel;
        private System.Windows.Forms.Label HouseBet;
        private System.Windows.Forms.Label PlayerStreak;
        private System.Windows.Forms.Label StreakLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label PlayerBalance;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button DoubleButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.Button QuitButton;
    }
}