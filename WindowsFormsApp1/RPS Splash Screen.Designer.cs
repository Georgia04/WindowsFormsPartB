namespace WindowsFormsApp1
{
    partial class RPSsplashscreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPSsplashscreenForm));
            this.clickGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickGame
            // 
            this.clickGame.AutoSize = true;
            this.clickGame.BackColor = System.Drawing.Color.Orange;
            this.clickGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clickGame.Location = new System.Drawing.Point(254, 311);
            this.clickGame.Name = "clickGame";
            this.clickGame.Size = new System.Drawing.Size(144, 29);
            this.clickGame.TabIndex = 0;
            this.clickGame.Text = "Click to Play";
            this.clickGame.Click += new System.EventHandler(this.clickGame_Click);
            // 
            // RPSsplashscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 462);
            this.Controls.Add(this.clickGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPSsplashscreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS_Splash_Screen Form";
            this.Load += new System.EventHandler(this.RPS_Splash_Screen_Load);
            this.Click += new System.EventHandler(this.RSPsplashscreenForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickGame;
    }
}