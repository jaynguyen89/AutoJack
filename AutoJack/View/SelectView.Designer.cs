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
            this.WinCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoseCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Owing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastPlay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.NewPButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PlayerDetails = new System.Windows.Forms.Button();
            this.DeletePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersList
            // 
            this.PlayersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PName,
            this.Balance,
            this.WinStreak,
            this.WinCount,
            this.LoseCount,
            this.Owing,
            this.LastPlay});
            this.PlayersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayersList.FullRowSelect = true;
            this.PlayersList.GridLines = true;
            this.PlayersList.Location = new System.Drawing.Point(12, 35);
            this.PlayersList.MultiSelect = false;
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(560, 223);
            this.PlayersList.TabIndex = 0;
            this.PlayersList.UseCompatibleStateImageBehavior = false;
            this.PlayersList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 35;
            // 
            // PName
            // 
            this.PName.Text = "Name";
            this.PName.Width = 100;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            // 
            // WinStreak
            // 
            this.WinStreak.Text = "Max Streak";
            this.WinStreak.Width = 66;
            // 
            // WinCount
            // 
            this.WinCount.Text = "Wins";
            this.WinCount.Width = 50;
            // 
            // LoseCount
            // 
            this.LoseCount.Text = "Loses";
            this.LoseCount.Width = 50;
            // 
            // Owing
            // 
            this.Owing.Text = "Owing";
            // 
            // LastPlay
            // 
            this.LastPlay.Text = "Last Play";
            this.LastPlay.Width = 118;
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
            this.OkButton.Location = new System.Drawing.Point(12, 264);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // NewPButton
            // 
            this.NewPButton.Location = new System.Drawing.Point(174, 264);
            this.NewPButton.Name = "NewPButton";
            this.NewPButton.Size = new System.Drawing.Size(75, 23);
            this.NewPButton.TabIndex = 3;
            this.NewPButton.Text = "New Player";
            this.NewPButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(497, 264);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Close";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // PlayerDetails
            // 
            this.PlayerDetails.Location = new System.Drawing.Point(93, 264);
            this.PlayerDetails.Name = "PlayerDetails";
            this.PlayerDetails.Size = new System.Drawing.Size(75, 23);
            this.PlayerDetails.TabIndex = 5;
            this.PlayerDetails.Text = "Details";
            this.PlayerDetails.UseVisualStyleBackColor = true;
            // 
            // DeletePlayer
            // 
            this.DeletePlayer.BackColor = System.Drawing.Color.OrangeRed;
            this.DeletePlayer.Location = new System.Drawing.Point(416, 264);
            this.DeletePlayer.Name = "DeletePlayer";
            this.DeletePlayer.Size = new System.Drawing.Size(75, 23);
            this.DeletePlayer.TabIndex = 6;
            this.DeletePlayer.Text = "Delete";
            this.DeletePlayer.UseVisualStyleBackColor = false;
            // 
            // SelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 299);
            this.ControlBox = false;
            this.Controls.Add(this.DeletePlayer);
            this.Controls.Add(this.PlayerDetails);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewPButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.PlayersList);
            this.Name = "SelectView";
            this.Text = "AutoJack: Select Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PlayersList;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button NewPButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader WinStreak;
        private System.Windows.Forms.ColumnHeader WinCount;
        private System.Windows.Forms.ColumnHeader LoseCount;
        private System.Windows.Forms.ColumnHeader Owing;
        private System.Windows.Forms.ColumnHeader LastPlay;
        private System.Windows.Forms.Button PlayerDetails;
        private System.Windows.Forms.Button DeletePlayer;
    }
}