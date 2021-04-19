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
    public partial class HomePage : Form
    {
        public Pantry PersonsPantry = new Pantry();

        public HomePage()
        {
            InitializeComponent();

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
            Vodka.addStock("04/15/2036", 1);

            // add products to pantry
            PersonsPantry.addToPantry(CinnamonToastCrunch);
            PersonsPantry.addToPantry(WholeMilk);
            PersonsPantry.addToPantry(Vodka);

            // insert products into the list box
            for (int i = 0; i < PersonsPantry.getPantrySize(); i++)
            {
                this.HomePagePantry.Items.Add(createHomePagePantryText(PersonsPantry.getProductByIndex(i)));
            }
        }

        // method for generating string based on products 
        // for the home page pantry view
        public string createHomePagePantryText(Product p)
        {
            int maxCharacters = 24;
            int neededSpaces = maxCharacters - p.Name.Length - p.Stock.ToString().Length;
            string productText = string.Empty;

            productText += p.Name;
            for (int i = 0; i < neededSpaces; i++)
            {
                productText += " ";
            }
            productText += "x" + p.Stock;

            return productText;
        }

        // Event method for pressing the "View Shopping List" button.
        private void viewShoppingListButton_Click(object sender, EventArgs e)
        {
            var frm = new ShoppingList(this);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void viewExpirationDatesButton_Click(object sender, EventArgs e)
        {
            var frm = new Calendar(this);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
