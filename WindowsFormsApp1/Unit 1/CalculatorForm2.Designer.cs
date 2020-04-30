namespace WindowsFormsApp1
{
    partial class CalculatorForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm2));
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstnumLabel = new System.Windows.Forms.Label();
            this.secnumLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.firstnumBox = new System.Windows.Forms.TextBox();
            this.secnumBox = new System.Windows.Forms.TextBox();
            this.numresultLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.raiseToPower = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.clearNumbers = new System.Windows.Forms.Button();
            this.calculateAverage = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.substractPicture = new System.Windows.Forms.PictureBox();
            this.multiplyPicture = new System.Windows.Forms.PictureBox();
            this.dividePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substractPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(55, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(364, 59);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Simple Calculator";
            // 
            // firstnumLabel
            // 
            this.firstnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnumLabel.Location = new System.Drawing.Point(50, 186);
            this.firstnumLabel.Name = "firstnumLabel";
            this.firstnumLabel.Size = new System.Drawing.Size(143, 40);
            this.firstnumLabel.TabIndex = 1;
            this.firstnumLabel.Text = "First Number:";
            // 
            // secnumLabel
            // 
            this.secnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secnumLabel.Location = new System.Drawing.Point(50, 302);
            this.secnumLabel.Name = "secnumLabel";
            this.secnumLabel.Size = new System.Drawing.Size(165, 30);
            this.secnumLabel.TabIndex = 2;
            this.secnumLabel.Text = "Second Number:";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultLabel.Location = new System.Drawing.Point(50, 416);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(143, 36);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // firstnumBox
            // 
            this.firstnumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnumBox.Location = new System.Drawing.Point(256, 173);
            this.firstnumBox.Name = "firstnumBox";
            this.firstnumBox.Size = new System.Drawing.Size(100, 53);
            this.firstnumBox.TabIndex = 4;
            // 
            // secnumBox
            // 
            this.secnumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secnumBox.Location = new System.Drawing.Point(256, 302);
            this.secnumBox.Name = "secnumBox";
            this.secnumBox.Size = new System.Drawing.Size(100, 53);
            this.secnumBox.TabIndex = 5;
            // 
            // numresultLabel
            // 
            this.numresultLabel.BackColor = System.Drawing.Color.Blue;
            this.numresultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numresultLabel.Location = new System.Drawing.Point(256, 416);
            this.numresultLabel.Name = "numresultLabel";
            this.numresultLabel.Size = new System.Drawing.Size(100, 50);
            this.numresultLabel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(55, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 10);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(55, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 10);
            this.panel1.TabIndex = 8;
            // 
            // raiseToPower
            // 
            this.raiseToPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.raiseToPower.Location = new System.Drawing.Point(78, 579);
            this.raiseToPower.Name = "raiseToPower";
            this.raiseToPower.Size = new System.Drawing.Size(138, 45);
            this.raiseToPower.TabIndex = 9;
            this.raiseToPower.Text = "Power";
            this.raiseToPower.UseVisualStyleBackColor = true;
            this.raiseToPower.Click += new System.EventHandler(this.raiseToPower_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(783, 579);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(138, 45);
            this.quitForm.TabIndex = 10;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // clearNumbers
            // 
            this.clearNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearNumbers.Location = new System.Drawing.Point(549, 579);
            this.clearNumbers.Name = "clearNumbers";
            this.clearNumbers.Size = new System.Drawing.Size(138, 45);
            this.clearNumbers.TabIndex = 11;
            this.clearNumbers.Text = "Clear";
            this.clearNumbers.UseVisualStyleBackColor = true;
            this.clearNumbers.Click += new System.EventHandler(this.clearNumbers_Click);
            // 
            // calculateAverage
            // 
            this.calculateAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calculateAverage.Location = new System.Drawing.Point(314, 579);
            this.calculateAverage.Name = "calculateAverage";
            this.calculateAverage.Size = new System.Drawing.Size(138, 45);
            this.calculateAverage.TabIndex = 12;
            this.calculateAverage.Text = "Average";
            this.calculateAverage.UseVisualStyleBackColor = true;
            this.calculateAverage.Click += new System.EventHandler(this.calculateAverage_Click);
            // 
            // addPicture
            // 
            this.addPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addPicture.Image = ((System.Drawing.Image)(resources.GetObject("addPicture.Image")));
            this.addPicture.Location = new System.Drawing.Point(655, 173);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(80, 74);
            this.addPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPicture.TabIndex = 13;
            this.addPicture.TabStop = false;
           
            // 
            // substractPicture
            // 
            this.substractPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.substractPicture.Image = ((System.Drawing.Image)(resources.GetObject("substractPicture.Image")));
            this.substractPicture.Location = new System.Drawing.Point(792, 173);
            this.substractPicture.Name = "substractPicture";
            this.substractPicture.Size = new System.Drawing.Size(81, 74);
            this.substractPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.substractPicture.TabIndex = 14;
            this.substractPicture.TabStop = false;
            // 
            // multiplyPicture
            // 
            this.multiplyPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.multiplyPicture.Image = ((System.Drawing.Image)(resources.GetObject("multiplyPicture.Image")));
            this.multiplyPicture.Location = new System.Drawing.Point(655, 272);
            this.multiplyPicture.Name = "multiplyPicture";
            this.multiplyPicture.Size = new System.Drawing.Size(80, 74);
            this.multiplyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.multiplyPicture.TabIndex = 15;
            this.multiplyPicture.TabStop = false;
            // 
            // dividePicture
            // 
            this.dividePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividePicture.Image = ((System.Drawing.Image)(resources.GetObject("dividePicture.Image")));
            this.dividePicture.Location = new System.Drawing.Point(792, 272);
            this.dividePicture.Name = "dividePicture";
            this.dividePicture.Size = new System.Drawing.Size(81, 74);
            this.dividePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dividePicture.TabIndex = 16;
            this.dividePicture.TabStop = false;
            // 
            // CalculatorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(992, 676);
            this.Controls.Add(this.dividePicture);
            this.Controls.Add(this.multiplyPicture);
            this.Controls.Add(this.substractPicture);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.calculateAverage);
            this.Controls.Add(this.clearNumbers);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.raiseToPower);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numresultLabel);
            this.Controls.Add(this.secnumBox);
            this.Controls.Add(this.firstnumBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secnumLabel);
            this.Controls.Add(this.firstnumLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "CalculatorForm2";
            this.Text = "Georgia\'s Calculator 2";
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substractPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstnumLabel;
        private System.Windows.Forms.Label secnumLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox firstnumBox;
        private System.Windows.Forms.TextBox secnumBox;
        private System.Windows.Forms.Label numresultLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button raiseToPower;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Button clearNumbers;
        private System.Windows.Forms.Button calculateAverage;
        public System.Windows.Forms.PictureBox addPicture;
        public System.Windows.Forms.PictureBox substractPicture;
        public System.Windows.Forms.PictureBox multiplyPicture;
        public System.Windows.Forms.PictureBox dividePicture;
    }
}