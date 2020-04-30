namespace WindowsFormsApp1
{
    partial class PoshNoshForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoshNoshForm));
            this.starterCost = new System.Windows.Forms.GroupBox();
            this.starterMenu = new System.Windows.Forms.ListBox();
            this.mainmenuCost = new System.Windows.Forms.GroupBox();
            this.mainMenu = new System.Windows.Forms.ListBox();
            this.totalCost = new System.Windows.Forms.GroupBox();
            this.FinalCost = new System.Windows.Forms.Label();
            this.dessertCost = new System.Windows.Forms.GroupBox();
            this.dessertMenu = new System.Windows.Forms.ComboBox();
            this.quitForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.starterCost.SuspendLayout();
            this.mainmenuCost.SuspendLayout();
            this.totalCost.SuspendLayout();
            this.dessertCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // starterCost
            // 
            this.starterCost.Controls.Add(this.starterMenu);
            this.starterCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.starterCost.Location = new System.Drawing.Point(621, 25);
            this.starterCost.Name = "starterCost";
            this.starterCost.Size = new System.Drawing.Size(328, 242);
            this.starterCost.TabIndex = 0;
            this.starterCost.TabStop = false;
            this.starterCost.Text = "Starter";
            // 
            // starterMenu
            // 
            this.starterMenu.BackColor = System.Drawing.Color.Moccasin;
            this.starterMenu.FormattingEnabled = true;
            this.starterMenu.ItemHeight = 29;
            this.starterMenu.Items.AddRange(new object[] {
            "Burger",
            "Meat Balls",
            "Soup of the Day",
            "Spaghetti Bolognese"});
            this.starterMenu.Location = new System.Drawing.Point(16, 44);
            this.starterMenu.Name = "starterMenu";
            this.starterMenu.Size = new System.Drawing.Size(292, 178);
            this.starterMenu.Sorted = true;
            this.starterMenu.TabIndex = 0;
            this.starterMenu.SelectedIndexChanged += new System.EventHandler(this.selectStarterMenu);
            // 
            // mainmenuCost
            // 
            this.mainmenuCost.Controls.Add(this.mainMenu);
            this.mainmenuCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mainmenuCost.Location = new System.Drawing.Point(622, 315);
            this.mainmenuCost.Name = "mainmenuCost";
            this.mainmenuCost.Size = new System.Drawing.Size(327, 242);
            this.mainmenuCost.TabIndex = 1;
            this.mainmenuCost.TabStop = false;
            this.mainmenuCost.Text = "Main Menu";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Moccasin;
            this.mainMenu.FormattingEnabled = true;
            this.mainMenu.ItemHeight = 29;
            this.mainMenu.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.mainMenu.Location = new System.Drawing.Point(25, 44);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(279, 178);
            this.mainMenu.Sorted = true;
            this.mainMenu.TabIndex = 0;
            this.mainMenu.SelectedIndexChanged += new System.EventHandler(this.selectMainMenu);
            // 
            // totalCost
            // 
            this.totalCost.Controls.Add(this.FinalCost);
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalCost.Location = new System.Drawing.Point(411, 619);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(200, 100);
            this.totalCost.TabIndex = 2;
            this.totalCost.TabStop = false;
            this.totalCost.Text = "Total Price";
            // 
            // FinalCost
            // 
            this.FinalCost.BackColor = System.Drawing.SystemColors.Info;
            this.FinalCost.Location = new System.Drawing.Point(24, 44);
            this.FinalCost.Name = "FinalCost";
            this.FinalCost.Size = new System.Drawing.Size(121, 37);
            this.FinalCost.TabIndex = 0;
            // 
            // dessertCost
            // 
            this.dessertCost.Controls.Add(this.dessertMenu);
            this.dessertCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dessertCost.Location = new System.Drawing.Point(43, 487);
            this.dessertCost.Name = "dessertCost";
            this.dessertCost.Size = new System.Drawing.Size(305, 134);
            this.dessertCost.TabIndex = 3;
            this.dessertCost.TabStop = false;
            this.dessertCost.Text = "Dessert";
            // 
            // dessertMenu
            // 
            this.dessertMenu.BackColor = System.Drawing.Color.Moccasin;
            this.dessertMenu.FormattingEnabled = true;
            this.dessertMenu.Items.AddRange(new object[] {
            "Fruit Cake",
            "Knickerbocker Glory",
            "Banoffee Pie",
            "Figgy Pudding"});
            this.dessertMenu.Location = new System.Drawing.Point(15, 49);
            this.dessertMenu.Name = "dessertMenu";
            this.dessertMenu.Size = new System.Drawing.Size(270, 37);
            this.dessertMenu.TabIndex = 0;
            this.dessertMenu.Text = "Dessert Choices";
            this.dessertMenu.SelectedIndexChanged += new System.EventHandler(this.selectDesertMenu);
            // 
            // quitForm
            // 
            this.quitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitForm.Location = new System.Drawing.Point(825, 682);
            this.quitForm.Name = "quitForm";
            this.quitForm.Size = new System.Drawing.Size(124, 51);
            this.quitForm.TabIndex = 4;
            this.quitForm.Text = "Quit";
            this.quitForm.UseVisualStyleBackColor = true;
            this.quitForm.Click += new System.EventHandler(this.quitForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PoshNoshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1004, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitForm);
            this.Controls.Add(this.dessertCost);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.mainmenuCost);
            this.Controls.Add(this.starterCost);
            this.Name = "PoshNoshForm";
            this.Text = "Georgia\'s Posh Nosh";
            this.starterCost.ResumeLayout(false);
            this.mainmenuCost.ResumeLayout(false);
            this.totalCost.ResumeLayout(false);
            this.dessertCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox starterCost;
        private System.Windows.Forms.ListBox starterMenu;
        private System.Windows.Forms.GroupBox mainmenuCost;
        private System.Windows.Forms.ListBox mainMenu;
        private System.Windows.Forms.GroupBox totalCost;
        private System.Windows.Forms.Label FinalCost;
        private System.Windows.Forms.GroupBox dessertCost;
        private System.Windows.Forms.ComboBox dessertMenu;
        private System.Windows.Forms.Button quitForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}