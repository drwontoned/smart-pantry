
namespace WinForm___SmartPantry
{
    partial class PantryStock
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
            this.homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pantryStockListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alphaCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.locationCheckBox = new System.Windows.Forms.CheckBox();
            this.expirationCheckBox = new System.Windows.Forms.CheckBox();
            this.stockCheckBox = new System.Windows.Forms.CheckBox();
            this.ascendingCheckBox = new System.Windows.Forms.CheckBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(11, 11);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(94, 45);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Person\'s Pantry";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(128, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(494, 20);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // pantryStockListView
            // 
            this.pantryStockListView.HideSelection = false;
            this.pantryStockListView.Location = new System.Drawing.Point(128, 96);
            this.pantryStockListView.Name = "pantryStockListView";
            this.pantryStockListView.Size = new System.Drawing.Size(494, 339);
            this.pantryStockListView.TabIndex = 6;
            this.pantryStockListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for Product...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort Products";
            // 
            // alphaCheckBox
            // 
            this.alphaCheckBox.AutoSize = true;
            this.alphaCheckBox.Location = new System.Drawing.Point(12, 132);
            this.alphaCheckBox.Name = "alphaCheckBox";
            this.alphaCheckBox.Size = new System.Drawing.Size(49, 17);
            this.alphaCheckBox.TabIndex = 9;
            this.alphaCheckBox.Text = "A - Z";
            this.alphaCheckBox.UseVisualStyleBackColor = true;
            this.alphaCheckBox.CheckedChanged += new System.EventHandler(this.alphaCheckBox_CheckedChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(12, 155);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(50, 17);
            this.typeCheckBox.TabIndex = 10;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.typeCheckBox_CheckedChanged);
            // 
            // locationCheckBox
            // 
            this.locationCheckBox.AutoSize = true;
            this.locationCheckBox.Location = new System.Drawing.Point(12, 178);
            this.locationCheckBox.Name = "locationCheckBox";
            this.locationCheckBox.Size = new System.Drawing.Size(67, 17);
            this.locationCheckBox.TabIndex = 11;
            this.locationCheckBox.Text = "Location";
            this.locationCheckBox.UseVisualStyleBackColor = true;
            this.locationCheckBox.CheckedChanged += new System.EventHandler(this.locationCheckBox_CheckedChanged);
            // 
            // expirationCheckBox
            // 
            this.expirationCheckBox.AutoSize = true;
            this.expirationCheckBox.Location = new System.Drawing.Point(12, 201);
            this.expirationCheckBox.Name = "expirationCheckBox";
            this.expirationCheckBox.Size = new System.Drawing.Size(72, 17);
            this.expirationCheckBox.TabIndex = 12;
            this.expirationCheckBox.Text = "Expiration";
            this.expirationCheckBox.UseVisualStyleBackColor = true;
            this.expirationCheckBox.CheckedChanged += new System.EventHandler(this.expirationCheckBox_CheckedChanged);
            // 
            // stockCheckBox
            // 
            this.stockCheckBox.AutoSize = true;
            this.stockCheckBox.Location = new System.Drawing.Point(12, 224);
            this.stockCheckBox.Name = "stockCheckBox";
            this.stockCheckBox.Size = new System.Drawing.Size(54, 17);
            this.stockCheckBox.TabIndex = 13;
            this.stockCheckBox.Text = "Stock";
            this.stockCheckBox.UseVisualStyleBackColor = true;
            this.stockCheckBox.CheckedChanged += new System.EventHandler(this.stockCheckBox_CheckedChanged);
            // 
            // ascendingCheckBox
            // 
            this.ascendingCheckBox.AutoSize = true;
            this.ascendingCheckBox.Checked = true;
            this.ascendingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ascendingCheckBox.Location = new System.Drawing.Point(12, 349);
            this.ascendingCheckBox.Name = "ascendingCheckBox";
            this.ascendingCheckBox.Size = new System.Drawing.Size(76, 17);
            this.ascendingCheckBox.TabIndex = 14;
            this.ascendingCheckBox.Text = "Ascending";
            this.ascendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Location = new System.Drawing.Point(12, 372);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(83, 17);
            this.descendingCheckBox.TabIndex = 15;
            this.descendingCheckBox.Text = "Descending";
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // PantryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 447);
            this.Controls.Add(this.descendingCheckBox);
            this.Controls.Add(this.ascendingCheckBox);
            this.Controls.Add(this.stockCheckBox);
            this.Controls.Add(this.expirationCheckBox);
            this.Controls.Add(this.locationCheckBox);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.alphaCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pantryStockListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeButton);
            this.Name = "PantryStock";
            this.Text = "PantryStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView pantryStockListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox alphaCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox locationCheckBox;
        private System.Windows.Forms.CheckBox expirationCheckBox;
        private System.Windows.Forms.CheckBox stockCheckBox;
        private System.Windows.Forms.CheckBox ascendingCheckBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
    }
}