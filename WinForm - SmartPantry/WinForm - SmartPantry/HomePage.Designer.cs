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
            this.productManagementButton = new System.Windows.Forms.Button();
            this.viewExpirationDatesButton = new System.Windows.Forms.Button();
            this.viewShoppingListButton = new System.Windows.Forms.Button();
            this.HomePagePantry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewPantryButton
            // 
            this.viewPantryButton.Location = new System.Drawing.Point(306, 79);
            this.viewPantryButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewPantryButton.MaximumSize = new System.Drawing.Size(112, 122);
            this.viewPantryButton.MinimumSize = new System.Drawing.Size(112, 122);
            this.viewPantryButton.Name = "viewPantryButton";
            this.viewPantryButton.Size = new System.Drawing.Size(112, 122);
            this.viewPantryButton.TabIndex = 0;
            this.viewPantryButton.Text = "View Pantry Stock";
            this.viewPantryButton.UseVisualStyleBackColor = true;
            this.viewPantryButton.Click += new System.EventHandler(this.viewPantryButton_Click);
            // 
            // productManagementButton
            // 
            this.productManagementButton.Location = new System.Drawing.Point(450, 79);
            this.productManagementButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.productManagementButton.MaximumSize = new System.Drawing.Size(112, 122);
            this.productManagementButton.MinimumSize = new System.Drawing.Size(112, 122);
            this.productManagementButton.Name = "productManagementButton";
            this.productManagementButton.Size = new System.Drawing.Size(112, 122);
            this.productManagementButton.TabIndex = 1;
            this.productManagementButton.Text = "Add/Remove Products";
            this.productManagementButton.UseVisualStyleBackColor = true;
            // 
            // viewExpirationDatesButton
            // 
            this.viewExpirationDatesButton.Location = new System.Drawing.Point(306, 231);
            this.viewExpirationDatesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewExpirationDatesButton.MaximumSize = new System.Drawing.Size(112, 122);
            this.viewExpirationDatesButton.MinimumSize = new System.Drawing.Size(112, 122);
            this.viewExpirationDatesButton.Name = "viewExpirationDatesButton";
            this.viewExpirationDatesButton.Size = new System.Drawing.Size(112, 122);
            this.viewExpirationDatesButton.TabIndex = 2;
            this.viewExpirationDatesButton.Text = "View Expiration Dates";
            this.viewExpirationDatesButton.UseVisualStyleBackColor = true;
            // 
            // viewShoppingListButton
            // 
            this.viewShoppingListButton.Location = new System.Drawing.Point(450, 231);
            this.viewShoppingListButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewShoppingListButton.MaximumSize = new System.Drawing.Size(112, 122);
            this.viewShoppingListButton.MinimumSize = new System.Drawing.Size(112, 122);
            this.viewShoppingListButton.Name = "viewShoppingListButton";
            this.viewShoppingListButton.Size = new System.Drawing.Size(112, 122);
            this.viewShoppingListButton.TabIndex = 3;
            this.viewShoppingListButton.Text = "View Shopping List";
            this.viewShoppingListButton.UseVisualStyleBackColor = true;
            this.viewShoppingListButton.Click += new System.EventHandler(this.viewShoppingListButton_Click);
            // 
            // HomePagePantry
            // 
            this.HomePagePantry.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePagePantry.FormattingEnabled = true;
            this.HomePagePantry.ItemHeight = 22;
            this.HomePagePantry.Location = new System.Drawing.Point(9, 43);
            this.HomePagePantry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HomePagePantry.MaximumSize = new System.Drawing.Size(264, 311);
            this.HomePagePantry.MinimumSize = new System.Drawing.Size(264, 311);
            this.HomePagePantry.Name = "HomePagePantry";
            this.HomePagePantry.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.HomePagePantry.Size = new System.Drawing.Size(264, 290);
            this.HomePagePantry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Person\'s Pantry";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomePagePantry);
            this.Controls.Add(this.viewShoppingListButton);
            this.Controls.Add(this.viewExpirationDatesButton);
            this.Controls.Add(this.productManagementButton);
            this.Controls.Add(this.viewPantryButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "HomePage";
            this.Text = "SmartPantry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewPantryButton;
        private System.Windows.Forms.Button productManagementButton;
        private System.Windows.Forms.Button viewExpirationDatesButton;
        private System.Windows.Forms.Button viewShoppingListButton;
        private System.Windows.Forms.ListBox HomePagePantry;
        private System.Windows.Forms.Label label1;
    }
}

