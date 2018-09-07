namespace AutoJack.View
{
    partial class PlayerView
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
            this.NewPLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPLabel
            // 
            this.NewPLabel.AutoSize = true;
            this.NewPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPLabel.Location = new System.Drawing.Point(92, 9);
            this.NewPLabel.Name = "NewPLabel";
            this.NewPLabel.Size = new System.Drawing.Size(112, 22);
            this.NewPLabel.TabIndex = 0;
            this.NewPLabel.Text = "New Player";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(12, 48);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(280, 20);
            this.NameInput.TabIndex = 1;
            this.NameInput.Text = "Your Name...";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 74);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.OrangeRed;
            this.BackButton.Location = new System.Drawing.Point(217, 74);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // NewPlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 107);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NewPLabel);
            this.Name = "NewPlayerView";
            this.Text = "NewPlayerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button BackButton;
    }
}