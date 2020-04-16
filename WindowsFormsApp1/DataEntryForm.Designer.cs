namespace WindowsFormsApp1
{
    partial class DataEntryForm
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
            this.mainForm = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.surnamenameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.upperButton = new System.Windows.Forms.Button();
            this.lowerButton = new System.Windows.Forms.Button();
            this.changemessageButton = new System.Windows.Forms.Button();
            this.townBox = new System.Windows.Forms.TextBox();
            this.townLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainForm
            // 
            this.mainForm.AutoSize = true;
            this.mainForm.BackColor = System.Drawing.Color.Yellow;
            this.mainForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainForm.Location = new System.Drawing.Point(196, 9);
            this.mainForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(620, 47);
            this.mainForm.TabIndex = 0;
            this.mainForm.Text = "Georgia\'s Details Data Entry Form";
            this.mainForm.Click += new System.EventHandler(this.mainForm_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(839, 353);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(168, 53);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.firstnameLabel.Location = new System.Drawing.Point(235, 80);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(129, 27);
            this.firstnameLabel.TabIndex = 2;
            this.firstnameLabel.Text = "First Name";
            this.firstnameLabel.Click += new System.EventHandler(this.firstnameLabel_Click);
            // 
            // surnamenameLabel
            // 
            this.surnamenameLabel.AutoSize = true;
            this.surnamenameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.surnamenameLabel.Location = new System.Drawing.Point(235, 135);
            this.surnamenameLabel.Name = "surnamenameLabel";
            this.surnamenameLabel.Size = new System.Drawing.Size(110, 27);
            this.surnamenameLabel.TabIndex = 3;
            this.surnamenameLabel.Text = "Surname";
            this.surnamenameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Yellow;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.messageLabel.Location = new System.Drawing.Point(396, 251);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(110, 29);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Message";
            // 
            // firstnameBox
            // 
            this.firstnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnameBox.Font = new System.Drawing.Font("Arial", 14F);
            this.firstnameBox.Location = new System.Drawing.Point(438, 80);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(235, 34);
            this.firstnameBox.TabIndex = 5;
            this.firstnameBox.TextChanged += new System.EventHandler(this.firstnameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox.Font = new System.Drawing.Font("Arial", 14F);
            this.surnameBox.Location = new System.Drawing.Point(438, 135);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(235, 34);
            this.surnameBox.TabIndex = 6;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(316, 353);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(166, 55);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // messageButton
            // 
            this.messageButton.AutoSize = true;
            this.messageButton.Location = new System.Drawing.Point(60, 353);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(189, 55);
            this.messageButton.TabIndex = 8;
            this.messageButton.Text = "&Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // upperButton
            // 
            this.upperButton.Location = new System.Drawing.Point(50, 445);
            this.upperButton.Name = "upperButton";
            this.upperButton.Size = new System.Drawing.Size(240, 52);
            this.upperButton.TabIndex = 9;
            this.upperButton.Text = "Upper Case";
            this.upperButton.UseVisualStyleBackColor = true;
            this.upperButton.Click += new System.EventHandler(this.upperButton_Click);
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(768, 445);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(239, 48);
            this.lowerButton.TabIndex = 10;
            this.lowerButton.Text = "Lower Case";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // changemessageButton
            // 
            this.changemessageButton.Location = new System.Drawing.Point(554, 353);
            this.changemessageButton.Name = "changemessageButton";
            this.changemessageButton.Size = new System.Drawing.Size(201, 55);
            this.changemessageButton.TabIndex = 11;
            this.changemessageButton.Text = "Change";
            this.changemessageButton.UseVisualStyleBackColor = true;
            this.changemessageButton.Click += new System.EventHandler(this.changemessageButton_Click);
            // 
            // townBox
            // 
            this.townBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.townBox.Font = new System.Drawing.Font("Arial", 14F);
            this.townBox.Location = new System.Drawing.Point(438, 186);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(235, 34);
            this.townBox.TabIndex = 12;
            this.townBox.TextChanged += new System.EventHandler(this.townBox_TextChanged);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.townLabel.Location = new System.Drawing.Point(235, 188);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(67, 27);
            this.townLabel.TabIndex = 13;
            this.townLabel.Text = "Town";
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 520);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.townBox);
            this.Controls.Add(this.changemessageButton);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.upperButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.surnamenameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.mainForm);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "DataEntryForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DataEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainForm;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label surnamenameLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button upperButton;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.Button changemessageButton;
        private System.Windows.Forms.TextBox townBox;
        private System.Windows.Forms.Label townLabel;
    }
}