namespace WindowsFormsApp1
{
    partial class SplashscreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashscreenForm));
            this.clickCalculator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickCalculator
            // 
            this.clickCalculator.AutoSize = true;
            this.clickCalculator.BackColor = System.Drawing.Color.White;
            this.clickCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clickCalculator.ForeColor = System.Drawing.Color.Black;
            this.clickCalculator.Location = new System.Drawing.Point(39, 29);
            this.clickCalculator.Name = "clickCalculator";
            this.clickCalculator.Size = new System.Drawing.Size(251, 29);
            this.clickCalculator.TabIndex = 0;
            this.clickCalculator.Text = "Click to use Calculator";
            this.clickCalculator.Click += new System.EventHandler(this.clickCalculator_Click);
            // 
            // splashscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 653);
            this.Controls.Add(this.clickCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashscreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen_Form";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickCalculator;
    }
}