namespace WindowsFormsApp1
{
    partial class ResultsForm
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
            this.billdetailsBox = new System.Windows.Forms.GroupBox();
            this.peopleNumber = new System.Windows.Forms.Label();
            this.totalBill = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.totalbillLabel = new System.Windows.Forms.Label();
            this.eachpaysLabel = new System.Windows.Forms.Label();
            this.eachPays = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.Button();
            this.billdetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billdetailsBox
            // 
            this.billdetailsBox.Controls.Add(this.peopleNumber);
            this.billdetailsBox.Controls.Add(this.totalBill);
            this.billdetailsBox.Controls.Add(this.peopleLabel);
            this.billdetailsBox.Controls.Add(this.totalbillLabel);
            this.billdetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.billdetailsBox.Location = new System.Drawing.Point(63, 54);
            this.billdetailsBox.Name = "billdetailsBox";
            this.billdetailsBox.Size = new System.Drawing.Size(516, 254);
            this.billdetailsBox.TabIndex = 0;
            this.billdetailsBox.TabStop = false;
            this.billdetailsBox.Text = "Bill Details";
            // 
            // peopleNumber
            // 
            this.peopleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.peopleNumber.Location = new System.Drawing.Point(225, 159);
            this.peopleNumber.Name = "peopleNumber";
            this.peopleNumber.Size = new System.Drawing.Size(92, 29);
            this.peopleNumber.TabIndex = 3;
            // 
            // totalBill
            // 
            this.totalBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalBill.Location = new System.Drawing.Point(225, 80);
            this.totalBill.Name = "totalBill";
            this.totalBill.Size = new System.Drawing.Size(92, 30);
            this.totalBill.TabIndex = 2;
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(22, 159);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(99, 29);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "People:";
            // 
            // totalbillLabel
            // 
            this.totalbillLabel.AutoSize = true;
            this.totalbillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalbillLabel.Location = new System.Drawing.Point(17, 80);
            this.totalbillLabel.Name = "totalbillLabel";
            this.totalbillLabel.Size = new System.Drawing.Size(101, 26);
            this.totalbillLabel.TabIndex = 0;
            this.totalbillLabel.Text = "Total Bill:";
            // 
            // eachpaysLabel
            // 
            this.eachpaysLabel.AutoSize = true;
            this.eachpaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eachpaysLabel.Location = new System.Drawing.Point(80, 386);
            this.eachpaysLabel.Name = "eachpaysLabel";
            this.eachpaysLabel.Size = new System.Drawing.Size(142, 29);
            this.eachpaysLabel.TabIndex = 1;
            this.eachpaysLabel.Text = "Each Pays:";
            // 
            // eachPays
            // 
            this.eachPays.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eachPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eachPays.Location = new System.Drawing.Point(288, 386);
            this.eachPays.Name = "eachPays";
            this.eachPays.Size = new System.Drawing.Size(165, 33);
            this.eachPays.TabIndex = 2;
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.closeForm.Location = new System.Drawing.Point(655, 494);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(136, 40);
            this.closeForm.TabIndex = 3;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(857, 559);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.eachPays);
            this.Controls.Add(this.eachpaysLabel);
            this.Controls.Add(this.billdetailsBox);
            this.Name = "ResultsForm";
            this.Text = "Results";
            this.billdetailsBox.ResumeLayout(false);
            this.billdetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox billdetailsBox;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label totalbillLabel;
        public System.Windows.Forms.Label peopleNumber;
        public System.Windows.Forms.Label totalBill;
        private System.Windows.Forms.Label eachpaysLabel;
        public System.Windows.Forms.Label eachPays;
        private System.Windows.Forms.Button closeForm;
    }
}