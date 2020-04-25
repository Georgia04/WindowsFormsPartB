namespace WindowsFormsApp1
{
    partial class PictureForm
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
            this.comboChoice = new System.Windows.Forms.ComboBox();
            this.pictureChoice = new System.Windows.Forms.PictureBox();
            this.quitForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboChoice
            // 
            this.comboChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboChoice.FormattingEnabled = true;
            this.comboChoice.Items.AddRange(new object[] {
            "Alien",
            "Dragon",
            "Hydra",
            "RedHarpy",
            "Scorpius",
            "Shadow"});
            this.comboChoice.Location = new System.Drawing.Point(45, 79);
            this.comboChoice.Name = "comboChoice";
            this.comboChoice.Size = new System.Drawing.Size(161, 28);
            this.comboChoice.TabIndex = 0;
            this.comboChoice.Text = "Choose Monster";
            this.comboChoice.SelectedIndexChanged += new System.EventHandler(this.comboChoice_SelectedIndexChanged);
            // 
            // pictureChoice
            // 
            this.pictureChoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureChoice.Location = new System.Drawing.Point(301, 79);
            this.pictureChoice.Name = "pictureChoice";
            this.pictureChoice.Size = new System.Drawing.Size(386, 375);
            this.pictureChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChoice.TabIndex = 1;
            this.pictureChoice.TabStop = false;
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(558, 496);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(129, 49);
            this.quitForm.TabIndex = 2;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 581);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.pictureChoice);
            this.Controls.Add(this.comboChoice);
            this.Name = "PictureForm";
            this.Text = "Georgia\'s Picture App";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboChoice;
        private System.Windows.Forms.PictureBox pictureChoice;
        private System.Windows.Forms.Button quitForm;
    }
}