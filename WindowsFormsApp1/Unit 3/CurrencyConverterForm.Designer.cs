namespace WindowsFormsApp1.Unit_3
{
    partial class CurrencyconverterForm
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
            this.poundsBox = new System.Windows.Forms.TextBox();
            this.UKPounds = new System.Windows.Forms.Label();
            this.convertAmount = new System.Windows.Forms.Label();
            this.converterBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioRupees = new System.Windows.Forms.RadioButton();
            this.radioEuros = new System.Windows.Forms.RadioButton();
            this.radioDollars = new System.Windows.Forms.RadioButton();
            this.quitButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // poundsBox
            // 
            this.poundsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.poundsBox.Location = new System.Drawing.Point(376, 148);
            this.poundsBox.Name = "poundsBox";
            this.poundsBox.Size = new System.Drawing.Size(120, 32);
            this.poundsBox.TabIndex = 0;
            // 
            // UKPounds
            // 
            this.UKPounds.AutoSize = true;
            this.UKPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UKPounds.Location = new System.Drawing.Point(110, 148);
            this.UKPounds.Name = "UKPounds";
            this.UKPounds.Size = new System.Drawing.Size(140, 29);
            this.UKPounds.TabIndex = 1;
            this.UKPounds.Text = "UK Pounds:";
            // 
            // convertAmount
            // 
            this.convertAmount.AutoSize = true;
            this.convertAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.convertAmount.Location = new System.Drawing.Point(110, 215);
            this.convertAmount.Name = "convertAmount";
            this.convertAmount.Size = new System.Drawing.Size(217, 29);
            this.convertAmount.TabIndex = 2;
            this.convertAmount.Text = "Converted Amount:";
            // 
            // converterBox
            // 
            this.converterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.converterBox.Location = new System.Drawing.Point(376, 215);
            this.converterBox.Name = "converterBox";
            this.converterBox.Size = new System.Drawing.Size(120, 32);
            this.converterBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(120, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(549, 46);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Georgia\'s Currency Converter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(127, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioRupees);
            this.panel2.Controls.Add(this.radioEuros);
            this.panel2.Controls.Add(this.radioDollars);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(709, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 233);
            this.panel2.TabIndex = 6;
            // 
            // radioRupees
            // 
            this.radioRupees.AutoSize = true;
            this.radioRupees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioRupees.Location = new System.Drawing.Point(14, 144);
            this.radioRupees.Name = "radioRupees";
            this.radioRupees.Size = new System.Drawing.Size(121, 33);
            this.radioRupees.TabIndex = 2;
            this.radioRupees.TabStop = true;
            this.radioRupees.Text = "Rupees";
            this.radioRupees.UseVisualStyleBackColor = true;
            this.radioRupees.CheckedChanged += new System.EventHandler(this.radioRupees_CheckedChanged);
            // 
            // radioEuros
            // 
            this.radioEuros.AutoSize = true;
            this.radioEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioEuros.Location = new System.Drawing.Point(14, 83);
            this.radioEuros.Name = "radioEuros";
            this.radioEuros.Size = new System.Drawing.Size(100, 33);
            this.radioEuros.TabIndex = 1;
            this.radioEuros.TabStop = true;
            this.radioEuros.Text = "Euros";
            this.radioEuros.UseVisualStyleBackColor = true;
            this.radioEuros.CheckedChanged += new System.EventHandler(this.radioEuros_CheckedChanged);
            // 
            // radioDollars
            // 
            this.radioDollars.AutoSize = true;
            this.radioDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioDollars.Location = new System.Drawing.Point(14, 25);
            this.radioDollars.Name = "radioDollars";
            this.radioDollars.Size = new System.Drawing.Size(113, 33);
            this.radioDollars.TabIndex = 0;
            this.radioDollars.TabStop = true;
            this.radioDollars.Text = "Dollars";
            this.radioDollars.UseVisualStyleBackColor = true;
            this.radioDollars.CheckedChanged += new System.EventHandler(this.radioDollars_CheckedChanged);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitButton.Location = new System.Drawing.Point(740, 400);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(152, 50);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // currencyconverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1025, 487);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.converterBox);
            this.Controls.Add(this.convertAmount);
            this.Controls.Add(this.UKPounds);
            this.Controls.Add(this.poundsBox);
            this.Name = "currencyconverterForm";
            this.Text = "Georgia\'s Currency Converter";
            this.Load += new System.EventHandler(this.currencyconverterForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poundsBox;
        private System.Windows.Forms.Label UKPounds;
        private System.Windows.Forms.Label convertAmount;
        private System.Windows.Forms.TextBox converterBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioRupees;
        private System.Windows.Forms.RadioButton radioEuros;
        private System.Windows.Forms.RadioButton radioDollars;
        private System.Windows.Forms.Button quitButton;
    }
}