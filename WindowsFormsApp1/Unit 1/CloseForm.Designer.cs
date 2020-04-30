namespace WindowsFormsApp1
{
    partial class CloseScreen
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
            this.closeForm = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.closeForm.Location = new System.Drawing.Point(301, 197);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(187, 41);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = "Click to Finish";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Green;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messageLabel.Location = new System.Drawing.Point(186, 72);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(133, 41);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "GoodBye";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // CloseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 287);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeForm);
            this.Name = "CloseScreen";
            this.Text = "Close Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label messageLabel;
    }
}