namespace AutoJack.View
{
    partial class BetView
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
            this.label1 = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.BetInput = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceInput = new System.Windows.Forms.TextBox();
            this.ExplainLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Bet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(12, 125);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(23, 13);
            this.BetLabel.TabIndex = 1;
            this.BetLabel.Text = "Bet";
            // 
            // BetInput
            // 
            this.BetInput.Location = new System.Drawing.Point(64, 118);
            this.BetInput.Name = "BetInput";
            this.BetInput.Size = new System.Drawing.Size(228, 20);
            this.BetInput.TabIndex = 2;
            this.BetInput.Text = "Enter a number";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(15, 144);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(12, 89);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "Balance";
            // 
            // BalanceInput
            // 
            this.BalanceInput.Enabled = false;
            this.BalanceInput.Location = new System.Drawing.Point(64, 82);
            this.BalanceInput.Name = "BalanceInput";
            this.BalanceInput.Size = new System.Drawing.Size(228, 20);
            this.BalanceInput.TabIndex = 5;
            // 
            // ExplainLabel
            // 
            this.ExplainLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ExplainLabel.Location = new System.Drawing.Point(12, 32);
            this.ExplainLabel.Name = "ExplainLabel";
            this.ExplainLabel.Size = new System.Drawing.Size(280, 44);
            this.ExplainLabel.TabIndex = 6;
            this.ExplainLabel.Text = "Note: Bet is a positive number and lower than Balance. Bet should not be higher t" +
    "han 1000 if Balance is negative. Bet should be higher than 10% of Balance.";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CancelButton.Location = new System.Drawing.Point(217, 144);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // BetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 182);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExplainLabel);
            this.Controls.Add(this.BalanceInput);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.BetInput);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.label1);
            this.Name = "BetView";
            this.Text = "Bet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.TextBox BetInput;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox BalanceInput;
        private System.Windows.Forms.Label ExplainLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}