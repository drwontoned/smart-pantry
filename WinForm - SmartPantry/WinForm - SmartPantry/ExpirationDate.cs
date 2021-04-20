using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm___SmartPantry
{
    public class ExpirationDate
    {
        // experation date and amount expiring fields
        private string date = string.Empty;
        private int amount = 0;
        private DateTime actualDate;

        // getters for the dates and amount
        public string Date { get => this.date; }
        public int Amount { get => this.amount; }

        public DateTime ActualDate { get => this.actualDate; }

        // constructor
        public ExpirationDate(string date, int amount)
        {
            this.date = date;
            this.amount = amount;
            this.actualDate = convertStringToDate(date);
        }

        // method to update amount
        public void updateAmount(int newAmount)
        {
            this.amount = newAmount;
        }

        // methods for setting up date time
        private DateTime convertStringToDate(string date)
        {
            int year = toYear(date);
            int month = toMonth(date);
            int day = toDay(date);
            return new DateTime(year, month, day);
        }

        // method to get int for year
        private int toYear(string date)
        {
            string productYear = string.Empty;
            for (int i = 6; i <= 9; i++)
            {
                productYear += date[i];
            }

            return Int32.Parse(productYear);
        }

        // method to get int for month
        private int toMonth(string date)
        {
            string productMonth = string.Empty;
            for (int i = 0; i <= 1; i++)
            {
                productMonth += date[i];
            }

            return Int32.Parse(productMonth);
        }

        // method to get int for day
        private int toDay(string date)
        {
            string productDay = string.Empty;
            for (int i = 3; i <= 4; i++)
            {
                productDay += date[i];
            }

            return Int32.Parse(productDay);
        }
    }
}
