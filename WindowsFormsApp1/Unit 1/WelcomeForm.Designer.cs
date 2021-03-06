﻿namespace WindowsFormsApp1
{
    partial class WelcomeForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.bragLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.showBestSoftware = new System.Windows.Forms.Button();
            this.showBestComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.BackColor = System.Drawing.Color.Yellow;
            this.greetingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greetingLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greetingLabel.ForeColor = System.Drawing.Color.Blue;
            this.greetingLabel.Location = new System.Drawing.Point(100, 30);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(370, 40);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Welcome To Supersoft";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bragLabel
            // 
            this.bragLabel.BackColor = System.Drawing.Color.Yellow;
            this.bragLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bragLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bragLabel.ForeColor = System.Drawing.Color.Blue;
            this.bragLabel.Location = new System.Drawing.Point(100, 90);
            this.bragLabel.Name = "bragLabel";
            this.bragLabel.Size = new System.Drawing.Size(310, 70);
            this.bragLabel.TabIndex = 1;
            this.bragLabel.Text = "The Best Prices";
            this.bragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(779, 243);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(86, 40);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // showBestSoftware
            // 
            this.showBestSoftware.Location = new System.Drawing.Point(42, 243);
            this.showBestSoftware.Name = "showBestSoftware";
            this.showBestSoftware.Size = new System.Drawing.Size(180, 40);
            this.showBestSoftware.TabIndex = 3;
            this.showBestSoftware.Text = "Best Software";
            this.showBestSoftware.UseVisualStyleBackColor = true;
            this.showBestSoftware.Click += new System.EventHandler(this.showBestSoftware_Click_1);
            // 
            // showBestComputer
            // 
            this.showBestComputer.Location = new System.Drawing.Point(389, 243);
            this.showBestComputer.Name = "showBestComputer";
            this.showBestComputer.Size = new System.Drawing.Size(181, 40);
            this.showBestComputer.TabIndex = 4;
            this.showBestComputer.Text = "Best Computer";
            this.showBestComputer.UseVisualStyleBackColor = true;
            this.showBestComputer.Click += new System.EventHandler(this.showBestComputer_Click_1);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(892, 343);
            this.Controls.Add(this.showBestComputer);
            this.Controls.Add(this.showBestSoftware);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.bragLabel);
            this.Controls.Add(this.greetingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Georgia Welcome Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label bragLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button showBestSoftware;
        private System.Windows.Forms.Button showBestComputer;
    }
}

