namespace AutoJack.View
{
    partial class NewUserView
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
            this.NewPLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPLabel.Location = new System.Drawing.Point(0, 0);
            this.NewPLabel.Name = "NewPLabel";
            this.NewPLabel.Size = new System.Drawing.Size(304, 22);
            this.NewPLabel.TabIndex = 0;
            this.NewPLabel.Text = "New Player";
            this.NewPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(12, 34);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(280, 20);
            this.NameInput.TabIndex = 1;
            this.NameInput.Text = "Your Name...";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 60);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(217, 60);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // NewUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 93);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NewPLabel);
            this.Name = "NewUserView";
            this.Text = "AutoJack";
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