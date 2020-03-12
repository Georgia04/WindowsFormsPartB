namespace WindowsFormsApp1
{
    partial class DataEntryForm
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
            this.mainForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainForm
            // 
            this.mainForm.AutoSize = true;
            this.mainForm.BackColor = System.Drawing.Color.Red;
            this.mainForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainForm.Location = new System.Drawing.Point(167, 27);
            this.mainForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(620, 47);
            this.mainForm.TabIndex = 0;
            this.mainForm.Text = "Georgia\'s Details Data Entry Form";
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 563);
            this.Controls.Add(this.mainForm);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "DataEntryForm";
            this.Text = "Georgia Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainForm;
    }
}