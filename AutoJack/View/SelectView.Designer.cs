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
            this.UsersList = new System.Windows.Forms.ListView();
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
            this.UserDetails = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PName,
            this.Balance,
            this.WinStreak,
            this.WinCount,
            this.LoseCount,
            this.Owing,
            this.LastPlay});
            this.UsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersList.FullRowSelect = true;
            this.UsersList.GridLines = true;
            this.UsersList.Location = new System.Drawing.Point(12, 35);
            this.UsersList.MultiSelect = false;
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(560, 223);
            this.UsersList.TabIndex = 0;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.View = System.Windows.Forms.View.Details;
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
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(584, 23);
            this.ListLabel.TabIndex = 1;
            this.ListLabel.Text = "Select Player";
            this.ListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.NewPButton.Text = "New User";
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
            // UserDetails
            // 
            this.UserDetails.Location = new System.Drawing.Point(93, 264);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(75, 23);
            this.UserDetails.TabIndex = 5;
            this.UserDetails.Text = "Details";
            this.UserDetails.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteUser.Location = new System.Drawing.Point(416, 264);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.TabIndex = 6;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = false;
            // 
            // SelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 299);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewPButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.UsersList);
            this.Name = "SelectView";
            this.Text = "AutoJack: Select Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UsersList;
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
        private System.Windows.Forms.Button UserDetails;
        private System.Windows.Forms.Button DeleteUser;
    }
}