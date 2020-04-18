namespace WindowsFormsApp1
{
    partial class GameUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playForm = new System.Windows.Forms.Button();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.quitForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userPictureBox);
            this.groupBox1.Controls.Add(this.rockRadioButton);
            this.groupBox1.Controls.Add(this.paperRadioButton);
            this.groupBox1.Controls.Add(this.scissorsRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Choice";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(6, 51);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(228, 147);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rockRadioButton.Location = new System.Drawing.Point(6, 356);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(77, 29);
            this.rockRadioButton.TabIndex = 2;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = false;
            this.rockRadioButton.CheckedChanged += new System.EventHandler(this.rockForm_CheckedChanged);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.paperRadioButton.Location = new System.Drawing.Point(6, 321);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(85, 29);
            this.paperRadioButton.TabIndex = 1;
            this.paperRadioButton.TabStop = true;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = false;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.paperForm_CheckedChanged);
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.scissorsRadioButton.Location = new System.Drawing.Point(6, 286);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(108, 29);
            this.scissorsRadioButton.TabIndex = 0;
            this.scissorsRadioButton.TabStop = true;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = false;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.LoadScissorsImage);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playForm);
            this.groupBox2.Controls.Add(this.computerPictureBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Choice";
            // 
            // playForm
            // 
            this.playForm.Location = new System.Drawing.Point(63, 291);
            this.playForm.Name = "playForm";
            this.playForm.Size = new System.Drawing.Size(123, 45);
            this.playForm.TabIndex = 1;
            this.playForm.Text = "Play";
            this.playForm.UseVisualStyleBackColor = true;
            this.playForm.Click += new System.EventHandler(this.GetComputerChoice);
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(6, 51);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(227, 140);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 0;
            this.computerPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox3.Location = new System.Drawing.Point(568, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 292);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 102);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 25);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "label1";
            this.resultLabel.Click += new System.EventHandler(this.resultForm_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(610, 386);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(112, 48);
            this.quitForm.TabIndex = 3;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameUI";
            this.Text = "Georgia\'s Rock-Paper-Scissors Game";
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button playForm;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button quitForm;
    }
}