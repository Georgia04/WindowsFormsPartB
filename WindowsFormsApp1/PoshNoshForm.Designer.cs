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
            this.mainMenu = new System.Windows.Forms.GroupBox();
            this.mainList = new System.Windows.Forms.ListBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.mainList);
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mainMenu.Location = new System.Drawing.Point(38, 60);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(357, 245);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStop = false;
            this.mainMenu.Text = "Main Course";
            // 
            // mainList
            // 
            this.mainList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainList.FormattingEnabled = true;
            this.mainList.ItemHeight = 29;
            this.mainList.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.mainList.Location = new System.Drawing.Point(25, 35);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(304, 174);
            this.mainList.Sorted = true;
            this.mainList.TabIndex = 0;
            // 
            // PoshNoshForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 621);
            this.Controls.Add(this.mainMenu);
            this.Name = "PoshNoshForn";
            this.Text = "Georgia\'s Posh Nosh";
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainMenu;
        private System.Windows.Forms.ListBox mainList;
    }
}