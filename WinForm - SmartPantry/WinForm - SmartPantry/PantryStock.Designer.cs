
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
            this.personsPantryLabel = new System.Windows.Forms.Label();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pantryStockListView = new System.Windows.Forms.ListView();
            this.initialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pantryStockGroupBox = new System.Windows.Forms.GroupBox();
            this.expirationTextBox = new System.Windows.Forms.TextBox();
            this.removeStockTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RemoveStockButton = new System.Windows.Forms.Button();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.stockToRemove = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.newProduct = new System.Windows.Forms.Button();
            this.searchForProductLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.typeLabel3 = new System.Windows.Forms.Label();
            this.StockToAddLabel = new System.Windows.Forms.Label();
            this.addStockTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.addStockButton = new System.Windows.Forms.Button();
            this.actionsGroupBox.SuspendLayout();
            this.sortOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pantryStockGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(6, 6);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(94, 45);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // personsPantryLabel
            // 
            this.personsPantryLabel.AutoSize = true;
            this.personsPantryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.personsPantryLabel.Location = new System.Drawing.Point(240, 6);
            this.personsPantryLabel.Name = "personsPantryLabel";
            this.personsPantryLabel.Size = new System.Drawing.Size(205, 31);
            this.personsPantryLabel.TabIndex = 4;
            this.personsPantryLabel.Text = "Person\'s Pantry";
            // 
            // alphaCheckBox
            // 
            this.alphaCheckBox.AutoSize = true;
            this.alphaCheckBox.Checked = true;
            this.alphaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaCheckBox.Location = new System.Drawing.Point(4, 17);
            this.alphaCheckBox.Name = "alphaCheckBox";
            this.alphaCheckBox.Size = new System.Drawing.Size(41, 14);
            this.alphaCheckBox.TabIndex = 9;
            this.alphaCheckBox.Text = "A - Z";
            this.alphaCheckBox.UseVisualStyleBackColor = true;
            this.alphaCheckBox.CheckedChanged += new System.EventHandler(this.alphaCheckBox_CheckedChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCheckBox.Location = new System.Drawing.Point(4, 40);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(41, 14);
            this.typeCheckBox.TabIndex = 10;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.typeCheckBox_CheckedChanged);
            // 
            // locationCheckBox
            // 
            this.locationCheckBox.AutoSize = true;
            this.locationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCheckBox.Location = new System.Drawing.Point(4, 63);
            this.locationCheckBox.Name = "locationCheckBox";
            this.locationCheckBox.Size = new System.Drawing.Size(52, 14);
            this.locationCheckBox.TabIndex = 11;
            this.locationCheckBox.Text = "Location";
            this.locationCheckBox.UseVisualStyleBackColor = true;
            this.locationCheckBox.CheckedChanged += new System.EventHandler(this.locationCheckBox_CheckedChanged);
            // 
            // expirationCheckBox
            // 
            this.expirationCheckBox.AutoSize = true;
            this.expirationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationCheckBox.Location = new System.Drawing.Point(4, 86);
            this.expirationCheckBox.Name = "expirationCheckBox";
            this.expirationCheckBox.Size = new System.Drawing.Size(58, 14);
            this.expirationCheckBox.TabIndex = 12;
            this.expirationCheckBox.Text = "Expiration";
            this.expirationCheckBox.UseVisualStyleBackColor = true;
            this.expirationCheckBox.CheckedChanged += new System.EventHandler(this.expirationCheckBox_CheckedChanged);
            // 
            // stockCheckBox
            // 
            this.stockCheckBox.AutoSize = true;
            this.stockCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCheckBox.Location = new System.Drawing.Point(4, 109);
            this.stockCheckBox.Name = "stockCheckBox";
            this.stockCheckBox.Size = new System.Drawing.Size(43, 14);
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
            this.ascendingCheckBox.Location = new System.Drawing.Point(4, 135);
            this.ascendingCheckBox.Name = "ascendingCheckBox";
            this.ascendingCheckBox.Size = new System.Drawing.Size(59, 14);
            this.ascendingCheckBox.TabIndex = 14;
            this.ascendingCheckBox.Text = "Ascending";
            this.ascendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descendingCheckBox.Location = new System.Drawing.Point(4, 158);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(64, 14);
            this.descendingCheckBox.TabIndex = 15;
            this.descendingCheckBox.Text = "Descending";
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.removeButton);
            this.actionsGroupBox.Controls.Add(this.sortOptionsGroupBox);
            this.actionsGroupBox.Controls.Add(this.addButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(6, 54);
            this.actionsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.actionsGroupBox.Size = new System.Drawing.Size(94, 306);
            this.actionsGroupBox.TabIndex = 16;
            this.actionsGroupBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(3, 75);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 48);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.sortOptionsGroupBox.Location = new System.Drawing.Point(6, 127);
            this.sortOptionsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.sortOptionsGroupBox.Name = "sortOptionsGroupBox";
            this.sortOptionsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.sortOptionsGroupBox.Size = new System.Drawing.Size(85, 176);
            this.sortOptionsGroupBox.TabIndex = 17;
            this.sortOptionsGroupBox.TabStop = false;
            this.sortOptionsGroupBox.Text = "Sort Products";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(3, 16);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 48);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.pantryStockListView.Location = new System.Drawing.Point(16, 75);
            this.pantryStockListView.MultiSelect = false;
            this.pantryStockListView.Name = "pantryStockListView";
            this.pantryStockListView.Size = new System.Drawing.Size(446, 240);
            this.pantryStockListView.TabIndex = 6;
            this.pantryStockListView.UseCompatibleStateImageBehavior = false;
            this.pantryStockListView.View = System.Windows.Forms.View.Details;
            this.pantryStockListView.SelectedIndexChanged += new System.EventHandler(this.pantryStockListView_SelectedIndexChanged);
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
            // pantryStockGroupBox
            // 
            this.pantryStockGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pantryStockGroupBox.Controls.Add(this.addStockButton);
            this.pantryStockGroupBox.Controls.Add(this.locationTextBox);
            this.pantryStockGroupBox.Controls.Add(this.locationLabel);
            this.pantryStockGroupBox.Controls.Add(this.typeTextBox);
            this.pantryStockGroupBox.Controls.Add(this.addStockTextBox);
            this.pantryStockGroupBox.Controls.Add(this.StockToAddLabel);
            this.pantryStockGroupBox.Controls.Add(this.typeLabel3);
            this.pantryStockGroupBox.Controls.Add(this.nameLabel3);
            this.pantryStockGroupBox.Controls.Add(this.expirationTextBox);
            this.pantryStockGroupBox.Controls.Add(this.removeStockTextBox);
            this.pantryStockGroupBox.Controls.Add(this.nameTextBox);
            this.pantryStockGroupBox.Controls.Add(this.CancelButton);
            this.pantryStockGroupBox.Controls.Add(this.RemoveStockButton);
            this.pantryStockGroupBox.Controls.Add(this.expirationDateLabel);
            this.pantryStockGroupBox.Controls.Add(this.stockToRemove);
            this.pantryStockGroupBox.Controls.Add(this.nameLabel2);
            this.pantryStockGroupBox.Controls.Add(this.newProduct);
            this.pantryStockGroupBox.Controls.Add(this.pantryStockListView);
            this.pantryStockGroupBox.Controls.Add(this.searchForProductLabel);
            this.pantryStockGroupBox.Controls.Add(this.searchTextBox);
            this.pantryStockGroupBox.Location = new System.Drawing.Point(110, 39);
            this.pantryStockGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pantryStockGroupBox.Name = "pantryStockGroupBox";
            this.pantryStockGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pantryStockGroupBox.Size = new System.Drawing.Size(473, 321);
            this.pantryStockGroupBox.TabIndex = 17;
            this.pantryStockGroupBox.TabStop = false;
            // 
            // expirationTextBox
            // 
            this.expirationTextBox.Enabled = false;
            this.expirationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationTextBox.Location = new System.Drawing.Point(267, 241);
            this.expirationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expirationTextBox.Name = "expirationTextBox";
            this.expirationTextBox.Size = new System.Drawing.Size(194, 26);
            this.expirationTextBox.TabIndex = 18;
            this.expirationTextBox.Visible = false;
            // 
            // removeStockTextBox
            // 
            this.removeStockTextBox.Enabled = false;
            this.removeStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStockTextBox.Location = new System.Drawing.Point(268, 192);
            this.removeStockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.removeStockTextBox.Name = "removeStockTextBox";
            this.removeStockTextBox.Size = new System.Drawing.Size(194, 26);
            this.removeStockTextBox.TabIndex = 18;
            this.removeStockTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(268, 11);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 26);
            this.nameTextBox.TabIndex = 18;
            this.nameTextBox.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(278, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 37);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveStockButton
            // 
            this.RemoveStockButton.Enabled = false;
            this.RemoveStockButton.Location = new System.Drawing.Point(136, 277);
            this.RemoveStockButton.Name = "RemoveStockButton";
            this.RemoveStockButton.Size = new System.Drawing.Size(75, 37);
            this.RemoveStockButton.TabIndex = 18;
            this.RemoveStockButton.Text = "Remove Stock";
            this.RemoveStockButton.UseVisualStyleBackColor = true;
            this.RemoveStockButton.Visible = false;
            this.RemoveStockButton.Click += new System.EventHandler(this.RemoveStockButton_Click);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Enabled = false;
            this.expirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateLabel.Location = new System.Drawing.Point(12, 244);
            this.expirationDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(122, 20);
            this.expirationDateLabel.TabIndex = 18;
            this.expirationDateLabel.Text = "Expiration Date:";
            this.expirationDateLabel.Visible = false;
            // 
            // stockToRemove
            // 
            this.stockToRemove.AutoSize = true;
            this.stockToRemove.Enabled = false;
            this.stockToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToRemove.Location = new System.Drawing.Point(12, 198);
            this.stockToRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockToRemove.Name = "stockToRemove";
            this.stockToRemove.Size = new System.Drawing.Size(139, 20);
            this.stockToRemove.TabIndex = 18;
            this.stockToRemove.Text = "Stock To Remove:";
            this.stockToRemove.Visible = false;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Enabled = false;
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(13, 17);
            this.nameLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(55, 20);
            this.nameLabel2.TabIndex = 18;
            this.nameLabel2.Text = "Name:";
            this.nameLabel2.Visible = false;
            // 
            // newProduct
            // 
            this.newProduct.Location = new System.Drawing.Point(16, 38);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(446, 30);
            this.newProduct.TabIndex = 8;
            this.newProduct.Text = "Add New Product";
            this.newProduct.UseVisualStyleBackColor = true;
            this.newProduct.Visible = false;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // searchForProductLabel
            // 
            this.searchForProductLabel.AutoSize = true;
            this.searchForProductLabel.Location = new System.Drawing.Point(13, 4);
            this.searchForProductLabel.Name = "searchForProductLabel";
            this.searchForProductLabel.Size = new System.Drawing.Size(105, 13);
            this.searchForProductLabel.TabIndex = 7;
            this.searchForProductLabel.Text = "Search for Product...";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(16, 17);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(446, 20);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Enabled = false;
            this.nameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.Location = new System.Drawing.Point(13, 17);
            this.nameLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(55, 20);
            this.nameLabel3.TabIndex = 19;
            this.nameLabel3.Text = "Name:";
            this.nameLabel3.Visible = false;
            // 
            // typeLabel3
            // 
            this.typeLabel3.AutoSize = true;
            this.typeLabel3.Enabled = false;
            this.typeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel3.Location = new System.Drawing.Point(13, 59);
            this.typeLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel3.Name = "typeLabel3";
            this.typeLabel3.Size = new System.Drawing.Size(47, 20);
            this.typeLabel3.TabIndex = 19;
            this.typeLabel3.Text = "Type:";
            this.typeLabel3.Visible = false;
            // 
            // StockToAddLabel
            // 
            this.StockToAddLabel.AutoSize = true;
            this.StockToAddLabel.Enabled = false;
            this.StockToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockToAddLabel.Location = new System.Drawing.Point(13, 199);
            this.StockToAddLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockToAddLabel.Name = "StockToAddLabel";
            this.StockToAddLabel.Size = new System.Drawing.Size(109, 20);
            this.StockToAddLabel.TabIndex = 19;
            this.StockToAddLabel.Text = "Stock To Add:";
            this.StockToAddLabel.Visible = false;
            // 
            // addStockTextBox
            // 
            this.addStockTextBox.Enabled = false;
            this.addStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockTextBox.Location = new System.Drawing.Point(268, 196);
            this.addStockTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addStockTextBox.Name = "addStockTextBox";
            this.addStockTextBox.Size = new System.Drawing.Size(194, 26);
            this.addStockTextBox.TabIndex = 19;
            this.addStockTextBox.Visible = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(267, 59);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(194, 26);
            this.typeTextBox.TabIndex = 19;
            this.typeTextBox.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Enabled = false;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(13, 103);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 20);
            this.locationLabel.TabIndex = 20;
            this.locationLabel.Text = "Location:";
            this.locationLabel.Visible = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Enabled = false;
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(267, 103);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(194, 26);
            this.locationTextBox.TabIndex = 20;
            this.locationTextBox.Visible = false;
            // 
            // addStockButton
            // 
            this.addStockButton.Enabled = false;
            this.addStockButton.Location = new System.Drawing.Point(136, 277);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(75, 37);
            this.addStockButton.TabIndex = 19;
            this.addStockButton.Text = "Add Stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Visible = false;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // PantryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.pantryStockGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.personsPantryLabel);
            this.Controls.Add(this.homeButton);
            this.Name = "PantryStock";
            this.Text = "PantryStock";
            this.actionsGroupBox.ResumeLayout(false);
            this.sortOptionsGroupBox.ResumeLayout(false);
            this.sortOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pantryStockGroupBox.ResumeLayout(false);
            this.pantryStockGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label personsPantryLabel;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView pantryStockListView;
        private System.Windows.Forms.ColumnHeader initialColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.ColumnHeader stockColumnHeader;
        private System.Windows.Forms.GroupBox pantryStockGroupBox;
        private System.Windows.Forms.Label searchForProductLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button newProduct;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RemoveStockButton;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.Label stockToRemove;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.TextBox expirationTextBox;
        private System.Windows.Forms.TextBox removeStockTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label typeLabel3;
        private System.Windows.Forms.Label StockToAddLabel;
        private System.Windows.Forms.TextBox addStockTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button addStockButton;
    }
}