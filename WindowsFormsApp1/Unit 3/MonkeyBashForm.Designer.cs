namespace WindowsFormsApp1
{
    partial class MonkeyBashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyBashForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startForm = new System.Windows.Forms.Button();
            this.stopForm = new System.Windows.Forms.Button();
            this.quitForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalHits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // startForm
            // 
            this.startForm.BackColor = System.Drawing.Color.Yellow;
            this.startForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startForm.Location = new System.Drawing.Point(57, 537);
            this.startForm.Name = "startForm";
            this.startForm.Size = new System.Drawing.Size(129, 43);
            this.startForm.TabIndex = 1;
            this.startForm.Text = "Start";
            this.startForm.UseVisualStyleBackColor = false;
            this.startForm.Click += new System.EventHandler(this.startForm_Click);
            // 
            // stopForm
            // 
            this.stopForm.BackColor = System.Drawing.Color.Yellow;
            this.stopForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stopForm.Location = new System.Drawing.Point(277, 537);
            this.stopForm.Name = "stopForm";
            this.stopForm.Size = new System.Drawing.Size(126, 43);
            this.stopForm.TabIndex = 2;
            this.stopForm.Text = "Stop";
            this.stopForm.UseVisualStyleBackColor = false;
            this.stopForm.Click += new System.EventHandler(this.stopForm_Click);
            // 
            // quitForm
            // 
            this.quitForm.BackColor = System.Drawing.Color.Yellow;
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(506, 537);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(124, 43);
            this.quitForm.TabIndex = 3;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = false;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalHits);
            this.groupBox1.Location = new System.Drawing.Point(698, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalHits
            // 
            this.labelTotalHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTotalHits.Location = new System.Drawing.Point(19, 29);
            this.labelTotalHits.Name = "labelTotalHits";
            this.labelTotalHits.Size = new System.Drawing.Size(70, 34);
            this.labelTotalHits.TabIndex = 0;
            this.labelTotalHits.Click += new System.EventHandler(this.labelTotalHits_Click);
            // 
            // MonkeyBashForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.stopForm;
            this.ClientSize = new System.Drawing.Size(868, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.stopForm);
            this.Controls.Add(this.startForm);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MonkeyBashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Georgia\'s Monkey Bash";
            this.Load += new System.EventHandler(this.MonkeyBashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startForm;
        private System.Windows.Forms.Button stopForm;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalHits;
    }
}