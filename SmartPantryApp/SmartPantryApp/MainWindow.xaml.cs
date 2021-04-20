using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartPantryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Pantry = new List<Product>();
        public MainWindow()
        {
            Product CinnamonToastCrunch = new Product("Cinnamon Toast Crunch", 1);
            CinnamonToastCrunch.Type = "Cereal";
            CinnamonToastCrunch.Location = "Kitchen Pantry - 3rd shelf";

            Product WholeMilk = new Product("Whole Milk", 0);
            WholeMilk.Type = "Dairy";
            WholeMilk.Location = "Fridge";
            WholeMilk.addStock("04/20/2021", 1);

            Product Vodka = new Product("Vodka", 0);
            Vodka.Type = "Alchohol";
            Vodka.Location = "Liquor Cabinet";
            Vodka.addStock("4/15/2036", 1);

            Pantry.Add(CinnamonToastCrunch);
            Pantry.Add(WholeMilk);
            Pantry.Add(Vodka);
            HomePagePantry = new ListBox();

            for (int i = 0; i < Pantry.Count; i++)
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.name
                HomePagePantry.Items.Add(newItem);
            }
            InitializeComponent();
            
        }

        public string createHomePagePantryText(Product p)
        {
            return p.Name + "       " + p.Stock;
        }
    }
}
