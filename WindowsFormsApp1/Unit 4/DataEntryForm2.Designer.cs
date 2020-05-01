namespace WindowsFormsApp1
{
    partial class DataEntryForm2
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
            this.detailsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.universityCombo = new System.Windows.Forms.ComboBox();
            this.quitForm = new System.Windows.Forms.Button();
            this.billForm = new System.Windows.Forms.Button();
            this.totalsForm = new System.Windows.Forms.Button();
            this.radioDinner = new System.Windows.Forms.RadioButton();
            this.radioLunch = new System.Windows.Forms.RadioButton();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailsLabel
            // 
            this.detailsLabel.BackColor = System.Drawing.Color.DeepPink;
            this.detailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.detailsLabel.Location = new System.Drawing.Point(12, 34);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(338, 34);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Attendee Details Data Form";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(22, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 27);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Attendee Name:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameBox.Location = new System.Drawing.Point(223, 133);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(256, 30);
            this.nameBox.TabIndex = 3;
            // 
            // universityCombo
            // 
            this.universityCombo.BackColor = System.Drawing.Color.Yellow;
            this.universityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.universityCombo.FormattingEnabled = true;
            this.universityCombo.Items.AddRange(new object[] {
            "University of Cambridge",
            "University of Oxford",
            "University of Leeds"});
            this.universityCombo.Location = new System.Drawing.Point(590, 130);
            this.universityCombo.Name = "universityCombo";
            this.universityCombo.Size = new System.Drawing.Size(269, 33);
            this.universityCombo.TabIndex = 5;
            this.universityCombo.Text = "Choose University";
            // 
            // quitForm
            // 
            this.quitForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(794, 563);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(134, 37);
            this.quitForm.TabIndex = 8;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = false;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // billForm
            // 
            this.billForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.billForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billForm.Location = new System.Drawing.Point(530, 565);
            this.billForm.Name = "billForm";
            this.billForm.Size = new System.Drawing.Size(140, 37);
            this.billForm.TabIndex = 9;
            this.billForm.Text = "Check Bill";
            this.billForm.UseVisualStyleBackColor = false;
            this.billForm.Click += new System.EventHandler(this.showBill);
            // 
            // totalsForm
            // 
            this.totalsForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalsForm.Location = new System.Drawing.Point(293, 565);
            this.totalsForm.Name = "totalsForm";
            this.totalsForm.Size = new System.Drawing.Size(147, 37);
            this.totalsForm.TabIndex = 10;
            this.totalsForm.Text = "Totals";
            this.totalsForm.UseVisualStyleBackColor = false;
            this.totalsForm.Click += new System.EventHandler(this.showTotal);
            // 
            // radioDinner
            // 
            this.radioDinner.AutoSize = true;
            this.radioDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioDinner.Location = new System.Drawing.Point(36, 316);
            this.radioDinner.Name = "radioDinner";
            this.radioDinner.Size = new System.Drawing.Size(108, 33);
            this.radioDinner.TabIndex = 11;
            this.radioDinner.TabStop = true;
            this.radioDinner.Text = "Dinner";
            this.radioDinner.UseVisualStyleBackColor = true;
            // 
            // radioLunch
            // 
            this.radioLunch.AutoSize = true;
            this.radioLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioLunch.Location = new System.Drawing.Point(36, 379);
            this.radioLunch.Name = "radioLunch";
            this.radioLunch.Size = new System.Drawing.Size(103, 33);
            this.radioLunch.TabIndex = 12;
            this.radioLunch.TabStop = true;
            this.radioLunch.Text = "Lunch";
            this.radioLunch.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.BackColor = System.Drawing.Color.Orange;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.optionsLabel.Location = new System.Drawing.Point(31, 254);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(191, 39);
            this.optionsLabel.TabIndex = 13;
            this.optionsLabel.Text = "Dining Options";
            // 
            // DataEntryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(976, 657);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.radioLunch);
            this.Controls.Add(this.radioDinner);
            this.Controls.Add(this.totalsForm);
            this.Controls.Add(this.billForm);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.universityCombo);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.detailsLabel);
            this.Name = "DataEntryForm2";
            this.Text = "DataEntryForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox universityCombo;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Button billForm;
        private System.Windows.Forms.Button totalsForm;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RadioButton radioDinner;
        private System.Windows.Forms.RadioButton radioLunch;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label optionsLabel;
    }
}