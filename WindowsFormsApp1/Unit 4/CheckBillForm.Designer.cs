namespace WindowsFormsApp1
{
    partial class CheckBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBillForm));
            this.backForm = new System.Windows.Forms.Button();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.universityLabel = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.universityBox = new System.Windows.Forms.TextBox();
            this.selectOption = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backForm
            // 
            this.backForm.BackColor = System.Drawing.Color.Orange;
            this.backForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backForm.Location = new System.Drawing.Point(643, 473);
            this.backForm.Name = "backForm";
            this.backForm.Size = new System.Drawing.Size(135, 46);
            this.backForm.TabIndex = 0;
            this.backForm.Text = "Back";
            this.backForm.UseVisualStyleBackColor = false;
            this.backForm.Click += new System.EventHandler(this.backForm_Click);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.BackColor = System.Drawing.Color.Orange;
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnameLabel.Location = new System.Drawing.Point(22, 28);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(133, 36);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "Name:";
            // 
            // universityLabel
            // 
            this.universityLabel.BackColor = System.Drawing.Color.Orange;
            this.universityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.universityLabel.Location = new System.Drawing.Point(22, 94);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(133, 39);
            this.universityLabel.TabIndex = 3;
            this.universityLabel.Text = "University:";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstnameBox.Location = new System.Drawing.Point(190, 28);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(307, 36);
            this.firstnameBox.TabIndex = 4;
            // 
            // universityBox
            // 
            this.universityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.universityBox.Location = new System.Drawing.Point(190, 97);
            this.universityBox.Name = "universityBox";
            this.universityBox.Size = new System.Drawing.Size(307, 36);
            this.universityBox.TabIndex = 5;
            // 
            // selectOption
            // 
            this.selectOption.BackColor = System.Drawing.Color.Moccasin;
            this.selectOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectOption.Location = new System.Drawing.Point(379, 204);
            this.selectOption.Name = "selectOption";
            this.selectOption.Size = new System.Drawing.Size(224, 42);
            this.selectOption.TabIndex = 14;
            // 
            // selectedLabel
            // 
            this.selectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectedLabel.Location = new System.Drawing.Point(27, 204);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(302, 38);
            this.selectedLabel.TabIndex = 16;
            this.selectedLabel.Text = "Selected Option:";
            // 
            // CheckBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 555);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.selectOption);
            this.Controls.Add(this.universityBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.backForm);
            this.Name = "CheckBillForm";
            this.Text = "CheckBillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backForm;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label universityLabel;
        public System.Windows.Forms.TextBox firstnameBox;
        public System.Windows.Forms.TextBox universityBox;
        public System.Windows.Forms.Label selectOption;
        private System.Windows.Forms.Label selectedLabel;
    }
}