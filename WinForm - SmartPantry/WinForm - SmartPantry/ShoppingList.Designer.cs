
namespace WinForm___SmartPantry
{
    partial class ShoppingList
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
            this.actionButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingListGroupBox = new System.Windows.Forms.GroupBox();
            this.removeCancelButton = new System.Windows.Forms.Button();
            this.removeFromListButton = new System.Windows.Forms.Button();
            this.stockToAddRequiredLabel = new System.Windows.Forms.Label();
            this.nameRequiredLabel = new System.Windows.Forms.Label();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.addToListButton = new System.Windows.Forms.Button();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.stockToAddTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.stockToAddLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.shoppingListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkboxColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionButtonsGroupBox.SuspendLayout();
            this.shoppingListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(188, 86);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Return Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // actionButtonsGroupBox
            // 
            this.actionButtonsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.actionButtonsGroupBox.Controls.Add(this.exportButton);
            this.actionButtonsGroupBox.Controls.Add(this.removeButton);
            this.actionButtonsGroupBox.Controls.Add(this.addButton);
            this.actionButtonsGroupBox.Location = new System.Drawing.Point(12, 104);
            this.actionButtonsGroupBox.Name = "actionButtonsGroupBox";
            this.actionButtonsGroupBox.Size = new System.Drawing.Size(188, 592);
            this.actionButtonsGroupBox.TabIndex = 2;
            this.actionButtonsGroupBox.TabStop = false;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportButton.Location = new System.Drawing.Point(6, 250);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(176, 93);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(6, 141);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(176, 93);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(6, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 93);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Person\'s Shopping List";
            // 
            // shoppingListGroupBox
            // 
            this.shoppingListGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shoppingListGroupBox.Controls.Add(this.removeCancelButton);
            this.shoppingListGroupBox.Controls.Add(this.removeFromListButton);
            this.shoppingListGroupBox.Controls.Add(this.stockToAddRequiredLabel);
            this.shoppingListGroupBox.Controls.Add(this.nameRequiredLabel);
            this.shoppingListGroupBox.Controls.Add(this.addCancelButton);
            this.shoppingListGroupBox.Controls.Add(this.addToListButton);
            this.shoppingListGroupBox.Controls.Add(this.costTextBox);
            this.shoppingListGroupBox.Controls.Add(this.stockToAddTextBox);
            this.shoppingListGroupBox.Controls.Add(this.typeTextBox);
            this.shoppingListGroupBox.Controls.Add(this.nameTextBox);
            this.shoppingListGroupBox.Controls.Add(this.costLabel);
            this.shoppingListGroupBox.Controls.Add(this.stockToAddLabel);
            this.shoppingListGroupBox.Controls.Add(this.typeLabel);
            this.shoppingListGroupBox.Controls.Add(this.nameLabel);
            this.shoppingListGroupBox.Controls.Add(this.shoppingListView);
            this.shoppingListGroupBox.Location = new System.Drawing.Point(219, 104);
            this.shoppingListGroupBox.Name = "shoppingListGroupBox";
            this.shoppingListGroupBox.Size = new System.Drawing.Size(942, 592);
            this.shoppingListGroupBox.TabIndex = 7;
            this.shoppingListGroupBox.TabStop = false;
            // 
            // removeCancelButton
            // 
            this.removeCancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeCancelButton.Location = new System.Drawing.Point(527, 510);
            this.removeCancelButton.Name = "removeCancelButton";
            this.removeCancelButton.Size = new System.Drawing.Size(139, 49);
            this.removeCancelButton.TabIndex = 21;
            this.removeCancelButton.Text = "Cancel";
            this.removeCancelButton.UseVisualStyleBackColor = false;
            this.removeCancelButton.Visible = false;
            this.removeCancelButton.Click += new System.EventHandler(this.removeCancelButton_Click);
            // 
            // removeFromListButton
            // 
            this.removeFromListButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeFromListButton.Location = new System.Drawing.Point(273, 510);
            this.removeFromListButton.Name = "removeFromListButton";
            this.removeFromListButton.Size = new System.Drawing.Size(139, 49);
            this.removeFromListButton.TabIndex = 20;
            this.removeFromListButton.Text = "Remove";
            this.removeFromListButton.UseVisualStyleBackColor = false;
            this.removeFromListButton.Visible = false;
            this.removeFromListButton.Click += new System.EventHandler(this.removeFromListButton_Click);
            // 
            // stockToAddRequiredLabel
            // 
            this.stockToAddRequiredLabel.AutoSize = true;
            this.stockToAddRequiredLabel.Location = new System.Drawing.Point(432, 186);
            this.stockToAddRequiredLabel.Name = "stockToAddRequiredLabel";
            this.stockToAddRequiredLabel.Size = new System.Drawing.Size(99, 25);
            this.stockToAddRequiredLabel.TabIndex = 19;
            this.stockToAddRequiredLabel.Text = "Required";
            this.stockToAddRequiredLabel.Visible = false;
            // 
            // nameRequiredLabel
            // 
            this.nameRequiredLabel.AutoSize = true;
            this.nameRequiredLabel.Location = new System.Drawing.Point(432, 55);
            this.nameRequiredLabel.Name = "nameRequiredLabel";
            this.nameRequiredLabel.Size = new System.Drawing.Size(99, 25);
            this.nameRequiredLabel.TabIndex = 18;
            this.nameRequiredLabel.Text = "Required";
            this.nameRequiredLabel.Visible = false;
            // 
            // addCancelButton
            // 
            this.addCancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCancelButton.Location = new System.Drawing.Point(527, 510);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(139, 49);
            this.addCancelButton.TabIndex = 17;
            this.addCancelButton.Text = "Cancel";
            this.addCancelButton.UseVisualStyleBackColor = false;
            this.addCancelButton.Visible = false;
            this.addCancelButton.Click += new System.EventHandler(this.addCancelButton_Click);
            // 
            // addToListButton
            // 
            this.addToListButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addToListButton.Location = new System.Drawing.Point(273, 510);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(139, 49);
            this.addToListButton.TabIndex = 16;
            this.addToListButton.Text = "Add to List";
            this.addToListButton.UseVisualStyleBackColor = false;
            this.addToListButton.Visible = false;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(537, 234);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(383, 44);
            this.costTextBox.TabIndex = 15;
            this.costTextBox.Visible = false;
            // 
            // stockToAddTextBox
            // 
            this.stockToAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddTextBox.Location = new System.Drawing.Point(537, 174);
            this.stockToAddTextBox.Name = "stockToAddTextBox";
            this.stockToAddTextBox.Size = new System.Drawing.Size(383, 44);
            this.stockToAddTextBox.TabIndex = 14;
            this.stockToAddTextBox.Visible = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(537, 111);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(383, 44);
            this.typeTextBox.TabIndex = 13;
            this.typeTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(537, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(383, 44);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(25, 241);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(92, 37);
            this.costLabel.TabIndex = 11;
            this.costLabel.Text = "Cost:";
            this.costLabel.Visible = false;
            // 
            // stockToAddLabel
            // 
            this.stockToAddLabel.AutoSize = true;
            this.stockToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToAddLabel.Location = new System.Drawing.Point(25, 181);
            this.stockToAddLabel.Name = "stockToAddLabel";
            this.stockToAddLabel.Size = new System.Drawing.Size(209, 37);
            this.stockToAddLabel.TabIndex = 10;
            this.stockToAddLabel.Text = "Stock to Add:";
            this.stockToAddLabel.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(25, 118);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(96, 37);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(25, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 37);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // shoppingListView
            // 
            this.shoppingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkboxColumnHeader,
            this.nameColumnHeader,
            this.typeColumnHeader,
            this.stockColumnHeader,
            this.costColumnHeader});
            this.shoppingListView.HideSelection = false;
            this.shoppingListView.Location = new System.Drawing.Point(32, 17);
            this.shoppingListView.Name = "shoppingListView";
            this.shoppingListView.Size = new System.Drawing.Size(898, 487);
            this.shoppingListView.TabIndex = 0;
            this.shoppingListView.UseCompatibleStateImageBehavior = false;
            this.shoppingListView.View = System.Windows.Forms.View.Details;
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
            this.typeColumnHeader.Width = 149;
            // 
            // stockColumnHeader
            // 
            this.stockColumnHeader.Text = "Stock";
            this.stockColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stockColumnHeader.Width = 40;
            // 
            // costColumnHeader
            // 
            this.costColumnHeader.Text = "Cost";
            this.costColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.costColumnHeader.Width = 47;
            // 
            // checkboxColumnHeader
            // 
            this.checkboxColumnHeader.Text = "";
            this.checkboxColumnHeader.Width = 20;
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 708);
            this.Controls.Add(this.shoppingListGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionButtonsGroupBox);
            this.Controls.Add(this.homeButton);
            this.Name = "ShoppingList";
            this.Text = "Smart Pantry";
            this.actionButtonsGroupBox.ResumeLayout(false);
            this.shoppingListGroupBox.ResumeLayout(false);
            this.shoppingListGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox actionButtonsGroupBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox shoppingListGroupBox;
        private System.Windows.Forms.ListView shoppingListView;
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox stockToAddTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label stockToAddLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label stockToAddRequiredLabel;
        private System.Windows.Forms.Label nameRequiredLabel;
        private System.Windows.Forms.Button removeCancelButton;
        private System.Windows.Forms.Button removeFromListButton;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader stockColumnHeader;
        private System.Windows.Forms.ColumnHeader costColumnHeader;
        private System.Windows.Forms.ColumnHeader checkboxColumnHeader;
    }
}