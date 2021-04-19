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
    }
}