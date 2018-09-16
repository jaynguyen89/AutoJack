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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineView));
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectUser = new System.Windows.Forms.Button();
            this.AppLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).BeginInit();
            this.SuspendLayout();
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
            // SelectUser
            // 
            this.SelectUser.Location = new System.Drawing.Point(349, 445);
            this.SelectUser.Name = "SelectUser";
            this.SelectUser.Size = new System.Drawing.Size(100, 29);
            this.SelectUser.TabIndex = 1;
            this.SelectUser.Text = "Select Player";
            this.SelectUser.UseVisualStyleBackColor = true;
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
            // EngineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectUser);
            this.Controls.Add(this.AppLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EngineView";
            this.Text = "AutoJack: Home";
            ((System.ComponentModel.ISupportInitialize)(this.AppLogo)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SelectUser;
        private System.Windows.Forms.PictureBox AppLogo;
    }
}