namespace WindowsFormsApp1
{
    partial class TargetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetForm));
            this.quitForm = new System.Windows.Forms.Button();
            this.stopForm = new System.Windows.Forms.Button();
            this.startForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(620, 516);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(140, 45);
            this.quitForm.TabIndex = 1;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // stopForm
            // 
            this.stopForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopForm.Location = new System.Drawing.Point(328, 516);
            this.stopForm.Name = "stopForm";
            this.stopForm.Size = new System.Drawing.Size(140, 45);
            this.stopForm.TabIndex = 2;
            this.stopForm.Text = "Stop";
            this.stopForm.UseVisualStyleBackColor = true;
            this.stopForm.Click += new System.EventHandler(this.stopForm_Click);
            // 
            // startForm
            // 
            this.startForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startForm.Location = new System.Drawing.Point(30, 516);
            this.startForm.Name = "startForm";
            this.startForm.Size = new System.Drawing.Size(140, 45);
            this.startForm.TabIndex = 3;
            this.startForm.Text = "Start";
            this.startForm.UseVisualStyleBackColor = true;
            this.startForm.Click += new System.EventHandler(this.startForm_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultsBox.Controls.Add(this.scoreLabel);
            this.resultsBox.Controls.Add(this.label1);
            this.resultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultsBox.Location = new System.Drawing.Point(610, 38);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(282, 216);
            this.resultsBox.TabIndex = 4;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoot the Target!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 446);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(11, 102);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 29);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // TargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(904, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.startForm);
            this.Controls.Add(this.stopForm);
            this.Controls.Add(this.quitForm);
            this.Name = "TargetForm";
            this.Text = "Georgia\'s Target Game";
            this.Load += new System.EventHandler(this.TargetForm_Load);
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Button stopForm;
        private System.Windows.Forms.Button startForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}