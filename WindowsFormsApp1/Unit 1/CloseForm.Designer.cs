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
            this.closeButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.closeButton.Location = new System.Drawing.Point(301, 197);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(187, 41);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Click to Finish";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Green;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label1.Location = new System.Drawing.Point(186, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 41);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "GoodBye";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 287);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.closeButton);
            this.Name = "closeScreen";
            this.Text = "Close Form";
            this.Load += new System.EventHandler(this.closeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label Label1;
    }
}