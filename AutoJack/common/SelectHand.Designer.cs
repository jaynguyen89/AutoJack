namespace AutoJack.common
{
    partial class SelectHand
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
            this.LeftRadio = new System.Windows.Forms.RadioButton();
            this.RightRadio = new System.Windows.Forms.RadioButton();
            this.DrawToLabel = new System.Windows.Forms.Label();
            this.LeftHandPhoto = new System.Windows.Forms.PictureBox();
            this.RiteHandPhoto = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftHandPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiteHandPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftRadio
            // 
            this.LeftRadio.AutoSize = true;
            this.LeftRadio.Location = new System.Drawing.Point(12, 30);
            this.LeftRadio.Name = "LeftRadio";
            this.LeftRadio.Size = new System.Drawing.Size(72, 17);
            this.LeftRadio.TabIndex = 0;
            this.LeftRadio.TabStop = true;
            this.LeftRadio.Text = "Left Hand";
            this.LeftRadio.UseVisualStyleBackColor = true;
            // 
            // RightRadio
            // 
            this.RightRadio.AutoSize = true;
            this.RightRadio.Location = new System.Drawing.Point(157, 30);
            this.RightRadio.Name = "RightRadio";
            this.RightRadio.Size = new System.Drawing.Size(79, 17);
            this.RightRadio.TabIndex = 1;
            this.RightRadio.TabStop = true;
            this.RightRadio.Text = "Right Hand";
            this.RightRadio.UseVisualStyleBackColor = true;
            // 
            // DrawToLabel
            // 
            this.DrawToLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrawToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawToLabel.Location = new System.Drawing.Point(0, 0);
            this.DrawToLabel.Name = "DrawToLabel";
            this.DrawToLabel.Size = new System.Drawing.Size(269, 20);
            this.DrawToLabel.TabIndex = 2;
            this.DrawToLabel.Text = "Draw to";
            this.DrawToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftHandPhoto
            // 
            this.LeftHandPhoto.Image = global::AutoJack.Properties.Resources.lefthand;
            this.LeftHandPhoto.Location = new System.Drawing.Point(12, 53);
            this.LeftHandPhoto.Name = "LeftHandPhoto";
            this.LeftHandPhoto.Size = new System.Drawing.Size(100, 100);
            this.LeftHandPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftHandPhoto.TabIndex = 3;
            this.LeftHandPhoto.TabStop = false;
            // 
            // RiteHandPhoto
            // 
            this.RiteHandPhoto.Image = global::AutoJack.Properties.Resources.ritehand;
            this.RiteHandPhoto.Location = new System.Drawing.Point(157, 53);
            this.RiteHandPhoto.Name = "RiteHandPhoto";
            this.RiteHandPhoto.Size = new System.Drawing.Size(100, 100);
            this.RiteHandPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RiteHandPhoto.TabIndex = 4;
            this.RiteHandPhoto.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(51, 170);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CancelButton.Location = new System.Drawing.Point(143, 170);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // SelectHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 205);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.RiteHandPhoto);
            this.Controls.Add(this.LeftHandPhoto);
            this.Controls.Add(this.DrawToLabel);
            this.Controls.Add(this.RightRadio);
            this.Controls.Add(this.LeftRadio);
            this.Name = "SelectHand";
            this.Text = "Select Hand";
            ((System.ComponentModel.ISupportInitialize)(this.LeftHandPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiteHandPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LeftRadio;
        private System.Windows.Forms.RadioButton RightRadio;
        private System.Windows.Forms.Label DrawToLabel;
        private System.Windows.Forms.PictureBox LeftHandPhoto;
        private System.Windows.Forms.PictureBox RiteHandPhoto;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}