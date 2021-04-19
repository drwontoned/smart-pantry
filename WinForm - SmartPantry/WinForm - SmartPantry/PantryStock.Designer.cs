﻿
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
            this.components = new System.ComponentModel.Container();
            this.homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pantryStockListView = new System.Windows.Forms.ListView();
            this.initialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.alphaCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.locationCheckBox = new System.Windows.Forms.CheckBox();
            this.expirationCheckBox = new System.Windows.Forms.CheckBox();
            this.stockCheckBox = new System.Windows.Forms.CheckBox();
            this.ascendingCheckBox = new System.Windows.Forms.CheckBox();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.sortOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pantryStockGroupBox = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actionsGroupBox.SuspendLayout();
            this.sortOptionsGroupBox.SuspendLayout();
            this.pantryStockGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(188, 86);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(539, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Person\'s Pantry";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(31, 42);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(889, 31);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // pantryStockListView
            // 
            this.pantryStockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.initialColumnHeader,
            this.nameColumnHeader,
            this.typeColumnHeader,
            this.locationColumnHeader,
            this.stockColumnHeader});
            this.pantryStockListView.FullRowSelect = true;
            this.pantryStockListView.GridLines = true;
            this.pantryStockListView.HideSelection = false;
            this.pantryStockListView.Location = new System.Drawing.Point(31, 105);
            this.pantryStockListView.Margin = new System.Windows.Forms.Padding(6);
            this.pantryStockListView.MultiSelect = false;
            this.pantryStockListView.Name = "pantryStockListView";
            this.pantryStockListView.Size = new System.Drawing.Size(889, 472);
            this.pantryStockListView.TabIndex = 6;
            this.pantryStockListView.UseCompatibleStateImageBehavior = false;
            this.pantryStockListView.View = System.Windows.Forms.View.Details;
            // 
            // initialColumnHeader
            // 
            this.initialColumnHeader.Text = "";
            this.initialColumnHeader.Width = 0;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 192;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeColumnHeader.Width = 50;
            // 
            // locationColumnHeader
            // 
            this.locationColumnHeader.Text = "Location";
            this.locationColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.locationColumnHeader.Width = 160;
            // 
            // stockColumnHeader
            // 
            this.stockColumnHeader.Text = "Stock";
            this.stockColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stockColumnHeader.Width = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for Product...";
            // 
            // alphaCheckBox
            // 
            this.alphaCheckBox.AutoSize = true;
            this.alphaCheckBox.Checked = true;
            this.alphaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaCheckBox.Location = new System.Drawing.Point(9, 33);
            this.alphaCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.alphaCheckBox.Name = "alphaCheckBox";
            this.alphaCheckBox.Size = new System.Drawing.Size(75, 27);
            this.alphaCheckBox.TabIndex = 9;
            this.alphaCheckBox.Text = "A - Z";
            this.alphaCheckBox.UseVisualStyleBackColor = true;
            this.alphaCheckBox.CheckedChanged += new System.EventHandler(this.alphaCheckBox_CheckedChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCheckBox.Location = new System.Drawing.Point(9, 77);
            this.typeCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(75, 27);
            this.typeCheckBox.TabIndex = 10;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.typeCheckBox_CheckedChanged);
            // 
            // locationCheckBox
            // 
            this.locationCheckBox.AutoSize = true;
            this.locationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCheckBox.Location = new System.Drawing.Point(9, 121);
            this.locationCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.locationCheckBox.Name = "locationCheckBox";
            this.locationCheckBox.Size = new System.Drawing.Size(102, 27);
            this.locationCheckBox.TabIndex = 11;
            this.locationCheckBox.Text = "Location";
            this.locationCheckBox.UseVisualStyleBackColor = true;
            this.locationCheckBox.CheckedChanged += new System.EventHandler(this.locationCheckBox_CheckedChanged);
            // 
            // expirationCheckBox
            // 
            this.expirationCheckBox.AutoSize = true;
            this.expirationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationCheckBox.Location = new System.Drawing.Point(9, 166);
            this.expirationCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.expirationCheckBox.Name = "expirationCheckBox";
            this.expirationCheckBox.Size = new System.Drawing.Size(111, 27);
            this.expirationCheckBox.TabIndex = 12;
            this.expirationCheckBox.Text = "Expiration";
            this.expirationCheckBox.UseVisualStyleBackColor = true;
            this.expirationCheckBox.CheckedChanged += new System.EventHandler(this.expirationCheckBox_CheckedChanged);
            // 
            // stockCheckBox
            // 
            this.stockCheckBox.AutoSize = true;
            this.stockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCheckBox.Location = new System.Drawing.Point(9, 210);
            this.stockCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.stockCheckBox.Name = "stockCheckBox";
            this.stockCheckBox.Size = new System.Drawing.Size(82, 27);
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
            this.ascendingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascendingCheckBox.Location = new System.Drawing.Point(9, 259);
            this.ascendingCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.ascendingCheckBox.Name = "ascendingCheckBox";
            this.ascendingCheckBox.Size = new System.Drawing.Size(116, 27);
            this.ascendingCheckBox.TabIndex = 14;
            this.ascendingCheckBox.Text = "Ascending";
            this.ascendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descendingCheckBox.Location = new System.Drawing.Point(9, 303);
            this.descendingCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(126, 27);
            this.descendingCheckBox.TabIndex = 15;
            this.descendingCheckBox.Text = "Descending";
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.removeButton);
            this.actionsGroupBox.Controls.Add(this.sortOptionsGroupBox);
            this.actionsGroupBox.Controls.Add(this.addButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(12, 104);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(188, 600);
            this.actionsGroupBox.TabIndex = 16;
            this.actionsGroupBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(6, 144);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(176, 93);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // sortOptionsGroupBox
            // 
            this.sortOptionsGroupBox.Controls.Add(this.ascendingCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.alphaCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.typeCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.descendingCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.stockCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.expirationCheckBox);
            this.sortOptionsGroupBox.Controls.Add(this.locationCheckBox);
            this.sortOptionsGroupBox.Location = new System.Drawing.Point(12, 244);
            this.sortOptionsGroupBox.Name = "sortOptionsGroupBox";
            this.sortOptionsGroupBox.Size = new System.Drawing.Size(170, 348);
            this.sortOptionsGroupBox.TabIndex = 17;
            this.sortOptionsGroupBox.TabStop = false;
            this.sortOptionsGroupBox.Text = "Sort Products";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(6, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 93);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // pantryStockGroupBox
            // 
            this.pantryStockGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pantryStockGroupBox.Controls.Add(this.pantryStockListView);
            this.pantryStockGroupBox.Controls.Add(this.label2);
            this.pantryStockGroupBox.Controls.Add(this.searchTextBox);
            this.pantryStockGroupBox.Location = new System.Drawing.Point(215, 116);
            this.pantryStockGroupBox.Name = "pantryStockGroupBox";
            this.pantryStockGroupBox.Size = new System.Drawing.Size(946, 588);
            this.pantryStockGroupBox.TabIndex = 17;
            this.pantryStockGroupBox.TabStop = false;
            // 
            // PantryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 708);
            this.Controls.Add(this.pantryStockGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PantryStock";
            this.Text = "PantryStock";
            this.actionsGroupBox.ResumeLayout(false);
            this.sortOptionsGroupBox.ResumeLayout(false);
            this.sortOptionsGroupBox.PerformLayout();
            this.pantryStockGroupBox.ResumeLayout(false);
            this.pantryStockGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView pantryStockListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox alphaCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox locationCheckBox;
        private System.Windows.Forms.CheckBox expirationCheckBox;
        private System.Windows.Forms.CheckBox stockCheckBox;
        private System.Windows.Forms.CheckBox ascendingCheckBox;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.GroupBox sortOptionsGroupBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox pantryStockGroupBox;
        private System.Windows.Forms.ColumnHeader initialColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader stockColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}