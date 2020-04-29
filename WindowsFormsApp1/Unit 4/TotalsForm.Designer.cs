namespace WindowsFormsApp1
{
    partial class TotalsForm
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
            this.backForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backForm
            // 
            this.backForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backForm.Location = new System.Drawing.Point(603, 440);
            this.backForm.Name = "backForm";
            this.backForm.Size = new System.Drawing.Size(134, 52);
            this.backForm.TabIndex = 0;
            this.backForm.Text = "Back";
            this.backForm.UseVisualStyleBackColor = true;
            this.backForm.Click += new System.EventHandler(this.backForm_Click);
            // 
            // TotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 539);
            this.Controls.Add(this.backForm);
            this.Name = "TotalsForm";
            this.Text = "TotalsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backForm;
    }
}