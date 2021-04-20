using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm___SmartPantry
{
    public class Product
    {
        // name, stock, type, location, expiration dates, and prices fields

        // absolutely necessary fields
        private string name = string.Empty;
        private int stock = 0;

        // optional fields
        private string type = string.Empty;
        private string location = string.Empty;
        private List<ExpirationDate> expirationDates = new List<ExpirationDate>();
        private List<double> prices = new List<double>();


        // getters and setters for all fields
        public string Name { get => this.name; set => this.name = value; }

        public string Type { get => this.type; set => this.type = value; }

        public string Location { get => this.location; set => this.location = value; }

        public int Stock { get => this.stock; set => this.stock = value; }

        public List<ExpirationDate> ExpirationDates { get => this.expirationDates; set => this.expirationDates = value; }

        public List<double> Prices { get => this.prices; set => this.prices = value; }

        // constructor
        public Product(string name, int stock)
        {
            this.name = name;
            this.stock = stock;
        }

        public Product(string name, int stock, string type)
        {
            this.name = name;
            this.stock = stock;
            this.type = type;
        }

        public Product(string name, int stock, string type, string location)
        {
            this.name = name;
            this.stock = stock;
            this.type = type;
            this.location = location;
        }

        public Product(string name, int stock, List<double> prices)
        {
            this.name = name;
            this.stock = stock;
            this.Prices = prices;
        }

        public Product(string name, int stock, string type, List<double> prices)
        {
            this.name = name;
            this.stock = stock;
            this.type = type;
            this.Prices = prices;
        }

        public Product(string name, int stock, string type, string location, List<double> prices)
        {
            this.name = name;
            this.stock = stock;
            this.type = type;
            this.location = location;
            this.Prices = prices;
        }

        // method for adding stock without expiration
        public void addStock(int newStock)
        {
            this.stock += newStock;
        }

        // method for adding stock without expiration but with a price.
        public void addStock(int newStock, double price)
        {
            // Add a copy of the price to the prices list for each copy of the item.
            for (int i = 0; i < newStock; i++)
            {
                this.Prices.Add(price);
            }

            // Update overall stock.
            this.addStock(newStock);
        }

        // method for adding stock with expiration
        public void addStock(string date, int newStock)
        {
            bool added = false;

            // check if expiration date already exists
            for (int i = 0; i < this.expirationDates.Count; i++)
            {

                // if it exists then update the amount
                if (expirationDates[i].Date == date)
                {
                    int currentStock = expirationDates[i].Amount;
                    int updatedStock = currentStock + newStock;
                    this.expirationDates[i].updateAmount(updatedStock);
                    added = true;
                }
            }

            // if expiration date does not already exist then add a new one to the list
            if (!added)
            {
                expirationDates.Add(new ExpirationDate(date, newStock));
            }

            // also update overall stock
            this.addStock(newStock);
        }

        // method for adding stock with all info
        public void addStock(string date, int newStock, double price)
        {
            // Add a copy of the price to the prices list for each copy of the item.
            for (int i = 0; i < newStock; i++)
            {
                this.Prices.Add(price);
            }

            // Handle date additions.
            this.addStock(date, newStock);
        }

        // method for removing stock without expiration
        public void removeStock(int newStock)
        {
            this.stock -= newStock;

            // if the user input to remove more stock than available set the stock to 0
            if (this.stock < 0)
            {
                stock = 0;
            }
        }

        // method for removing stock without expiration but with a price.
        public void removeStock(int newStock, double price)
        {
            int removalCount = 0;
            int count = 0;
            // Remove a copy of the price to the prices list for each copy of the item.
            while(removalCount != newStock || count != this.Prices.Count)
            {
                if (price == this.Prices[count])
                {
                    this.Prices.RemoveAt(count);
                    removalCount++;
                }

                count++;
            }

            // Update overall stock.
            this.removeStock(newStock);
        }

        // method for removing stock with expiration
        public void removeStock(string date, int newStock)
        {
            // check if expiration date already exists
            for (int i = 0; i < this.expirationDates.Count; i++)
            {

                // if it exists then update the amount
                if (expirationDates[i].Date == date)
                {
                    int currentStock = expirationDates[i].Amount;
                    int updatedStock = currentStock - newStock;

                    // if the user input to remove more stock than available set the stock to 0
                    if (updatedStock < 0)
                    {
                        updatedStock = 0;
                    }
                    this.expirationDates[i].updateAmount(updatedStock);

                    // also update overall stock
                    this.removeStock(newStock);
                }
            }

            // if expiration date does not already exist then nothing happens
        }

        // method for removing stock with all information.
        public void removeStock(string date, int newStock, double price)
        {
            int removalCount = 0;
            int count = 0;
            // Remove a copy of the price to the prices list for each copy of the item.
            while (removalCount != newStock || count != this.Prices.Count)
            {
                if (price == this.Prices[count])
                {
                    this.Prices.RemoveAt(count);
                    removalCount++;
                }

                count++;
            }

            // Handle date removals
            this.removeStock(date, newStock);
        }

            // method for converting the list of expiration dates to strings
            public string getAllDates()
        {
            string datesAndAmounts = string.Empty;

            // for each expiration date create a formatted string Date - Amount and then a new line
            for (int i = 0; i < this.expirationDates.Count; i++)
            {
                datesAndAmounts += this.expirationDates[i].Date + " - " + this.expirationDates[i].Amount + "\r\n";
            }

            // return the string with all the dates and amounts
            return datesAndAmounts;
        }

        public string getOldestDate()
        {
            string oldestDate = string.Empty;
            for (int i = 0; i < this.expirationDates.Count; i++)
            {
                if (i == 0)
                {
                    oldestDate = this.expirationDates[i].Date;
                }
                else
                {
                    if (oldestDate.CompareTo(this.expirationDates[i].Date) > 0)
                    {
                        oldestDate = this.expirationDates[i].Date;
                    }
                }
            }
            return oldestDate;
        }

        public double getAveragePrice()
        {
            double average = 0;

            // add up all the prices
            for (int i = 0; i < this.prices.Count; i++)
            {
                average += this.prices[i];
            }

            // divide it by the amount of collected prices
            average /= this.prices.Count;

            // return calculated average
            return average;
        }
    }
}
