namespace AutoJack.View
{
    partial class EngineView
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
            this.AppLogo = new System.Windows.Forms.PictureBox();
            this.SelectPlayer = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AppLogo
            // 
            this.AppLogo.Image = global::AutoJack.Properties.Resources.AppLogo;
            this.AppLogo.Location = new System.Drawing.Point(12, 12);
            this.AppLogo.Margin = new System.Windows.Forms.Padding(0);
            this.AppLogo.Name = "AppLogo";
            this.AppLogo.Size = new System.Drawing.Size(920, 477);
            this.AppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppLogo.TabIndex = 0;
            this.AppLogo.TabStop = false;
            // 
            // SelectPlayer
            // 
            this.SelectPlayer.Location = new System.Drawing.Point(349, 445);
            this.SelectPlayer.Name = "SelectPlayer";
            this.SelectPlayer.Size = new System.Drawing.Size(100, 29);
            this.SelectPlayer.TabIndex = 1;
            this.SelectPlayer.Text = "Select Player";
            this.SelectPlayer.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(491, 445);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 29);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit App";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // EngineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectPlayer);
            this.Controls.Add(this.AppLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EngineView";
            this.Text = "EngineView";
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox AppLogo;
        private System.Windows.Forms.Button SelectPlayer;
        private System.Windows.Forms.Button ExitButton;
    }
}