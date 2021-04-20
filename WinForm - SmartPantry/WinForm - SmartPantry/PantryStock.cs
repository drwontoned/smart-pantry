using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm___SmartPantry
{
    public partial class PantryStock : Form
    {
        public Pantry pantryList = new Pantry();         
        private HomePage home;
        private int topItemPantryIndex;
        private bool adding = false;
        private bool addNew = false;
        private bool removing = false;

        public PantryStock(HomePage home)
        {
            InitializeComponent();
            this.home = home;
            this.pantryList = home.PersonsPantry;
            // Handle the TextChanged
            //searchTextBox.TextChanged += new EventHandler(searchTextBox_TextChanged);

            this.buildListView();    
        }        

        private void buildListView()
        {
            for (int i = 0; i < this.pantryList.getPantrySize(); i++)
            {
                var product = this.pantryList.getProductByIndex(i);
                var lvi = new ListViewItem(new[] { "", product.Name, product.Type, product.Location, product.Stock.ToString() });
                this.pantryStockListView.Items.Add(lvi);
            }
        }

        // Event when the Home button is clicked
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.home.Location = this.Location;
            this.home.StartPosition = FormStartPosition.Manual;
            this.home.FormClosing += delegate { this.Show(); };
            this.home.Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Calls the FindItemWithText with the contents of the textbox
            ListViewItem foundItem = this.pantryStockListView.FindItemWithText(searchTextBox.Text, true, 0, true);
            this.topItemPantryIndex = this.pantryStockListView.Items.IndexOf(foundItem);

            if (!(foundItem is null))
            {
                this.pantryStockListView.Items.RemoveAt(topItemPantryIndex);
                this.pantryStockListView.Items.Insert(0, foundItem);
                Product topProduct = this.pantryList.getProductByIndex(topItemPantryIndex);
                this.pantryList.removeByIndex(topItemPantryIndex);
                this.pantryList.addToPantry(topProduct);
            }
            

            this.pantryStockListView.Update();
        }

        private void alphaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.alphaCheckBox.Checked == true)
            {
                this.typeCheckBox.Checked = false;
                this.locationCheckBox.Checked = false;
                this.expirationCheckBox.Checked = false;
                this.stockCheckBox.Checked = false;
                this.pantryList.setSortType("Alphabetical");
                this.pantryStockListView.Items.Clear();
                this.buildListView();
            }
        }

        private void typeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.typeCheckBox.Checked == true)
            {
                this.alphaCheckBox.Checked = false;
                this.locationCheckBox.Checked = false;
                this.expirationCheckBox.Checked = false;
                this.stockCheckBox.Checked = false;
                this.pantryList.setSortType("Type");
                this.pantryStockListView.Items.Clear();
                this.buildListView();
            }
        }

        private void locationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.locationCheckBox.Checked == true)
            {
                this.alphaCheckBox.Checked = false;
                this.typeCheckBox.Checked = false;
                this.expirationCheckBox.Checked = false;
                this.stockCheckBox.Checked = false;
                this.pantryList.setSortType("Location");
                this.pantryStockListView.Items.Clear();
                this.buildListView();
            }
        }

        private void expirationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.expirationCheckBox.Checked == true)
            {
                this.alphaCheckBox.Checked = false;
                this.typeCheckBox.Checked = false;
                this.locationCheckBox.Checked = false;
                this.stockCheckBox.Checked = false;
                this.pantryList.setSortType("Expiration");
                this.pantryStockListView.Items.Clear();
                this.buildListView();
            }
        }

        private void stockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.stockCheckBox.Checked == true)
            {
                this.alphaCheckBox.Checked = false;
                this.typeCheckBox.Checked = false;
                this.locationCheckBox.Checked = false;
                this.expirationCheckBox.Checked = false;
                this.pantryList.setSortType("Stock");
                this.pantryStockListView.Items.Clear();
                this.buildListView();
            }
        }

        private void addNewToggle()
        {
            this.addNew = !this.addNew;
            this.pantryStockListView.Visible = !this.pantryStockListView.Visible;
            this.searchForProductLabel.Visible = !this.searchForProductLabel.Visible;
            this.searchTextBox.Visible = !this.searchTextBox.Visible;
            this.nameTextBox.Visible = !this.nameTextBox.Visible;
            this.nameLabel.Visible = !this.nameLabel.Visible;
            this.nameRequiredLabel.Visible = !this.nameRequiredLabel.Visible;
            this.typeTextBox.Visible = !this.typeTextBox.Visible;
            this.typeLabel.Visible = !this.typeLabel.Visible;
            this.stockToAddTextBox.Visible = !this.stockToAddTextBox.Visible;
            this.stockToAddRequiredLabel.Visible = !this.stockToAddRequiredLabel.Visible;
            this.stockToAddLabel.Visible = !this.stockToAddLabel.Visible;
            this.locationTextBox.Visible = !this.locationTextBox.Visible;
            this.locationLabel.Visible = !this.locationLabel.Visible;
            this.expirationTextBox.Visible = !this.expirationTextBox.Visible;
            this.expirationLabel.Visible = !this.expirationLabel.Visible;
            this.newProduct.Visible = !this.newProduct.Visible;
            this.addStockButton.Visible = !this.addStockButton.Visible;
            this.addCancelButton.Visible = !this.addCancelButton.Visible;
            this.pantryStockListView.Update();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.newProduct.Visible = !this.newProduct.Visible;
            this.adding = !this.adding;
            this.pantryStockListView.SelectedIndices.Clear();

            if (this.removing)
            {
                this.removing = false;
            }

            if (this.nameTextBox.Visible)
            {
                this.addNewToggle();
            }

            if(this.nameIndexLabel.Visible)
            {
                this.addToggle();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.removing = !this.removing;

            if (this.adding)
            {
                this.adding = false;
            }

            if (this.newProduct.Visible)
            {
                this.newProduct.Visible = false;
            }
        }

        private void addToggle()
        {
            this.pantryStockListView.Visible = !this.pantryStockListView.Visible;
            this.nameIndexLabel.Visible = !this.nameIndexLabel.Visible;
            this.typeIndexLabel.Visible = !this.typeIndexLabel.Visible;
            this.stockToAddIndexLabel.Visible = !this.stockToAddIndexLabel.Visible;
            this.locationIndexLabel.Visible = !this.locationIndexLabel.Visible;
            this.expirationIndexLabel.Visible = !this.expirationIndexLabel.Visible;
            this.nameIndexDataLabel.Visible = !this.nameIndexDataLabel.Visible;
            this.typeIndexDataLabel.Visible = !this.typeIndexDataLabel.Visible;
            this.stockToAddIndexDataLabel.Visible = !this.stockToAddIndexDataLabel.Visible;
            this.locationIndexDataLabel.Visible = !this.locationIndexDataLabel.Visible;
            this.expirationListBox.Visible = !this.expirationListBox.Visible;
            this.stockToAddLabel.Visible = !this.stockToAddLabel.Visible;
            this.stockToAddRequiredLabel.Visible = !this.stockToAddRequiredLabel.Visible;
            this.locationLabel.Visible = !this.locationLabel.Visible;
            this.expirationLabel.Visible = !this.expirationLabel.Visible;
            this.stockToAddTextBox.Visible = !this.stockToAddTextBox.Visible;
            this.locationTextBox.Visible = !this.locationTextBox.Visible;
            this.expirationTextBox.Visible = !this.expirationTextBox.Visible;
            this.newProduct.Visible = !this.newProduct.Visible;
            this.addStockButton.Visible = !this.addStockButton.Visible;
            this.addCancelButton.Visible = !this.addCancelButton.Visible;
            this.searchForProductLabel.Visible = !this.searchForProductLabel.Visible;
            this.searchTextBox.Visible = !this.searchTextBox.Visible;
            this.pantryStockListView.Update();
        }

        private void removeToggle()
        {
            this.pantryStockListView.Visible = !this.pantryStockListView.Visible;
            this.nameIndexLabel.Visible = !this.nameIndexLabel.Visible;
            this.typeIndexLabel.Visible = !this.typeIndexLabel.Visible;
            this.stockToAddIndexLabel.Visible = !this.stockToAddIndexLabel.Visible;
            this.locationIndexLabel.Visible = !this.locationIndexLabel.Visible;
            this.expirationIndexLabel.Visible = !this.expirationIndexLabel.Visible;
            this.nameIndexDataLabel.Visible = !this.nameIndexDataLabel.Visible;
            this.typeIndexDataLabel.Visible = !this.typeIndexDataLabel.Visible;
            this.stockToAddIndexDataLabel.Visible = !this.stockToAddIndexDataLabel.Visible;
            this.locationIndexDataLabel.Visible = !this.locationIndexDataLabel.Visible;
            this.expirationListBox.Visible = !this.expirationListBox.Visible;
            this.stockToAddLabel.Visible = !this.stockToAddLabel.Visible;
            this.stockToAddRequiredLabel.Visible = !this.stockToAddRequiredLabel.Visible;
            this.locationLabel.Visible = !this.locationLabel.Visible;
            this.expirationLabel.Visible = !this.expirationLabel.Visible;
            this.stockToAddTextBox.Visible = !this.stockToAddTextBox.Visible;
            this.locationTextBox.Visible = !this.locationTextBox.Visible;
            this.expirationTextBox.Visible = !this.expirationTextBox.Visible;
            this.removeStockButton.Visible = !this.removeStockButton.Visible;
            this.removeCancelButton.Visible = !this.removeCancelButton.Visible;
            this.searchForProductLabel.Visible = !this.searchForProductLabel.Visible;
            this.searchTextBox.Visible = !this.searchTextBox.Visible;
            this.pantryStockListView.Update();
        }

        private void pantryStockListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((adding || removing) && this.pantryStockListView.SelectedIndices.Count != 0)
            {
                int selectedItemIndex = this.pantryStockListView.SelectedIndices[0];
                ListViewItem selectedItem = this.pantryStockListView.Items[selectedItemIndex];
                Product editedProduct = this.pantryList.getProductByIndex(selectedItemIndex);
                this.nameIndexDataLabel.Text = selectedItem.SubItems[1].Text;
                this.typeIndexDataLabel.Text = selectedItem.SubItems[2].Text;
                this.locationIndexDataLabel.Text = selectedItem.SubItems[3].Text;
                this.stockToAddIndexDataLabel.Text = selectedItem.SubItems[4].Text;
                foreach (ExpirationDate date in editedProduct.ExpirationDates)
                {
                    this.expirationListBox.Items.Add(date.Date);
                }
                this.expirationListBox.Update();

                if (adding)
                {
                    this.stockToAddLabel.Text = "Stock to Add";
                    this.addToggle();
                }
                else if (removing)
                {
                    this.stockToAddLabel.Text = "Stock to Remove";
                    this.removeToggle();
                }
            }
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            this.addNewToggle();
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            string name;
            string type;
            string location;
            DateTime date;
            int nameLength;
            int stockContent;

            if (this.addNew)
            {
                name = this.nameTextBox.Text;

                if (!(this.typeTextBox.Text.Length > 0))
                {
                    type = "N/A";
                }
                else
                {
                    type = this.typeTextBox.Text;
                }

                if (!(this.locationTextBox.Text.Length > 0))
                {
                    location = "N/A";
                }
                else
                {
                    location = this.locationTextBox.Text;
                }

                nameLength = this.nameTextBox.Text.Length;
                int.TryParse(this.stockToAddTextBox.Text, out stockContent);

                if (nameLength > 0 && stockContent > 0)
                {
                    Product productToAdd = new Product(name, stockContent, type, location);

                    if (DateTime.TryParse(this.expirationTextBox.Text, out date))
                    {
                        productToAdd.ExpirationDates.Add(new ExpirationDate(date.ToString(), stockContent));
                    }

                    this.pantryList.addToPantry(productToAdd);
                    // There is a limitation where the first column cannot be centered, so there is a fake first column
                    // with no name for what would be the checkbox space.
                    this.pantryStockListView.Items.Add(new ListViewItem(new string[] { "", name, type, location, this.stockToAddTextBox.Text }));
                }

                this.addNewToggle();
            }
            else
            {
                int selectedIndex = this.pantryStockListView.Items.IndexOf(this.pantryStockListView.SelectedItems[0]);
                if(int.TryParse(this.stockToAddTextBox.Text, out stockContent) && stockContent > 0)
                {
                    this.pantryList.getProductByIndex(selectedIndex).Stock += stockContent;
                    this.pantryStockListView.Items[selectedIndex].SubItems[4].Text = this.pantryList.getProductByIndex(selectedIndex).Stock.ToString();
                }
                if ((this.locationTextBox.Text.Length > 0))
                {
                    this.pantryList.getProductByIndex(selectedIndex).Location = this.locationTextBox.Text;
                    this.pantryStockListView.Items[selectedIndex].SubItems[3].Text = this.locationTextBox.Text;
                }
                if (DateTime.TryParse(this.expirationTextBox.Text, out date))
                {
                    this.pantryList.getProductByIndex(selectedIndex).ExpirationDates.Add(new ExpirationDate(date.ToString(), stockContent));
                }

                this.addToggle();
            }
        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            if (this.addNew)
            {
                this.addNewToggle();
            }
            else
            {
                this.addToggle();
            }
        }

        private void removeStockButton_Click(object sender, EventArgs e)
        {
            DateTime date;
            int stockContent;
            bool removed = false;

            int selectedIndex = this.pantryStockListView.Items.IndexOf(this.pantryStockListView.SelectedItems[0]);
            if (int.TryParse(this.stockToAddTextBox.Text, out stockContent) && stockContent > 0)
            {
                int result = this.pantryList.getProductByIndex(selectedIndex).Stock - stockContent;
                if (result > 0)
                {
                    this.pantryList.getProductByIndex(selectedIndex).Stock = result;
                    this.pantryStockListView.Items[selectedIndex].SubItems[4].Text = this.pantryList.getProductByIndex(selectedIndex).Stock.ToString();
                }
                else
                {
                    this.pantryList.removeByIndex(selectedIndex);
                    this.pantryStockListView.Items[selectedIndex].Remove();
                    removed = true;
                }
            }

            if (!removed)
            {
                if ((this.locationTextBox.Text.Length > 0))
                {
                    this.pantryList.getProductByIndex(selectedIndex).Location = this.locationTextBox.Text;
                    this.pantryStockListView.Items[selectedIndex].SubItems[3].Text = this.locationTextBox.Text;
                }
                if (DateTime.TryParse(this.expirationTextBox.Text, out date))
                {
                    this.pantryList.getProductByIndex(selectedIndex).ExpirationDates.Add(new ExpirationDate(date.ToString(), stockContent));
                }
            }

            this.removeToggle();
        }

        private void removeCancelButton_Click(object sender, EventArgs e)
        {
            this.removeToggle();
        }
    }
}