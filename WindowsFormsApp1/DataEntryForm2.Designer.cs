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
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.surName = new System.Windows.Forms.TextBox();
            this.universityCombo = new System.Windows.Forms.ComboBox();
            this.dinnerBox = new System.Windows.Forms.GroupBox();
            this.chickenCheck = new System.Windows.Forms.CheckBox();
            this.risottoCheck = new System.Windows.Forms.CheckBox();
            this.pastaCheck = new System.Windows.Forms.CheckBox();
            this.lasagneCheck = new System.Windows.Forms.CheckBox();
            this.fishpieCheck = new System.Windows.Forms.CheckBox();
            this.budgetCheck = new System.Windows.Forms.CheckBox();
            this.lunchBox = new System.Windows.Forms.GroupBox();
            this.baconCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sandwichCheck = new System.Windows.Forms.CheckBox();
            this.saladCheck = new System.Windows.Forms.CheckBox();
            this.burritosCheck = new System.Windows.Forms.CheckBox();
            this.tacoCheck = new System.Windows.Forms.CheckBox();
            this.quitForm = new System.Windows.Forms.Button();
            this.billForm = new System.Windows.Forms.Button();
            this.totalForm = new System.Windows.Forms.Button();
            this.billgroupBox = new System.Windows.Forms.GroupBox();
            this.billPrice = new System.Windows.Forms.Label();
            this.dinnerBox.SuspendLayout();
            this.lunchBox.SuspendLayout();
            this.billgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsLabel
            // 
            this.detailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.detailsLabel.Location = new System.Drawing.Point(12, 34);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(338, 34);
            this.detailsLabel.TabIndex = 0;
            this.detailsLabel.Text = "Attendee Details Data Form";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnameLabel.Location = new System.Drawing.Point(22, 136);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(129, 27);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "First Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(22, 187);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(129, 32);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstName.Location = new System.Drawing.Point(223, 133);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(256, 30);
            this.firstName.TabIndex = 3;
            // 
            // surName
            // 
            this.surName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surName.Location = new System.Drawing.Point(223, 189);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(256, 30);
            this.surName.TabIndex = 4;
            // 
            // universityCombo
            // 
            this.universityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.universityCombo.FormattingEnabled = true;
            this.universityCombo.Items.AddRange(new object[] {
            "University of Cambridge",
            "New Bucks University",
            "University of Oxford",
            "University of Leeds",
            "University of London"});
            this.universityCombo.Location = new System.Drawing.Point(590, 120);
            this.universityCombo.Name = "universityCombo";
            this.universityCombo.Size = new System.Drawing.Size(247, 33);
            this.universityCombo.TabIndex = 5;
            this.universityCombo.Text = "Choose University";
            // 
            // dinnerBox
            // 
            this.dinnerBox.Controls.Add(this.chickenCheck);
            this.dinnerBox.Controls.Add(this.risottoCheck);
            this.dinnerBox.Controls.Add(this.pastaCheck);
            this.dinnerBox.Controls.Add(this.lasagneCheck);
            this.dinnerBox.Controls.Add(this.fishpieCheck);
            this.dinnerBox.Controls.Add(this.budgetCheck);
            this.dinnerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dinnerBox.Location = new System.Drawing.Point(27, 278);
            this.dinnerBox.Name = "dinnerBox";
            this.dinnerBox.Size = new System.Drawing.Size(398, 208);
            this.dinnerBox.TabIndex = 6;
            this.dinnerBox.TabStop = false;
            this.dinnerBox.Text = "Dinner Options";
            // 
            // chickenCheck
            // 
            this.chickenCheck.AutoSize = true;
            this.chickenCheck.Location = new System.Drawing.Point(150, 102);
            this.chickenCheck.Name = "chickenCheck";
            this.chickenCheck.Size = new System.Drawing.Size(172, 30);
            this.chickenCheck.TabIndex = 5;
            this.chickenCheck.Text = "Chicken Curry";
            this.chickenCheck.UseVisualStyleBackColor = true;
            // 
            // risottoCheck
            // 
            this.risottoCheck.AutoSize = true;
            this.risottoCheck.Location = new System.Drawing.Point(18, 154);
            this.risottoCheck.Name = "risottoCheck";
            this.risottoCheck.Size = new System.Drawing.Size(102, 30);
            this.risottoCheck.TabIndex = 4;
            this.risottoCheck.Text = "Risotto";
            this.risottoCheck.UseVisualStyleBackColor = true;
            // 
            // pastaCheck
            // 
            this.pastaCheck.AutoSize = true;
            this.pastaCheck.Location = new System.Drawing.Point(18, 102);
            this.pastaCheck.Name = "pastaCheck";
            this.pastaCheck.Size = new System.Drawing.Size(90, 30);
            this.pastaCheck.TabIndex = 3;
            this.pastaCheck.Text = "Pasta";
            this.pastaCheck.UseVisualStyleBackColor = true;
            // 
            // lasagneCheck
            // 
            this.lasagneCheck.AutoSize = true;
            this.lasagneCheck.Location = new System.Drawing.Point(150, 154);
            this.lasagneCheck.Name = "lasagneCheck";
            this.lasagneCheck.Size = new System.Drawing.Size(117, 30);
            this.lasagneCheck.TabIndex = 2;
            this.lasagneCheck.Text = "Lasagne";
            this.lasagneCheck.UseVisualStyleBackColor = true;
            // 
            // fishpieCheck
            // 
            this.fishpieCheck.AutoSize = true;
            this.fishpieCheck.Location = new System.Drawing.Point(151, 53);
            this.fishpieCheck.Name = "fishpieCheck";
            this.fishpieCheck.Size = new System.Drawing.Size(113, 30);
            this.fishpieCheck.TabIndex = 1;
            this.fishpieCheck.Text = "Fish Pie";
            this.fishpieCheck.UseVisualStyleBackColor = true;
            // 
            // budgetCheck
            // 
            this.budgetCheck.AutoSize = true;
            this.budgetCheck.Location = new System.Drawing.Point(20, 53);
            this.budgetCheck.Name = "budgetCheck";
            this.budgetCheck.Size = new System.Drawing.Size(103, 30);
            this.budgetCheck.TabIndex = 0;
            this.budgetCheck.Text = "Budget";
            this.budgetCheck.UseVisualStyleBackColor = true;
            this.budgetCheck.CheckedChanged += new System.EventHandler(this.budgetCheck_CheckedChanged);
            // 
            // lunchBox
            // 
            this.lunchBox.Controls.Add(this.baconCheck);
            this.lunchBox.Controls.Add(this.checkBox1);
            this.lunchBox.Controls.Add(this.sandwichCheck);
            this.lunchBox.Controls.Add(this.saladCheck);
            this.lunchBox.Controls.Add(this.burritosCheck);
            this.lunchBox.Controls.Add(this.tacoCheck);
            this.lunchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lunchBox.Location = new System.Drawing.Point(489, 278);
            this.lunchBox.Name = "lunchBox";
            this.lunchBox.Size = new System.Drawing.Size(413, 208);
            this.lunchBox.TabIndex = 7;
            this.lunchBox.TabStop = false;
            this.lunchBox.Text = "Lunch Box";
            // 
            // baconCheck
            // 
            this.baconCheck.AutoSize = true;
            this.baconCheck.Location = new System.Drawing.Point(240, 154);
            this.baconCheck.Name = "baconCheck";
            this.baconCheck.Size = new System.Drawing.Size(158, 30);
            this.baconCheck.TabIndex = 5;
            this.baconCheck.Text = "Bacon Salad";
            this.baconCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(240, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 30);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Sweet Potato";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // sandwichCheck
            // 
            this.sandwichCheck.AutoSize = true;
            this.sandwichCheck.Location = new System.Drawing.Point(240, 53);
            this.sandwichCheck.Name = "sandwichCheck";
            this.sandwichCheck.Size = new System.Drawing.Size(129, 30);
            this.sandwichCheck.TabIndex = 3;
            this.sandwichCheck.Text = "Sandwich";
            this.sandwichCheck.UseVisualStyleBackColor = true;
            // 
            // saladCheck
            // 
            this.saladCheck.AutoSize = true;
            this.saladCheck.Location = new System.Drawing.Point(27, 154);
            this.saladCheck.Name = "saladCheck";
            this.saladCheck.Size = new System.Drawing.Size(175, 30);
            this.saladCheck.TabIndex = 2;
            this.saladCheck.Text = "Chicken Salad";
            this.saladCheck.UseVisualStyleBackColor = true;
            // 
            // burritosCheck
            // 
            this.burritosCheck.AutoSize = true;
            this.burritosCheck.Location = new System.Drawing.Point(27, 102);
            this.burritosCheck.Name = "burritosCheck";
            this.burritosCheck.Size = new System.Drawing.Size(109, 30);
            this.burritosCheck.TabIndex = 1;
            this.burritosCheck.Text = "Burritos";
            this.burritosCheck.UseVisualStyleBackColor = true;
            // 
            // tacoCheck
            // 
            this.tacoCheck.AutoSize = true;
            this.tacoCheck.Location = new System.Drawing.Point(27, 53);
            this.tacoCheck.Name = "tacoCheck";
            this.tacoCheck.Size = new System.Drawing.Size(165, 30);
            this.tacoCheck.TabIndex = 0;
            this.tacoCheck.Text = "Walking Taco";
            this.tacoCheck.UseVisualStyleBackColor = true;
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(794, 565);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(134, 37);
            this.quitForm.TabIndex = 8;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // billForm
            // 
            this.billForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billForm.Location = new System.Drawing.Point(530, 565);
            this.billForm.Name = "billForm";
            this.billForm.Size = new System.Drawing.Size(140, 37);
            this.billForm.TabIndex = 9;
            this.billForm.Text = "Check Bill";
            this.billForm.UseVisualStyleBackColor = true;
            this.billForm.Click += new System.EventHandler(this.billForm_Click);
            // 
            // totalForm
            // 
            this.totalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalForm.Location = new System.Drawing.Point(293, 565);
            this.totalForm.Name = "totalForm";
            this.totalForm.Size = new System.Drawing.Size(147, 37);
            this.totalForm.TabIndex = 10;
            this.totalForm.Text = "Total Bill";
            this.totalForm.UseVisualStyleBackColor = true;
            // 
            // billgroupBox
            // 
            this.billgroupBox.Controls.Add(this.billPrice);
            this.billgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billgroupBox.Location = new System.Drawing.Point(27, 527);
            this.billgroupBox.Name = "billgroupBox";
            this.billgroupBox.Size = new System.Drawing.Size(200, 100);
            this.billgroupBox.TabIndex = 11;
            this.billgroupBox.TabStop = false;
            this.billgroupBox.Text = "Bill";
            // 
            // billPrice
            // 
            this.billPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.billPrice.Location = new System.Drawing.Point(54, 38);
            this.billPrice.Name = "billPrice";
            this.billPrice.Size = new System.Drawing.Size(126, 37);
            this.billPrice.TabIndex = 0;
            // 
            // DataEntryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 657);
            this.Controls.Add(this.billgroupBox);
            this.Controls.Add(this.totalForm);
            this.Controls.Add(this.billForm);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.lunchBox);
            this.Controls.Add(this.dinnerBox);
            this.Controls.Add(this.universityCombo);
            this.Controls.Add(this.surName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.detailsLabel);
            this.Name = "DataEntryForm2";
            this.Text = "DataEntryForm2";
            this.dinnerBox.ResumeLayout(false);
            this.dinnerBox.PerformLayout();
            this.lunchBox.ResumeLayout(false);
            this.lunchBox.PerformLayout();
            this.billgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.ComboBox universityCombo;
        private System.Windows.Forms.GroupBox dinnerBox;
        private System.Windows.Forms.CheckBox chickenCheck;
        private System.Windows.Forms.CheckBox risottoCheck;
        private System.Windows.Forms.CheckBox pastaCheck;
        private System.Windows.Forms.CheckBox lasagneCheck;
        private System.Windows.Forms.CheckBox fishpieCheck;
        private System.Windows.Forms.CheckBox budgetCheck;
        private System.Windows.Forms.GroupBox lunchBox;
        private System.Windows.Forms.CheckBox baconCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox sandwichCheck;
        private System.Windows.Forms.CheckBox saladCheck;
        private System.Windows.Forms.CheckBox burritosCheck;
        private System.Windows.Forms.CheckBox tacoCheck;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Button billForm;
        private System.Windows.Forms.Button totalForm;
        public System.Windows.Forms.TextBox firstName;
        public System.Windows.Forms.TextBox surName;
        private System.Windows.Forms.GroupBox billgroupBox;
        private System.Windows.Forms.Label billPrice;
    }
}