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

        private void addButton_Click(object sender, EventArgs e)
        {
            this.newProduct.Visible = true;
            this.nameTextBox.Enabled = true;
            this.typeTextBox.Enabled = true;
            this.locationTextBox.Enabled = true;
            this.expirationTextBox.Enabled = true;
            this.addStockTextBox.Enabled = true;
            this.addStockButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Item To Remove");
            this.stockToRemove.Enabled = true;
            this.nameLabel2.Enabled = true;
            this.nameTextBox.Enabled = true;
            this.expirationTextBox.Enabled = true;
            this.removeStockTextBox.Enabled = true;
            this.RemoveStockButton.Enabled = true;
            this.expirationDateLabel.Enabled = true;
            this.CancelButton.Enabled = true;
            this.RemoveStockButton.Enabled = true;
            
        }


        private void pantryStockListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.newProduct.Visible = false;
            this.pantryStockListView.Visible = false;
            this.searchTextBox.Visible = false;
            this.stockToRemove.Visible = true;
            this.nameLabel2.Visible = true;
            this.nameTextBox.Visible = true;
            this.expirationTextBox.Visible = true;
            this.removeStockTextBox.Visible = true;
            this.RemoveStockButton.Visible = true;
            this.expirationDateLabel.Visible = true;
            this.CancelButton.Visible = true;
            this.RemoveStockButton.Visible = true;
            //this.expirationTextBox.Text = this.pantryStockListView.SelectedItems[0].ToString();
           // ListViewItem listViewItem = this.pantryStockListView.SelectedItems[0];
          //  this.nameTextBox.Text = listViewItem.SubItems[1].Text;
          
            for (int i = 0; i < this.pantryList.getPantrySize(); i++)
            {
                var product = this.pantryList.getProductByIndex(i);
                var lvi = new ListViewItem(new[] { "", product.Name, product.Type, product.Location, product.ExpirationDates.ToString() });
                if (this.pantryStockListView.Items[i].Selected)
                {
                    this.nameTextBox.Text = product.Name;
                }
                
             //   this.pantryStockListView.Items.Remove(lvi);
            }
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            this.pantryStockListView.Visible = false;
            this.searchTextBox.Visible = false;
            this.newProduct.Visible = false;
            this.CancelButton.Visible = true;
            this.CancelButton.Enabled = true;
            this.nameLabel3.Visible = true;
            this.nameTextBox.Visible = true;
            this.typeLabel3.Visible = true;
            this.typeTextBox.Visible = true;
            this.locationLabel.Visible = true;
            this.locationTextBox.Visible = true;
            this.StockToAddLabel.Visible = true;
            this.addStockTextBox.Visible = true;
            this.addStockButton.Visible = true;
            this.expirationTextBox.Visible = true;
            this.expirationDateLabel.Visible = true;
        }
          

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.newProduct.Visible = true;
            this.pantryStockListView.Visible = true;
            this.searchTextBox.Visible = true;
            this.stockToRemove.Visible = false;
            this.nameLabel2.Visible = false;
            this.nameTextBox.Visible = false;
            this.expirationTextBox.Visible = false;
            this.removeStockTextBox.Visible = false;
            this.RemoveStockButton.Visible = false;
            this.expirationDateLabel.Visible = false;
            this.CancelButton.Visible = false;
            this.RemoveStockButton.Visible = false;
            this.searchTextBox.Text = string.Empty;
            this.nameTextBox.Text = string.Empty;
            this.removeStockTextBox.Text = string.Empty;
            this.expirationTextBox.Text = string.Empty;
            this.nameLabel3.Visible = false;
            this.nameTextBox.Visible = false;
            this.typeLabel3.Visible = false;
            this.typeTextBox.Visible = false;
            this.locationLabel.Visible = false;
            this.locationTextBox.Visible = false;
            this.StockToAddLabel.Visible = false;
            this.addStockTextBox.Visible = false;
            this.addStockButton.Visible = false;
            this.newProduct.Visible = false;
        }

        private void RemoveStockButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.pantryList.getPantrySize(); i++)
            {
                if (this.pantryStockListView.Items[i].Selected)
                {
                    this.pantryStockListView.SelectedItems[i].Remove();
                }
            }
            this.newProduct.Visible = true;
            this.pantryStockListView.Visible = true;
            this.searchTextBox.Visible = true;
            this.stockToRemove.Visible = false;
            this.nameLabel2.Visible = false;
            this.nameTextBox.Visible = false;
            this.expirationTextBox.Visible = false;
            this.removeStockTextBox.Visible = false;
            this.RemoveStockButton.Visible = false;
            this.expirationDateLabel.Visible = false;
            this.CancelButton.Visible = false;
            this.RemoveStockButton.Visible = false;
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            ListViewItem addItem = new ListViewItem(new[] { "", nameTextBox.Text, typeTextBox.Text, locationTextBox.Text, addStockTextBox.Text });
            this.pantryStockListView.Items.Add(addItem);
            this.nameLabel3.Visible = false;
            this.nameTextBox.Visible = false;
            this.typeLabel3.Visible = false;
            this.typeTextBox.Visible = false;
            this.locationLabel.Visible = false;
            this.locationTextBox.Visible = false;
            this.StockToAddLabel.Visible = false;
            this.addStockTextBox.Visible = false;
            this.addStockButton.Visible = false;
            this.newProduct.Visible = false;
            this.newProduct.Visible = true;
            this.pantryStockListView.Visible = true;
            this.searchTextBox.Visible = true;
            this.nameTextBox.Text = string.Empty;
            this.typeTextBox.Text = string.Empty;
            this.locationTextBox.Text = string.Empty;
            this.expirationTextBox.Text = string.Empty;
            this.addStockTextBox.Text = string.Empty;
            this.CancelButton.Visible = false;
            this.expirationTextBox.Visible = false;
            this.expirationDateLabel.Visible = false;
            this.pantryStockListView.Update();
        }
    }
}