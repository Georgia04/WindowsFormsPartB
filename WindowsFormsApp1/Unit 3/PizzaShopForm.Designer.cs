namespace WindowsFormsApp1
{
    partial class PizzaShopForm
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
            this.pizzaPrice = new System.Windows.Forms.GroupBox();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.endPrice = new System.Windows.Forms.GroupBox();
            this.finalPrice = new System.Windows.Forms.TextBox();
            this.toppingPrice = new System.Windows.Forms.GroupBox();
            this.bbq = new System.Windows.Forms.CheckBox();
            this.chocolate = new System.Windows.Forms.CheckBox();
            this.pepperoniVindaloo = new System.Windows.Forms.CheckBox();
            this.rhubarb = new System.Windows.Forms.CheckBox();
            this.pineapple = new System.Windows.Forms.CheckBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.pizzaPrice.SuspendLayout();
            this.endPrice.SuspendLayout();
            this.toppingPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaPrice
            // 
            this.pizzaPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pizzaPrice.Controls.Add(this.smallRadio);
            this.pizzaPrice.Controls.Add(this.mediumRadio);
            this.pizzaPrice.Controls.Add(this.largeRadio);
            this.pizzaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pizzaPrice.Location = new System.Drawing.Point(39, 54);
            this.pizzaPrice.Name = "pizzaPrice";
            this.pizzaPrice.Size = new System.Drawing.Size(200, 235);
            this.pizzaPrice.TabIndex = 1;
            this.pizzaPrice.TabStop = false;
            this.pizzaPrice.Text = "Pizza Type";
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.smallRadio.Location = new System.Drawing.Point(17, 185);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(82, 29);
            this.smallRadio.TabIndex = 2;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small";
            this.smallRadio.UseVisualStyleBackColor = true;
            this.smallRadio.CheckedChanged += new System.EventHandler(this.smallRadio_CheckedChanged);
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mediumRadio.Location = new System.Drawing.Point(17, 126);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(103, 29);
            this.mediumRadio.TabIndex = 1;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = true;
            this.mediumRadio.CheckedChanged += new System.EventHandler(this.mediumRadio_CheckedChanged);
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.largeRadio.Location = new System.Drawing.Point(17, 65);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(83, 29);
            this.largeRadio.TabIndex = 0;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large";
            this.largeRadio.UseVisualStyleBackColor = true;
            this.largeRadio.CheckedChanged += new System.EventHandler(this.largeRadio_CheckedChanged);
            // 
            // endPrice
            // 
            this.endPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.endPrice.Controls.Add(this.finalPrice);
            this.endPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.endPrice.Location = new System.Drawing.Point(39, 434);
            this.endPrice.Name = "endPrice";
            this.endPrice.Size = new System.Drawing.Size(207, 91);
            this.endPrice.TabIndex = 2;
            this.endPrice.TabStop = false;
            this.endPrice.Text = "Pizza Cost";
            // 
            // finalPrice
            // 
            this.finalPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.finalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.finalPrice.Location = new System.Drawing.Point(34, 40);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(100, 29);
            this.finalPrice.TabIndex = 0;
            // 
            // toppingPrice
            // 
            this.toppingPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toppingPrice.Controls.Add(this.bbq);
            this.toppingPrice.Controls.Add(this.chocolate);
            this.toppingPrice.Controls.Add(this.pepperoniVindaloo);
            this.toppingPrice.Controls.Add(this.rhubarb);
            this.toppingPrice.Controls.Add(this.pineapple);
            this.toppingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toppingPrice.Location = new System.Drawing.Point(488, 54);
            this.toppingPrice.Name = "toppingPrice";
            this.toppingPrice.Size = new System.Drawing.Size(395, 405);
            this.toppingPrice.TabIndex = 3;
            this.toppingPrice.TabStop = false;
            this.toppingPrice.Text = "Toppings";
            // 
            // bbq
            // 
            this.bbq.AutoSize = true;
            this.bbq.Location = new System.Drawing.Point(35, 323);
            this.bbq.Name = "bbq";
            this.bbq.Size = new System.Drawing.Size(81, 30);
            this.bbq.TabIndex = 4;
            this.bbq.Text = "BBQ";
            this.bbq.UseVisualStyleBackColor = true;
            this.bbq.CheckedChanged += new System.EventHandler(this.bbq_CheckedChanged);
            // 
            // chocolate
            // 
            this.chocolate.AutoSize = true;
            this.chocolate.Location = new System.Drawing.Point(35, 258);
            this.chocolate.Name = "chocolate";
            this.chocolate.Size = new System.Drawing.Size(132, 30);
            this.chocolate.TabIndex = 3;
            this.chocolate.Text = "Chocolate";
            this.chocolate.UseVisualStyleBackColor = true;
            this.chocolate.CheckedChanged += new System.EventHandler(this.chocolate_CheckedChanged);
            // 
            // pepperoniVindaloo
            // 
            this.pepperoniVindaloo.AutoSize = true;
            this.pepperoniVindaloo.Location = new System.Drawing.Point(35, 194);
            this.pepperoniVindaloo.Name = "pepperoniVindaloo";
            this.pepperoniVindaloo.Size = new System.Drawing.Size(224, 30);
            this.pepperoniVindaloo.TabIndex = 2;
            this.pepperoniVindaloo.Text = "Pepperoni Vindaloo";
            this.pepperoniVindaloo.UseVisualStyleBackColor = true;
            this.pepperoniVindaloo.CheckedChanged += new System.EventHandler(this.pepperoniVindaloo_CheckedChanged);
            // 
            // rhubarb
            // 
            this.rhubarb.AutoSize = true;
            this.rhubarb.Location = new System.Drawing.Point(35, 128);
            this.rhubarb.Name = "rhubarb";
            this.rhubarb.Size = new System.Drawing.Size(117, 30);
            this.rhubarb.TabIndex = 1;
            this.rhubarb.Text = "Rhubarb";
            this.rhubarb.UseVisualStyleBackColor = true;
            this.rhubarb.CheckedChanged += new System.EventHandler(this.rhubarb_CheckedChanged);
            // 
            // pineapple
            // 
            this.pineapple.AutoSize = true;
            this.pineapple.Location = new System.Drawing.Point(35, 65);
            this.pineapple.Name = "pineapple";
            this.pineapple.Size = new System.Drawing.Size(131, 30);
            this.pineapple.TabIndex = 0;
            this.pineapple.Text = "Pineapple";
            this.pineapple.UseVisualStyleBackColor = true;
            this.pineapple.CheckedChanged += new System.EventHandler(this.pineapple_CheckedChanged);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quitButton.Location = new System.Drawing.Point(761, 554);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(122, 53);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // PizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1033, 645);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.toppingPrice);
            this.Controls.Add(this.endPrice);
            this.Controls.Add(this.pizzaPrice);
            this.Name = "PizzaShopForm";
            this.Text = "Georgia\'s Pizza Shop";
            this.Load += new System.EventHandler(this.pizzaShopForm_Load);
            this.pizzaPrice.ResumeLayout(false);
            this.pizzaPrice.PerformLayout();
            this.endPrice.ResumeLayout(false);
            this.endPrice.PerformLayout();
            this.toppingPrice.ResumeLayout(false);
            this.toppingPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pizzaPrice;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.GroupBox endPrice;
        private System.Windows.Forms.GroupBox toppingPrice;
        private System.Windows.Forms.CheckBox bbq;
        private System.Windows.Forms.CheckBox chocolate;
        private System.Windows.Forms.CheckBox pepperoniVindaloo;
        private System.Windows.Forms.CheckBox rhubarb;
        private System.Windows.Forms.CheckBox pineapple;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox finalPrice;
    }
}