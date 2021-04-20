using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm___SmartPantry
{
    public partial class ShoppingList : Form
    {
        public Pantry PersonsShoppinglist = new Pantry();
        private HomePage home;

        public ShoppingList(HomePage home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Text = "";
            this.typeTextBox.Text = "";
            this.stockToAddTextBox.Text = "";
            this.costTextBox.Text = "";
            this.toggleAddItemScreen();
        }

        private void toggleAddItemScreen()
        {
            this.shoppingListView.Visible = !this.shoppingListView.Visible;
            this.nameLabel.Visible = !this.nameLabel.Visible;
            this.nameRequiredLabel.Visible = !this.nameRequiredLabel.Visible;
            this.typeLabel.Visible = !this.typeLabel.Visible;
            this.stockToAddLabel.Visible = !this.stockToAddLabel.Visible;
            this.stockToAddRequiredLabel.Visible = !this.stockToAddRequiredLabel.Visible;
            this.costLabel.Visible = !this.costLabel.Visible;
            this.nameTextBox.Visible = !this.nameTextBox.Visible;
            this.typeTextBox.Visible = !this.typeTextBox.Visible;
            this.stockToAddTextBox.Visible = !this.stockToAddTextBox.Visible;
            this.costTextBox.Visible = !this.costTextBox.Visible;
            this.addToListButton.Visible = !this.addToListButton.Visible;
            this.addCancelButton.Visible = !this.addCancelButton.Visible;
            this.shoppingListView.Update();
        }

        // If name and stock have proper values then add a new product to the list.
        private void addToListButton_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string type = this.typeTextBox.Text;
            int nameLength = this.nameTextBox.Text.Length;
            int stockContent;
            double costContent;
            int.TryParse(this.stockToAddTextBox.Text, out stockContent);

            if (nameLength > 0 && stockContent > 0)
            {
                string trueCost;

                if (!double.TryParse(this.costTextBox.Text, out costContent))
                {
                    trueCost = "N/A";
                }
                else
                {
                    trueCost = costContent.ToString("C0");
                }

                Product productToAdd = new Product(name, stockContent, type, new List<double>() { costContent });
                this.PersonsShoppinglist.addToPantry(productToAdd);
                // There is a limitation where the first column cannot be centered, so there is a fake first column
                // with no name for what would be the checkbox space.
                this.shoppingListView.Items.Add(new ListViewItem(new string[] { "", name, type, this.stockToAddTextBox.Text, trueCost}));
            }

            this.toggleAddItemScreen();
        }

        // Clear textboxes and switch to base Shopping List Screen.
        private void addCancelButton_Click(object sender, EventArgs e)
        {
            this.toggleAddItemScreen();
            this.nameTextBox.Text = "";
            this.typeTextBox.Text = "";
            this.stockToAddTextBox.Text = "";
            this.costTextBox.Text = "";
        }

        private void removeButtonToggle()
        {
            this.shoppingListView.CheckBoxes = !this.shoppingListView.CheckBoxes;
            this.removeFromListButton.Visible = !this.removeFromListButton.Visible;
            this.removeCancelButton.Visible = !this.removeCancelButton.Visible;
            this.shoppingListView.Update();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.removeButtonToggle();
        }

        // Remove selected items from both the GUI and actual shopping list.
        private void removeFromListButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem product in this.shoppingListView.CheckedItems)
            {
                this.shoppingListView.Items.Remove(product);
            }

            this.PersonsShoppinglist.removeMultipleByIndices(this.shoppingListView.CheckedIndices.Cast<int>().ToArray());
            this.removeButtonToggle();
        }

        private void removeCancelButton_Click(object sender, EventArgs e)
        {
            this.removeButtonToggle();
        }

        // Return to homepage
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.home.Location = this.Location;
            this.home.StartPosition = FormStartPosition.Manual;
            this.home.FormClosing += delegate { this.Show(); };
            this.home.Show();
            this.Hide();
        }

        // Export ShoppingList to a text file.
        private void exportButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = new string[PersonsShoppinglist.getPantrySize()];
                    for (int i = 0; i < this.PersonsShoppinglist.getPantrySize(); i++)
                    {
                        Product current = this.PersonsShoppinglist.getProductByIndex(i);
                        lines[i] = current.Name + "    " + current.Type + "    " + current.Stock + "    " + current.Prices[0].ToString("C0");
                    }

                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = saveFileDialog.OpenFile();

                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        foreach (string line in lines)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    fileStream.Close();
                }
            }
        }
    }
}
