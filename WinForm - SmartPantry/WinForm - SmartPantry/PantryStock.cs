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

        // list of products and sorting type;
        private List<Product> pantryStock;
        private string sortType = string.Empty;
        private bool ascending = true;

        public PantryStock(HomePage home)
        {
            InitializeComponent();
            this.home = home;
            //this.pantryList = new List<Product>();

            // Handle the TextChanged
            searchTextBox.TextChanged += new EventHandler(searchTextBox_TextChanged);

            // Add the controls to the form
            this.Controls.Add(pantryStockListView);
            this.Controls.Add(searchTextBox);


            // Set the listview into details mode
            pantryStockListView.View = View.Details;
            pantryStockListView.GridLines = true;

            // Set the columns.
            // Width of -1 = width of longest item name
            // Width of -2 = width of column header
            pantryStockListView.Columns.Add("Product Name", -1);
            pantryStockListView.Columns.Add("Product Type", -2);
            pantryStockListView.Columns.Add("Location", -1);
            pantryStockListView.Columns.Add("Amount", -2);


            // create some products
            Product CinnamonToastCrunch = new Product("Cinnamon Toast Crunch", 1);
            CinnamonToastCrunch.Type = "Cereal";
            CinnamonToastCrunch.Location = "Kitchen Pantry - 3rd shelf";

            Product WholeMilk = new Product("Whole Milk", 0);
            WholeMilk.Type = "Dairy";
            WholeMilk.Location = "Fridge";
            WholeMilk.addStock("04/20/2021", 1);

            Product Vodka = new Product("Vodka", 0);
            Vodka.Type = "Alcohol";
            Vodka.Location = "Liquor Cabinet";
            Vodka.addStock("4/15/2036", 1);

            this.pantryList.addToPantry(WholeMilk);
            this.pantryList.addToPantry(CinnamonToastCrunch);
            this.pantryList.addToPantry(Vodka);

            for (int i = 0; i < pantryList.getPantrySize(); i++)
            {
                var product = pantryList.getProductByIndex(i);
                var lvi = new ListViewItem(new[] { product.Name, product.Type, product.Location, product.Stock.ToString() });
                pantryStockListView.Items.Add(lvi);
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
            ListViewItem foundItem = pantryStockListView.FindItemWithText(searchTextBox.Text, true, 0, true);

            if (foundItem.Text != null)
            {
                pantryStockListView.TopItem = foundItem;
            }

        }

        public void setSortType(string input)
        {
            this.sortType = input;
            this.pantryList = SortList(this.pantryList); // Error here
        }

        private void alphaCheckBox_CheckedChanged(object sender, EventArgs e)
        {            
            // Clear()
            var pantryInstance = new Pantry();
            this.sortType = "Alphabetical";

            this.pantryStock = pantryInstance.SortList(pantryList); // Error here

            pantryStockListView.Items.Clear();
            
            
        }

        private void typeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void locationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void expirationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stockCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}