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
            this.addForm = new System.Windows.Forms.Button();
            this.substractForm = new System.Windows.Forms.Button();
            this.multiplyForm = new System.Windows.Forms.Button();
            this.divideForm = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.raiseToPower = new System.Windows.Forms.Button();
            this.calculateAverage = new System.Windows.Forms.Button();
            this.clearNumbers = new System.Windows.Forms.Button();
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
            // addForm
            // 
            this.addForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addForm.Location = new System.Drawing.Point(779, 125);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(138, 42);
            this.addForm.TabIndex = 7;
            this.addForm.Text = "Add";
            this.addForm.UseVisualStyleBackColor = true;
            this.addForm.Click += new System.EventHandler(this.addNumbers);
            // 
            // substractForm
            // 
            this.substractForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.substractForm.Location = new System.Drawing.Point(779, 196);
            this.substractForm.Name = "substractForm";
            this.substractForm.Size = new System.Drawing.Size(138, 45);
            this.substractForm.TabIndex = 8;
            this.substractForm.Text = "Substract";
            this.substractForm.UseVisualStyleBackColor = true;
            this.substractForm.Click += new System.EventHandler(this.substractNumbers);
            // 
            // multiplyForm
            // 
            this.multiplyForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.multiplyForm.Location = new System.Drawing.Point(779, 262);
            this.multiplyForm.Name = "multiplyForm";
            this.multiplyForm.Size = new System.Drawing.Size(138, 41);
            this.multiplyForm.TabIndex = 9;
            this.multiplyForm.Text = "Multiply";
            this.multiplyForm.UseVisualStyleBackColor = true;
            this.multiplyForm.Click += new System.EventHandler(this.multiplyNumbers);
            // 
            // divideForm
            // 
            this.divideForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.divideForm.Location = new System.Drawing.Point(779, 326);
            this.divideForm.Name = "divideForm";
            this.divideForm.Size = new System.Drawing.Size(138, 41);
            this.divideForm.TabIndex = 10;
            this.divideForm.Text = "Divide";
            this.divideForm.UseVisualStyleBackColor = true;
            this.divideForm.Click += new System.EventHandler(this.divideNumbers);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(799, 515);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(122, 39);
            this.quitForm.TabIndex = 11;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
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
            // raiseToPower
            // 
            this.raiseToPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.raiseToPower.Location = new System.Drawing.Point(57, 515);
            this.raiseToPower.Name = "raiseToPower";
            this.raiseToPower.Size = new System.Drawing.Size(122, 39);
            this.raiseToPower.TabIndex = 11;
            this.raiseToPower.Text = "Power";
            this.raiseToPower.UseVisualStyleBackColor = true;
            this.raiseToPower.Click += new System.EventHandler(this.raiseToPower_Click);
            // 
            // calculateAverage
            // 
            this.calculateAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calculateAverage.Location = new System.Drawing.Point(321, 515);
            this.calculateAverage.Name = "calculateAverage";
            this.calculateAverage.Size = new System.Drawing.Size(122, 39);
            this.calculateAverage.TabIndex = 11;
            this.calculateAverage.Text = "Average";
            this.calculateAverage.UseVisualStyleBackColor = true;
            this.calculateAverage.Click += new System.EventHandler(this.calculateAverage_Click);
            // 
            // clearNumbers
            // 
            this.clearNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearNumbers.Location = new System.Drawing.Point(585, 515);
            this.clearNumbers.Name = "clearNumbers";
            this.clearNumbers.Size = new System.Drawing.Size(122, 39);
            this.clearNumbers.TabIndex = 11;
            this.clearNumbers.Text = "Clear";
            this.clearNumbers.UseVisualStyleBackColor = true;
            this.clearNumbers.Click += new System.EventHandler(this.clearForm);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(966, 616);
            this.Controls.Add(this.clearNumbers);
            this.Controls.Add(this.calculateAverage);
            this.Controls.Add(this.raiseToPower);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.divideForm);
            this.Controls.Add(this.multiplyForm);
            this.Controls.Add(this.substractForm);
            this.Controls.Add(this.addForm);
            this.Controls.Add(this.numresultLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secnumLabel);
            this.Controls.Add(this.firstnumLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.secnumBox);
            this.Controls.Add(this.firstnumBox);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Georgia\'s Calculator";
            this.Load += new System.EventHandler(this.calculatorForm_Load_1);
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
        private System.Windows.Forms.Button addForm;
        private System.Windows.Forms.Button substractForm;
        private System.Windows.Forms.Button multiplyForm;
        private System.Windows.Forms.Button divideForm;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button raiseToPower;
        private System.Windows.Forms.Button calculateAverage;
        private System.Windows.Forms.Button clearNumbers;
    }
}