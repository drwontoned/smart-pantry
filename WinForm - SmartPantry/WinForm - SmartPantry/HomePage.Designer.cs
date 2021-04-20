namespace WinForm___SmartPantry
{
    partial class HomePage
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
            this.viewPantryButton = new System.Windows.Forms.Button();
            this.viewExpirationDatesButton = new System.Windows.Forms.Button();
            this.viewShoppingListButton = new System.Windows.Forms.Button();
            this.HomePagePantry = new System.Windows.Forms.ListBox();
            this.personsPantryLabel = new System.Windows.Forms.Label();
            this.expirationsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // viewPantryButton
            // 
            this.viewPantryButton.Location = new System.Drawing.Point(408, 97);
            this.viewPantryButton.MaximumSize = new System.Drawing.Size(341, 150);
            this.viewPantryButton.MinimumSize = new System.Drawing.Size(341, 150);
            this.viewPantryButton.Name = "viewPantryButton";
            this.viewPantryButton.Size = new System.Drawing.Size(341, 150);
            this.viewPantryButton.TabIndex = 0;
            this.viewPantryButton.Text = "View Pantry Stock";
            this.viewPantryButton.UseMnemonic = false;
            this.viewPantryButton.UseVisualStyleBackColor = true;
            this.viewPantryButton.Click += new System.EventHandler(this.viewPantryButton_Click);
            // 
            // viewExpirationDatesButton
            // 
            this.viewExpirationDatesButton.Location = new System.Drawing.Point(408, 285);
            this.viewExpirationDatesButton.MaximumSize = new System.Drawing.Size(150, 150);
            this.viewExpirationDatesButton.MinimumSize = new System.Drawing.Size(150, 150);
            this.viewExpirationDatesButton.Name = "viewExpirationDatesButton";
            this.viewExpirationDatesButton.Size = new System.Drawing.Size(150, 150);
            this.viewExpirationDatesButton.TabIndex = 2;
            this.viewExpirationDatesButton.Text = "View Expiration Dates";
            this.viewExpirationDatesButton.UseVisualStyleBackColor = true;
            this.viewExpirationDatesButton.Click += new System.EventHandler(this.viewExpirationDatesButton_Click);
            // 
            // viewShoppingListButton
            // 
            this.viewShoppingListButton.Location = new System.Drawing.Point(600, 285);
            this.viewShoppingListButton.MaximumSize = new System.Drawing.Size(150, 150);
            this.viewShoppingListButton.MinimumSize = new System.Drawing.Size(150, 150);
            this.viewShoppingListButton.Name = "viewShoppingListButton";
            this.viewShoppingListButton.Size = new System.Drawing.Size(150, 150);
            this.viewShoppingListButton.TabIndex = 3;
            this.viewShoppingListButton.Text = "View Shopping List";
            this.viewShoppingListButton.UseVisualStyleBackColor = true;
            this.viewShoppingListButton.Click += new System.EventHandler(this.viewShoppingListButton_Click);
            // 
            // HomePagePantry
            // 
            this.HomePagePantry.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePagePantry.FormattingEnabled = true;
            this.HomePagePantry.ItemHeight = 23;
            this.HomePagePantry.Location = new System.Drawing.Point(12, 53);
            this.HomePagePantry.MaximumSize = new System.Drawing.Size(351, 382);
            this.HomePagePantry.MinimumSize = new System.Drawing.Size(351, 382);
            this.HomePagePantry.Name = "HomePagePantry";
            this.HomePagePantry.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.HomePagePantry.Size = new System.Drawing.Size(351, 372);
            this.HomePagePantry.TabIndex = 4;
            // 
            // personsPantryLabel
            // 
            this.personsPantryLabel.AutoSize = true;
            this.personsPantryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personsPantryLabel.Location = new System.Drawing.Point(55, 11);
            this.personsPantryLabel.Name = "personsPantryLabel";
            this.personsPantryLabel.Size = new System.Drawing.Size(248, 38);
            this.personsPantryLabel.TabIndex = 5;
            this.personsPantryLabel.Text = "Person\'s Pantry";
            // 
            // expirationsBox
            // 
            this.expirationsBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationsBox.ForeColor = System.Drawing.Color.Blue;
            this.expirationsBox.FormattingEnabled = true;
            this.expirationsBox.ItemHeight = 20;
            this.expirationsBox.Location = new System.Drawing.Point(407, 22);
            this.expirationsBox.MaximumSize = new System.Drawing.Size(342, 44);
            this.expirationsBox.MinimumSize = new System.Drawing.Size(342, 44);
            this.expirationsBox.Name = "expirationsBox";
            this.expirationsBox.Size = new System.Drawing.Size(342, 44);
            this.expirationsBox.TabIndex = 7;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.expirationsBox);
            this.Controls.Add(this.personsPantryLabel);
            this.Controls.Add(this.HomePagePantry);
            this.Controls.Add(this.viewShoppingListButton);
            this.Controls.Add(this.viewExpirationDatesButton);
            this.Controls.Add(this.viewPantryButton);
            this.Name = "HomePage";
            this.Text = "SmartPantry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewPantryButton;
        private System.Windows.Forms.Button viewExpirationDatesButton;
        private System.Windows.Forms.Button viewShoppingListButton;
        private System.Windows.Forms.ListBox HomePagePantry;
        private System.Windows.Forms.Label personsPantryLabel;
        private System.Windows.Forms.ListBox expirationsBox;
    }
}

