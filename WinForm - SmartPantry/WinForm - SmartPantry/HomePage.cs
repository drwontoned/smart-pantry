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
            DateTime today = new DateTime(2021, 4, 20);

            // create some products
            Product CinnamonToastCrunch = new Product("Cinnamon Toast Crunch", 1);
            CinnamonToastCrunch.Type = "Cereal";
            CinnamonToastCrunch.Location = "Kitchen Pantry - 3rd shelf";

            Product WholeMilk = new Product("Whole Milk", 0);
            WholeMilk.Type = "Dairy";
            WholeMilk.Location = "Fridge";
            WholeMilk.addStock("04/22/2021", 1);

            Product Bacon = new Product("Bacon", 0);
            Bacon.Type = "Meat";
            Bacon.Location = "Fridge";
            Bacon.addStock("04/26/2021", 1);
            Bacon.addStock("05/26/2021", 1);

            Product Vodka = new Product("Vodka", 0);
            Vodka.Type = "Alchohol";
            Vodka.Location = "Liquor Cabinet";
            Vodka.addStock("04/15/2036", 2);

            Product Tequila = new Product("Tequila", 0);
            Tequila.Type = "Alchohol";
            Tequila.Location = "Liquor Cabinet";
            Tequila.addStock("04/15/2036", 1);

            Product Rum = new Product("Rum", 0);
            Rum.Type = "Alchohol";
            Rum.Location = "Liquor Cabinet";
            Rum.addStock("04/15/2036", 1);

            Product WhiteBread = new Product("White Bread", 0);
            WhiteBread.Type = "Baked Good";
            WhiteBread.Location = "Kitchen Pantry - 2nd shelf";
            WhiteBread.addStock("04/25/2021", 1);
            WhiteBread.addStock("04/27/2021", 1);

            Product Eggs = new Product("Eggs", 0);
            Eggs.Location = "Fridge";
            Eggs.addStock("05/22/2021", 24);

            Product Fettuccine = new Product("Fettuccine", 0);
            Fettuccine.Type = "Pasta";
            Fettuccine.Location = "Kitchen Pantry - 4th shelf";
            Fettuccine.addStock("05/22/2023", 1);

            Product Penne = new Product("Penne", 0);
            Penne.Type = "Pasta";
            Penne.Location = "Kitchen Pantry - 4th shelf";
            Penne.addStock("05/22/2023", 1);

            Product Cavatappi = new Product("Cavatappi", 0);
            Cavatappi.Type = "Pasta";
            Cavatappi.Location = "Kitchen Pantry - 4th shelf";
            Cavatappi.addStock("05/22/2023", 1);

            Product ShrimpRamen = new Product("Shrimp Ramen", 69);
            ShrimpRamen.Type = "Instant Noodle";
            ShrimpRamen.Location = "Kitchen Pantry - 4th shelf";

            Product Lemons = new Product("Lemons", 0);
            Lemons.Type = "Fruit";
            Lemons.Location = "Life's House";
            Lemons.addStock("04/29/2021", 3);

            Product Apples = new Product("Apples", 0);
            Apples.Type = "Fruit";
            Apples.Location = "Fridge";
            Apples.addStock("04/29/2021", 3);

            Product Bananas = new Product("Bananas", 0);
            Bananas.Type = "Fruit";
            Bananas.Location = "Fridge";
            Bananas.addStock("04/29/2021", 3);

            Product Strawberries = new Product("Strawberries", 0);
            Strawberries.Type = "Fruit";
            Strawberries.Location = "Fridge";
            Strawberries.addStock("04/29/2021", 24);

            Product ChickenNuggets = new Product("Chicken Nuggets", 0);
            ChickenNuggets.Type = "Frozen";
            ChickenNuggets.Location = "Freezer";
            ChickenNuggets.addStock("10/10/2021", 1);

            Product Fries = new Product("Fries", 0);
            Fries.Type = "Frozen";
            Fries.Location = "Freezer";
            Fries.addStock("10/10/2021", 1);

            Product BlueberryWaffles = new Product("Blueberry Waffles", 0);
            BlueberryWaffles.Type = "Frozen";
            BlueberryWaffles.Location = "Freezer";
            BlueberryWaffles.addStock("10/10/2021", 1);

            // add products to pantry
            PersonsPantry.addToPantry(CinnamonToastCrunch);
            PersonsPantry.addToPantry(WholeMilk);
            PersonsPantry.addToPantry(Bacon);
            PersonsPantry.addToPantry(Vodka);
            PersonsPantry.addToPantry(Tequila);
            PersonsPantry.addToPantry(Rum);
            PersonsPantry.addToPantry(WhiteBread);
            PersonsPantry.addToPantry(Eggs);
            PersonsPantry.addToPantry(Fettuccine);
            PersonsPantry.addToPantry(Penne);
            PersonsPantry.addToPantry(Cavatappi);
            PersonsPantry.addToPantry(ShrimpRamen);
            PersonsPantry.addToPantry(Lemons);
            PersonsPantry.addToPantry(Apples);
            PersonsPantry.addToPantry(Bananas);
            PersonsPantry.addToPantry(Strawberries);
            PersonsPantry.addToPantry(ChickenNuggets);
            PersonsPantry.addToPantry(Fries);
            PersonsPantry.addToPantry(BlueberryWaffles);

            // insert products into the list box
            for (int i = 0; i < PersonsPantry.getPantrySize(); i++)
            {
                this.HomePagePantry.Items.Add(createHomePagePantryText(PersonsPantry.getProductByIndex(i)));
                Product currentProduct = this.PersonsPantry.getProductByIndex(i);

                if (currentProduct.ExpirationDates.Count > 0)
                {
                    for (int j = 0; j < currentProduct.ExpirationDates.Count; j++)
                    {

                        if ((currentProduct.ExpirationDates[j].ActualDate - today).TotalDays <= 7)
                        {
                            this.expirationsBox.Items.Add(createHomePageExpirationText(currentProduct, j, today));
                        }
                    }
                }

            }
        }

        public HomePage(Pantry pantry)
        {
            InitializeComponent();
            this.PersonsPantry = pantry;

            DateTime today = new DateTime(2021, 4, 20);

            // insert products into the list box
            for (int i = 0; i < PersonsPantry.getPantrySize(); i++)
            {
                this.HomePagePantry.Items.Add(createHomePagePantryText(PersonsPantry.getProductByIndex(i)));
                Product currentProduct = this.PersonsPantry.getProductByIndex(i);

                if (currentProduct.ExpirationDates.Count > 0)
                {
                    for (int j = 0; j < currentProduct.ExpirationDates.Count; j++)
                    {

                        if ((currentProduct.ExpirationDates[j].ActualDate - today).TotalDays <= 7)
                        {
                            this.expirationsBox.Items.Add(createHomePageExpirationText(currentProduct, j, today));
                        }
                    }
                }

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

        // method for generating string based on products 
        // for the home page expiration box
        public string createHomePageExpirationText(Product p, int index, DateTime today)
        {
            string productText = string.Empty;
            productText += p.Name + " expires in " + (p.ExpirationDates[index].ActualDate - today).TotalDays + " days";
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

        private void viewPantryButton_Click(object sender, EventArgs e)
        {
            var frm = new PantryStock(this);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void viewExpirationDatesButton_Click(object sender, EventArgs e)
        {
            var frm = new Calendar(this.PersonsPantry);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
