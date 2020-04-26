namespace WindowsFormsApp1
{
    partial class TipsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipsterForm));
            this.billLabel = new System.Windows.Forms.Label();
            this.peoplenumberLabel = new System.Windows.Forms.Label();
            this.billBox = new System.Windows.Forms.TextBox();
            this.peoplenumberBox = new System.Windows.Forms.ListBox();
            this.calculateForm = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipBox = new System.Windows.Forms.GroupBox();
            this.madRadio = new System.Windows.Forms.RadioButton();
            this.generousRadio = new System.Windows.Forms.RadioButton();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.noneRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tipBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billLabel.Location = new System.Drawing.Point(26, 57);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(48, 29);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Bill";
            // 
            // peoplenumberLabel
            // 
            this.peoplenumberLabel.AutoSize = true;
            this.peoplenumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.peoplenumberLabel.Location = new System.Drawing.Point(26, 121);
            this.peoplenumberLabel.Name = "peoplenumberLabel";
            this.peoplenumberLabel.Size = new System.Drawing.Size(217, 29);
            this.peoplenumberLabel.TabIndex = 1;
            this.peoplenumberLabel.Text = "Number of People";
            // 
            // billBox
            // 
            this.billBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billBox.Location = new System.Drawing.Point(137, 58);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(245, 30);
            this.billBox.TabIndex = 2;
            // 
            // peoplenumberBox
            // 
            this.peoplenumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.peoplenumberBox.FormattingEnabled = true;
            this.peoplenumberBox.ItemHeight = 26;
            this.peoplenumberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.peoplenumberBox.Location = new System.Drawing.Point(294, 121);
            this.peoplenumberBox.Name = "peoplenumberBox";
            this.peoplenumberBox.Size = new System.Drawing.Size(88, 82);
            this.peoplenumberBox.TabIndex = 3;
            // 
            // calculateForm
            // 
            this.calculateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calculateForm.Location = new System.Drawing.Point(470, 439);
            this.calculateForm.Name = "calculateForm";
            this.calculateForm.Size = new System.Drawing.Size(151, 39);
            this.calculateForm.TabIndex = 4;
            this.calculateForm.Text = "Calculate";
            this.calculateForm.UseVisualStyleBackColor = true;
            this.calculateForm.Click += new System.EventHandler(this.calculateForm_Click);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(667, 439);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(147, 39);
            this.quitForm.TabIndex = 5;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tipBox
            // 
            this.tipBox.Controls.Add(this.madRadio);
            this.tipBox.Controls.Add(this.generousRadio);
            this.tipBox.Controls.Add(this.normalRadio);
            this.tipBox.Controls.Add(this.noneRadio);
            this.tipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tipBox.Location = new System.Drawing.Point(31, 276);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(351, 145);
            this.tipBox.TabIndex = 7;
            this.tipBox.TabStop = false;
            this.tipBox.Text = "Tip";
            // 
            // madRadio
            // 
            this.madRadio.AutoSize = true;
            this.madRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.madRadio.Location = new System.Drawing.Point(173, 92);
            this.madRadio.Name = "madRadio";
            this.madRadio.Size = new System.Drawing.Size(81, 33);
            this.madRadio.TabIndex = 3;
            this.madRadio.TabStop = true;
            this.madRadio.Text = "mad";
            this.madRadio.UseVisualStyleBackColor = true;
            this.madRadio.CheckedChanged += new System.EventHandler(this.madRadio_CheckedChanged);
            // 
            // generousRadio
            // 
            this.generousRadio.AutoSize = true;
            this.generousRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.generousRadio.Location = new System.Drawing.Point(23, 89);
            this.generousRadio.Name = "generousRadio";
            this.generousRadio.Size = new System.Drawing.Size(136, 33);
            this.generousRadio.TabIndex = 2;
            this.generousRadio.TabStop = true;
            this.generousRadio.Text = "generous";
            this.generousRadio.UseVisualStyleBackColor = true;
            this.generousRadio.CheckedChanged += new System.EventHandler(this.generousRadio_CheckedChanged);
            // 
            // normalRadio
            // 
            this.normalRadio.AutoSize = true;
            this.normalRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.normalRadio.Location = new System.Drawing.Point(173, 44);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(108, 33);
            this.normalRadio.TabIndex = 1;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "normal";
            this.normalRadio.UseVisualStyleBackColor = true;
            this.normalRadio.CheckedChanged += new System.EventHandler(this.normalRadio_CheckedChanged);
            // 
            // noneRadio
            // 
            this.noneRadio.AutoSize = true;
            this.noneRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.noneRadio.Location = new System.Drawing.Point(23, 44);
            this.noneRadio.Name = "noneRadio";
            this.noneRadio.Size = new System.Drawing.Size(93, 33);
            this.noneRadio.TabIndex = 0;
            this.noneRadio.TabStop = true;
            this.noneRadio.Text = "None";
            this.noneRadio.UseVisualStyleBackColor = true;
            this.noneRadio.CheckedChanged += new System.EventHandler(this.noneRadio_CheckedChanged);
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(843, 507);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.calculateForm);
            this.Controls.Add(this.peoplenumberBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.peoplenumberLabel);
            this.Controls.Add(this.billLabel);
            this.Name = "TipsterForm";
            this.Text = "Georgia\'s Tipster Bill";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tipBox.ResumeLayout(false);
            this.tipBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label peoplenumberLabel;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.ListBox peoplenumberBox;
        private System.Windows.Forms.Button calculateForm;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox tipBox;
        private System.Windows.Forms.RadioButton madRadio;
        private System.Windows.Forms.RadioButton generousRadio;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.RadioButton noneRadio;
    }
}