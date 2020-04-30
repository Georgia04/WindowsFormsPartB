namespace WindowsFormsApp1
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
            this.currencyconverterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UKPounds = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioRupees = new System.Windows.Forms.RadioButton();
            this.radioEuros = new System.Windows.Forms.RadioButton();
            this.radioDollars = new System.Windows.Forms.RadioButton();
            this.quitButton = new System.Windows.Forms.Button();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.convertLabel = new System.Windows.Forms.Label();
            this.convertAmount = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyconverterLabel
            // 
            this.currencyconverterLabel.AutoSize = true;
            this.currencyconverterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.currencyconverterLabel.Location = new System.Drawing.Point(59, 46);
            this.currencyconverterLabel.Name = "currencyconverterLabel";
            this.currencyconverterLabel.Size = new System.Drawing.Size(513, 42);
            this.currencyconverterLabel.TabIndex = 0;
            this.currencyconverterLabel.Text = "Georgia\'s Currency Converter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(58, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 15);
            this.panel1.TabIndex = 1;
            // 
            // UKPounds
            // 
            this.UKPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UKPounds.Location = new System.Drawing.Point(384, 179);
            this.UKPounds.Name = "UKPounds";
            this.UKPounds.Size = new System.Drawing.Size(137, 30);
            this.UKPounds.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioRupees);
            this.panel2.Controls.Add(this.radioEuros);
            this.panel2.Controls.Add(this.radioDollars);
            this.panel2.Location = new System.Drawing.Point(651, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 281);
            this.panel2.TabIndex = 6;
            // 
            // radioRupees
            // 
            this.radioRupees.AutoSize = true;
            this.radioRupees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioRupees.Location = new System.Drawing.Point(24, 191);
            this.radioRupees.Name = "radioRupees";
            this.radioRupees.Size = new System.Drawing.Size(121, 33);
            this.radioRupees.TabIndex = 2;
            this.radioRupees.TabStop = true;
            this.radioRupees.Text = "Rupees";
            this.radioRupees.UseVisualStyleBackColor = true;
            this.radioRupees.CheckedChanged += new System.EventHandler(this.calculateRupees);
            // 
            // radioEuros
            // 
            this.radioEuros.AutoSize = true;
            this.radioEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioEuros.Location = new System.Drawing.Point(24, 117);
            this.radioEuros.Name = "radioEuros";
            this.radioEuros.Size = new System.Drawing.Size(100, 33);
            this.radioEuros.TabIndex = 1;
            this.radioEuros.TabStop = true;
            this.radioEuros.Text = "Euros";
            this.radioEuros.UseVisualStyleBackColor = true;
            this.radioEuros.CheckedChanged += new System.EventHandler(this.calculateDollars);
            // 
            // radioDollars
            // 
            this.radioDollars.AutoSize = true;
            this.radioDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioDollars.Location = new System.Drawing.Point(24, 42);
            this.radioDollars.Name = "radioDollars";
            this.radioDollars.Size = new System.Drawing.Size(113, 33);
            this.radioDollars.TabIndex = 0;
            this.radioDollars.TabStop = true;
            this.radioDollars.Text = "Dollars";
            this.radioDollars.UseVisualStyleBackColor = true;
            this.radioDollars.CheckedChanged += new System.EventHandler(this.calculateDollars);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitButton.Location = new System.Drawing.Point(677, 512);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(143, 43);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitForm);
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.poundsLabel.Location = new System.Drawing.Point(66, 180);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(148, 29);
            this.poundsLabel.TabIndex = 2;
            this.poundsLabel.Text = "UK Pounds:";
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.convertLabel.Location = new System.Drawing.Point(66, 282);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(231, 29);
            this.convertLabel.TabIndex = 8;
            this.convertLabel.Text = "Converted Amount:";
            // 
            // convertAmount
            // 
            this.convertAmount.BackColor = System.Drawing.Color.Yellow;
            this.convertAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.convertAmount.Location = new System.Drawing.Point(384, 298);
            this.convertAmount.Name = "convertAmount";
            this.convertAmount.Size = new System.Drawing.Size(137, 30);
            this.convertAmount.TabIndex = 9;
            // 
            // CurrencyconverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(983, 592);
            this.Controls.Add(this.convertAmount);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UKPounds);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currencyconverterLabel);
            this.Name = "CurrencyconverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Georgia\'s Currency Converter";
            
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyconverterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UKPounds;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioRupees;
        private System.Windows.Forms.RadioButton radioEuros;
        private System.Windows.Forms.RadioButton radioDollars;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.TextBox convertAmount;
    }
}