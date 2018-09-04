namespace AutoJack.View
{
    partial class SelectView
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
            this.PlayersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinStreak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Games = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Owing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.NewPButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersList
            // 
            this.PlayersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PName,
            this.Balance,
            this.WinStreak,
            this.Wins,
            this.Loses,
            this.Games,
            this.Owing});
            this.PlayersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayersList.FullRowSelect = true;
            this.PlayersList.GridLines = true;
            this.PlayersList.Location = new System.Drawing.Point(12, 35);
            this.PlayersList.MultiSelect = false;
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(560, 222);
            this.PlayersList.TabIndex = 0;
            this.PlayersList.UseCompatibleStateImageBehavior = false;
            this.PlayersList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.DisplayIndex = 7;
            this.Id.Text = "ID";
            // 
            // PName
            // 
            this.PName.DisplayIndex = 0;
            this.PName.Text = "Name";
            // 
            // Balance
            // 
            this.Balance.DisplayIndex = 1;
            this.Balance.Text = "Balance";
            // 
            // WinStreak
            // 
            this.WinStreak.DisplayIndex = 2;
            this.WinStreak.Text = "Winstreak";
            // 
            // Wins
            // 
            this.Wins.DisplayIndex = 3;
            this.Wins.Text = "Wins";
            // 
            // Loses
            // 
            this.Loses.DisplayIndex = 4;
            this.Loses.Text = "Loses";
            // 
            // Games
            // 
            this.Games.DisplayIndex = 5;
            this.Games.Text = "Games";
            // 
            // Owing
            // 
            this.Owing.DisplayIndex = 6;
            this.Owing.Text = "Owing";
            // 
            // ListLabel
            // 
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.Location = new System.Drawing.Point(229, 9);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(129, 23);
            this.ListLabel.TabIndex = 1;
            this.ListLabel.Text = "Select Player";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 263);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // NewPButton
            // 
            this.NewPButton.Location = new System.Drawing.Point(93, 263);
            this.NewPButton.Name = "NewPButton";
            this.NewPButton.Size = new System.Drawing.Size(75, 23);
            this.NewPButton.TabIndex = 3;
            this.NewPButton.Text = "New Player";
            this.NewPButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.OrangeRed;
            this.BackButton.Location = new System.Drawing.Point(497, 263);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // SelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 298);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewPButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.PlayersList);
            this.Name = "SelectView";
            this.Text = "SelectView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PlayersList;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader WinStreak;
        private System.Windows.Forms.ColumnHeader Wins;
        private System.Windows.Forms.ColumnHeader Loses;
        private System.Windows.Forms.ColumnHeader Games;
        private System.Windows.Forms.ColumnHeader Owing;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button NewPButton;
        private System.Windows.Forms.Button BackButton;
    }
}