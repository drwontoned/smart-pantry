
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
            this.newProduct = new System.Windows.Forms.Button();
            this.searchForProductLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.addStockButton = new System.Windows.Forms.Button();
            this.stockToAddRequiredLabel = new System.Windows.Forms.Label();
            this.nameRequiredLabel = new System.Windows.Forms.Label();
            this.stockToAddTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.stockToAddLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.expirationTextBox = new System.Windows.Forms.TextBox();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.locationIndexLabel = new System.Windows.Forms.Label();
            this.stockToAddIndexLabel = new System.Windows.Forms.Label();
            this.typeIndexLabel = new System.Windows.Forms.Label();
            this.nameIndexLabel = new System.Windows.Forms.Label();
            this.locationIndexDataLabel = new System.Windows.Forms.Label();
            this.stockToAddIndexDataLabel = new System.Windows.Forms.Label();
            this.typeIndexDataLabel = new System.Windows.Forms.Label();
            this.nameIndexDataLabel = new System.Windows.Forms.Label();
            this.expirationIndexLabel = new System.Windows.Forms.Label();
            this.expirationListBox = new System.Windows.Forms.ListBox();
            this.removeStockButton = new System.Windows.Forms.Button();
            this.removeCancelButton = new System.Windows.Forms.Button();
            this.actionsGroupBox.SuspendLayout();
            this.sortOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pantryStockGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(188, 87);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // personsPantryLabel
            // 
            this.personsPantryLabel.AutoSize = true;
            this.personsPantryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.personsPantryLabel.Location = new System.Drawing.Point(480, 12);
            this.personsPantryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.personsPantryLabel.Name = "personsPantryLabel";
            this.personsPantryLabel.Size = new System.Drawing.Size(398, 61);
            this.personsPantryLabel.TabIndex = 4;
            this.personsPantryLabel.Text = "Person\'s Pantry";
            // 
            // alphaCheckBox
            // 
            this.alphaCheckBox.AutoSize = true;
            this.alphaCheckBox.Checked = true;
            this.alphaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaCheckBox.Location = new System.Drawing.Point(8, 33);
            this.alphaCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.typeCheckBox.Location = new System.Drawing.Point(8, 77);
            this.typeCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.locationCheckBox.Location = new System.Drawing.Point(8, 121);
            this.locationCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.expirationCheckBox.Location = new System.Drawing.Point(8, 165);
            this.expirationCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.stockCheckBox.Location = new System.Drawing.Point(8, 210);
            this.stockCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.ascendingCheckBox.Location = new System.Drawing.Point(8, 260);
            this.ascendingCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.descendingCheckBox.Location = new System.Drawing.Point(8, 304);
            this.descendingCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.actionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionsGroupBox.Size = new System.Drawing.Size(188, 588);
            this.actionsGroupBox.TabIndex = 16;
            this.actionsGroupBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(6, 144);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(176, 92);
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
            this.sortOptionsGroupBox.Location = new System.Drawing.Point(12, 244);
            this.sortOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortOptionsGroupBox.Name = "sortOptionsGroupBox";
            this.sortOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortOptionsGroupBox.Size = new System.Drawing.Size(170, 338);
            this.sortOptionsGroupBox.TabIndex = 17;
            this.sortOptionsGroupBox.TabStop = false;
            this.sortOptionsGroupBox.Text = "Sort Products";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(6, 31);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 92);
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
            this.pantryStockListView.Location = new System.Drawing.Point(32, 144);
            this.pantryStockListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pantryStockListView.MultiSelect = false;
            this.pantryStockListView.Name = "pantryStockListView";
            this.pantryStockListView.Size = new System.Drawing.Size(888, 458);
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
            this.pantryStockGroupBox.Controls.Add(this.removeCancelButton);
            this.pantryStockGroupBox.Controls.Add(this.removeStockButton);
            this.pantryStockGroupBox.Controls.Add(this.expirationListBox);
            this.pantryStockGroupBox.Controls.Add(this.expirationIndexLabel);
            this.pantryStockGroupBox.Controls.Add(this.locationIndexDataLabel);
            this.pantryStockGroupBox.Controls.Add(this.stockToAddIndexDataLabel);
            this.pantryStockGroupBox.Controls.Add(this.typeIndexDataLabel);
            this.pantryStockGroupBox.Controls.Add(this.nameIndexDataLabel);
            this.pantryStockGroupBox.Controls.Add(this.locationIndexLabel);
            this.pantryStockGroupBox.Controls.Add(this.stockToAddIndexLabel);
            this.pantryStockGroupBox.Controls.Add(this.typeIndexLabel);
            this.pantryStockGroupBox.Controls.Add(this.nameIndexLabel);
            this.pantryStockGroupBox.Controls.Add(this.expirationTextBox);
            this.pantryStockGroupBox.Controls.Add(this.expirationLabel);
            this.pantryStockGroupBox.Controls.Add(this.locationTextBox);
            this.pantryStockGroupBox.Controls.Add(this.locationLabel);
            this.pantryStockGroupBox.Controls.Add(this.addCancelButton);
            this.pantryStockGroupBox.Controls.Add(this.addStockButton);
            this.pantryStockGroupBox.Controls.Add(this.stockToAddRequiredLabel);
            this.pantryStockGroupBox.Controls.Add(this.nameRequiredLabel);
            this.pantryStockGroupBox.Controls.Add(this.stockToAddTextBox);
            this.pantryStockGroupBox.Controls.Add(this.typeTextBox);
            this.pantryStockGroupBox.Controls.Add(this.nameTextBox);
            this.pantryStockGroupBox.Controls.Add(this.stockToAddLabel);
            this.pantryStockGroupBox.Controls.Add(this.typeLabel);
            this.pantryStockGroupBox.Controls.Add(this.nameLabel);
            this.pantryStockGroupBox.Controls.Add(this.newProduct);
            this.pantryStockGroupBox.Controls.Add(this.pantryStockListView);
            this.pantryStockGroupBox.Controls.Add(this.searchForProductLabel);
            this.pantryStockGroupBox.Controls.Add(this.searchTextBox);
            this.pantryStockGroupBox.Location = new System.Drawing.Point(220, 75);
            this.pantryStockGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pantryStockGroupBox.Name = "pantryStockGroupBox";
            this.pantryStockGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pantryStockGroupBox.Size = new System.Drawing.Size(946, 617);
            this.pantryStockGroupBox.TabIndex = 17;
            this.pantryStockGroupBox.TabStop = false;
            // 
            // newProduct
            // 
            this.newProduct.Location = new System.Drawing.Point(32, 73);
            this.newProduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(892, 58);
            this.newProduct.TabIndex = 8;
            this.newProduct.Text = "Add New Product";
            this.newProduct.UseVisualStyleBackColor = true;
            this.newProduct.Visible = false;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // searchForProductLabel
            // 
            this.searchForProductLabel.AutoSize = true;
            this.searchForProductLabel.Location = new System.Drawing.Point(26, 8);
            this.searchForProductLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchForProductLabel.Name = "searchForProductLabel";
            this.searchForProductLabel.Size = new System.Drawing.Size(209, 25);
            this.searchForProductLabel.TabIndex = 7;
            this.searchForProductLabel.Text = "Search for Product...";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(32, 33);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(888, 31);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addCancelButton
            // 
            this.addCancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCancelButton.Location = new System.Drawing.Point(528, 515);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(139, 49);
            this.addCancelButton.TabIndex = 31;
            this.addCancelButton.Text = "Cancel";
            this.addCancelButton.UseVisualStyleBackColor = false;
            this.addCancelButton.Visible = false;
            this.addCancelButton.Click += new System.EventHandler(this.addCancelButton_Click);
            // 
            // addStockButton
            // 
            this.addStockButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStockButton.Location = new System.Drawing.Point(274, 515);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(139, 49);
            this.addStockButton.TabIndex = 30;
            this.addStockButton.Text = "Add Stock";
            this.addStockButton.UseVisualStyleBackColor = false;
            this.addStockButton.Visible = false;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // stockToAddRequiredLabel
            // 
            this.stockToAddRequiredLabel.AutoSize = true;
            this.stockToAddRequiredLabel.Location = new System.Drawing.Point(429, 333);
            this.stockToAddRequiredLabel.Name = "stockToAddRequiredLabel";
            this.stockToAddRequiredLabel.Size = new System.Drawing.Size(99, 25);
            this.stockToAddRequiredLabel.TabIndex = 29;
            this.stockToAddRequiredLabel.Text = "Required";
            this.stockToAddRequiredLabel.Visible = false;
            // 
            // nameRequiredLabel
            // 
            this.nameRequiredLabel.AutoSize = true;
            this.nameRequiredLabel.Location = new System.Drawing.Point(429, 202);
            this.nameRequiredLabel.Name = "nameRequiredLabel";
            this.nameRequiredLabel.Size = new System.Drawing.Size(99, 25);
            this.nameRequiredLabel.TabIndex = 28;
            this.nameRequiredLabel.Text = "Required";
            this.nameRequiredLabel.Visible = false;
            // 
            // stockToAddTextBox
            // 
            this.stockToAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddTextBox.Location = new System.Drawing.Point(534, 321);
            this.stockToAddTextBox.Name = "stockToAddTextBox";
            this.stockToAddTextBox.Size = new System.Drawing.Size(383, 44);
            this.stockToAddTextBox.TabIndex = 27;
            this.stockToAddTextBox.Visible = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(534, 258);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(383, 44);
            this.typeTextBox.TabIndex = 26;
            this.typeTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(534, 195);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(383, 44);
            this.nameTextBox.TabIndex = 25;
            this.nameTextBox.Visible = false;
            // 
            // stockToAddLabel
            // 
            this.stockToAddLabel.AutoSize = true;
            this.stockToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddLabel.Location = new System.Drawing.Point(22, 328);
            this.stockToAddLabel.Name = "stockToAddLabel";
            this.stockToAddLabel.Size = new System.Drawing.Size(209, 37);
            this.stockToAddLabel.TabIndex = 24;
            this.stockToAddLabel.Text = "Stock to Add:";
            this.stockToAddLabel.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(22, 265);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(96, 37);
            this.typeLabel.TabIndex = 23;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 202);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 37);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(534, 386);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(383, 44);
            this.locationTextBox.TabIndex = 33;
            this.locationTextBox.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(22, 393);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(148, 37);
            this.locationLabel.TabIndex = 32;
            this.locationLabel.Text = "Location:";
            this.locationLabel.Visible = false;
            // 
            // expirationTextBox
            // 
            this.expirationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationTextBox.Location = new System.Drawing.Point(537, 448);
            this.expirationTextBox.Name = "expirationTextBox";
            this.expirationTextBox.Size = new System.Drawing.Size(383, 44);
            this.expirationTextBox.TabIndex = 35;
            this.expirationTextBox.Visible = false;
            // 
            // expirationLabel
            // 
            this.expirationLabel.AutoSize = true;
            this.expirationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationLabel.Location = new System.Drawing.Point(25, 455);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(244, 37);
            this.expirationLabel.TabIndex = 34;
            this.expirationLabel.Text = "Expiration Date:";
            this.expirationLabel.Visible = false;
            // 
            // locationIndexLabel
            // 
            this.locationIndexLabel.AutoSize = true;
            this.locationIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationIndexLabel.Location = new System.Drawing.Point(25, 208);
            this.locationIndexLabel.Name = "locationIndexLabel";
            this.locationIndexLabel.Size = new System.Drawing.Size(148, 37);
            this.locationIndexLabel.TabIndex = 40;
            this.locationIndexLabel.Text = "Location:";
            this.locationIndexLabel.Visible = false;
            // 
            // stockToAddIndexLabel
            // 
            this.stockToAddIndexLabel.AutoSize = true;
            this.stockToAddIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddIndexLabel.Location = new System.Drawing.Point(25, 143);
            this.stockToAddIndexLabel.Name = "stockToAddIndexLabel";
            this.stockToAddIndexLabel.Size = new System.Drawing.Size(187, 37);
            this.stockToAddIndexLabel.TabIndex = 39;
            this.stockToAddIndexLabel.Text = "Total Stock:";
            this.stockToAddIndexLabel.Visible = false;
            // 
            // typeIndexLabel
            // 
            this.typeIndexLabel.AutoSize = true;
            this.typeIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeIndexLabel.Location = new System.Drawing.Point(25, 80);
            this.typeIndexLabel.Name = "typeIndexLabel";
            this.typeIndexLabel.Size = new System.Drawing.Size(96, 37);
            this.typeIndexLabel.TabIndex = 38;
            this.typeIndexLabel.Text = "Type:";
            this.typeIndexLabel.Visible = false;
            // 
            // nameIndexLabel
            // 
            this.nameIndexLabel.AutoSize = true;
            this.nameIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameIndexLabel.Location = new System.Drawing.Point(25, 17);
            this.nameIndexLabel.Name = "nameIndexLabel";
            this.nameIndexLabel.Size = new System.Drawing.Size(112, 37);
            this.nameIndexLabel.TabIndex = 37;
            this.nameIndexLabel.Text = "Name:";
            this.nameIndexLabel.Visible = false;
            // 
            // locationIndexDataLabel
            // 
            this.locationIndexDataLabel.AutoSize = true;
            this.locationIndexDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationIndexDataLabel.Location = new System.Drawing.Point(530, 208);
            this.locationIndexDataLabel.Name = "locationIndexDataLabel";
            this.locationIndexDataLabel.Size = new System.Drawing.Size(0, 37);
            this.locationIndexDataLabel.TabIndex = 44;
            this.locationIndexDataLabel.Visible = false;
            // 
            // stockToAddIndexDataLabel
            // 
            this.stockToAddIndexDataLabel.AutoSize = true;
            this.stockToAddIndexDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddIndexDataLabel.Location = new System.Drawing.Point(530, 143);
            this.stockToAddIndexDataLabel.Name = "stockToAddIndexDataLabel";
            this.stockToAddIndexDataLabel.Size = new System.Drawing.Size(0, 37);
            this.stockToAddIndexDataLabel.TabIndex = 43;
            this.stockToAddIndexDataLabel.Visible = false;
            // 
            // typeIndexDataLabel
            // 
            this.typeIndexDataLabel.AutoSize = true;
            this.typeIndexDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeIndexDataLabel.Location = new System.Drawing.Point(530, 80);
            this.typeIndexDataLabel.Name = "typeIndexDataLabel";
            this.typeIndexDataLabel.Size = new System.Drawing.Size(0, 37);
            this.typeIndexDataLabel.TabIndex = 42;
            this.typeIndexDataLabel.Visible = false;
            // 
            // nameIndexDataLabel
            // 
            this.nameIndexDataLabel.AutoSize = true;
            this.nameIndexDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameIndexDataLabel.Location = new System.Drawing.Point(530, 17);
            this.nameIndexDataLabel.Name = "nameIndexDataLabel";
            this.nameIndexDataLabel.Size = new System.Drawing.Size(0, 37);
            this.nameIndexDataLabel.TabIndex = 41;
            this.nameIndexDataLabel.Visible = false;
            // 
            // expirationIndexLabel
            // 
            this.expirationIndexLabel.AutoSize = true;
            this.expirationIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationIndexLabel.Location = new System.Drawing.Point(25, 273);
            this.expirationIndexLabel.Name = "expirationIndexLabel";
            this.expirationIndexLabel.Size = new System.Drawing.Size(282, 37);
            this.expirationIndexLabel.TabIndex = 45;
            this.expirationIndexLabel.Text = "Expiration Date(s):";
            this.expirationIndexLabel.Visible = false;
            // 
            // expirationListBox
            // 
            this.expirationListBox.FormattingEnabled = true;
            this.expirationListBox.ItemHeight = 25;
            this.expirationListBox.Location = new System.Drawing.Point(534, 256);
            this.expirationListBox.Name = "expirationListBox";
            this.expirationListBox.Size = new System.Drawing.Size(383, 54);
            this.expirationListBox.TabIndex = 46;
            this.expirationListBox.Visible = false;
            // 
            // removeStockButton
            // 
            this.removeStockButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeStockButton.Location = new System.Drawing.Point(261, 515);
            this.removeStockButton.Name = "removeStockButton";
            this.removeStockButton.Size = new System.Drawing.Size(163, 49);
            this.removeStockButton.TabIndex = 47;
            this.removeStockButton.Text = "Remove Stock";
            this.removeStockButton.UseVisualStyleBackColor = false;
            this.removeStockButton.Visible = false;
            this.removeStockButton.Click += new System.EventHandler(this.removeStockButton_Click);
            // 
            // removeCancelButton
            // 
            this.removeCancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeCancelButton.Location = new System.Drawing.Point(528, 515);
            this.removeCancelButton.Name = "removeCancelButton";
            this.removeCancelButton.Size = new System.Drawing.Size(139, 49);
            this.removeCancelButton.TabIndex = 48;
            this.removeCancelButton.Text = "Cancel";
            this.removeCancelButton.UseVisualStyleBackColor = false;
            this.removeCancelButton.Visible = false;
            this.removeCancelButton.Click += new System.EventHandler(this.removeCancelButton_Click);
            // 
            // PantryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 708);
            this.Controls.Add(this.pantryStockGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.personsPantryLabel);
            this.Controls.Add(this.homeButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Label stockToAddRequiredLabel;
        private System.Windows.Forms.Label nameRequiredLabel;
        private System.Windows.Forms.TextBox stockToAddTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label stockToAddLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox expirationTextBox;
        private System.Windows.Forms.Label expirationLabel;
        private System.Windows.Forms.Label expirationIndexLabel;
        private System.Windows.Forms.Label locationIndexDataLabel;
        private System.Windows.Forms.Label stockToAddIndexDataLabel;
        private System.Windows.Forms.Label typeIndexDataLabel;
        private System.Windows.Forms.Label nameIndexDataLabel;
        private System.Windows.Forms.Label locationIndexLabel;
        private System.Windows.Forms.Label stockToAddIndexLabel;
        private System.Windows.Forms.Label typeIndexLabel;
        private System.Windows.Forms.Label nameIndexLabel;
        private System.Windows.Forms.ListBox expirationListBox;
        private System.Windows.Forms.Button removeCancelButton;
        private System.Windows.Forms.Button removeStockButton;
    }
}