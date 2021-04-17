using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantryApp
{
    public class ExpirationDate
    {
        // experation date and amount expiring fields
        private string date = string.Empty;
        private int amount = 0;

        // getters for the date and amount
        public string Date {get => this.date;}
        public int Amount { get => this.amount; }

        // constructor
        public ExpirationDate(string date, int amount)
        {
            this.date = date;
            this.amount = amount;
        }

        // method to update amount
        public void updateAmount(int newAmount)
        {
            this.amount = newAmount;
        }
    }
}
