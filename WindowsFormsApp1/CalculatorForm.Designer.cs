namespace WindowsFormsApp1
{
    partial class CalculatorForm
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
            this.firstnumBox = new System.Windows.Forms.TextBox();
            this.secnumBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstnumLabel = new System.Windows.Forms.Label();
            this.secnumLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.numresultLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.powerButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnumBox
            // 
            this.firstnumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnumBox.Location = new System.Drawing.Point(225, 125);
            this.firstnumBox.Name = "firstnumBox";
            this.firstnumBox.Size = new System.Drawing.Size(100, 53);
            this.firstnumBox.TabIndex = 0;
            // 
            // secnumBox
            // 
            this.secnumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secnumBox.Location = new System.Drawing.Point(225, 227);
            this.secnumBox.Name = "secnumBox";
            this.secnumBox.Size = new System.Drawing.Size(100, 53);
            this.secnumBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(59, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 46);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Simple Calculator";
            // 
            // firstnumLabel
            // 
            this.firstnumLabel.AutoSize = true;
            this.firstnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnumLabel.Location = new System.Drawing.Point(50, 135);
            this.firstnumLabel.Name = "firstnumLabel";
            this.firstnumLabel.Size = new System.Drawing.Size(129, 25);
            this.firstnumLabel.TabIndex = 3;
            this.firstnumLabel.Text = "First Number:";
            // 
            // secnumLabel
            // 
            this.secnumLabel.AutoSize = true;
            this.secnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secnumLabel.Location = new System.Drawing.Point(50, 247);
            this.secnumLabel.Name = "secnumLabel";
            this.secnumLabel.Size = new System.Drawing.Size(160, 25);
            this.secnumLabel.TabIndex = 4;
            this.secnumLabel.Text = "Second Number:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultLabel.Location = new System.Drawing.Point(55, 342);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(72, 25);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result:";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // numresultLabel
            // 
            this.numresultLabel.BackColor = System.Drawing.Color.Blue;
            this.numresultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numresultLabel.Location = new System.Drawing.Point(218, 342);
            this.numresultLabel.Name = "numresultLabel";
            this.numresultLabel.Size = new System.Drawing.Size(100, 46);
            this.numresultLabel.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(779, 125);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 42);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.substractButton.Location = new System.Drawing.Point(779, 196);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(138, 45);
            this.substractButton.TabIndex = 8;
            this.substractButton.Text = "Substract";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.multiplyButton.Location = new System.Drawing.Point(779, 262);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(138, 41);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.divideButton.Location = new System.Drawing.Point(779, 326);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(138, 41);
            this.divideButton.TabIndex = 10;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitButton.Location = new System.Drawing.Point(799, 515);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(122, 39);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(51, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 10);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(55, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 10);
            this.panel2.TabIndex = 13;
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.powerButton.Location = new System.Drawing.Point(57, 515);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(122, 39);
            this.powerButton.TabIndex = 11;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.averageButton.Location = new System.Drawing.Point(321, 515);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(122, 39);
            this.averageButton.TabIndex = 11;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearButton.Location = new System.Drawing.Point(585, 515);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 39);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(966, 616);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numresultLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secnumLabel);
            this.Controls.Add(this.firstnumLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.secnumBox);
            this.Controls.Add(this.firstnumBox);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnumBox;
        private System.Windows.Forms.TextBox secnumBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstnumLabel;
        private System.Windows.Forms.Label secnumLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label numresultLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button clearButton;
    }
}