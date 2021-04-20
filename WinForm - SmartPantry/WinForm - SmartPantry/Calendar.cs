using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Input;
using Syncfusion.SfCalendar;



namespace WinForm___SmartPantry
{
    public partial class Calendar : Form
    {
        public Pantry PersonsPantry = new Pantry();
        public HomePage home;
        public List<SpecialDate> SpecialDates = new List<SpecialDate>();
        public List<String> specialDateInfo = new List<String>();
        public DateTime currentDate;
        
        public Calendar(Pantry pantry)
        {
            InitializeComponent();
            //this.home = home;
            this.PersonsPantry = pantry;
            MakeAllSpecialDates();
            //richTextBox1.Text = "INIT";
            //sfCalendar1.AllowMultipleSelection = true;            
            sfCalendar1.ShowToolTip = true;
            removebutton.Enabled = false;
        }

        /*
        private void createSpecialDates()
        {
            SpecialDate specialDate1 = new SpecialDate();
            specialDate1.BackColor = System.Drawing.Color.IndianRed;
            specialDate1.Value = new System.DateTime(2021, 4, 21);
            specialDate1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate1.ForeColor = System.Drawing.Color.Black;
            specialDate1.Description = "1 expiring item";
            specialDate1.IsDateVisible = true;
            string specialDate1Info = "Item: Bread\nLocation: Cupboard\nAmount: 1";

            SpecialDate specialDate2 = new SpecialDate();
            specialDate2.BackColor = System.Drawing.Color.IndianRed;
            specialDate2.Value = new System.DateTime(2021, 4, 30);
            specialDate2.ForeColor = System.Drawing.Color.Black;
            specialDate2.Description = "1 expiring item";
            specialDate2.IsDateVisible = true;
            string specialDate2Info = "Item: Milk\nLocation: Fridge\nAmount: 1";

            SpecialDates.Add(specialDate1);
            SpecialDates.Add(specialDate2);
            this.sfCalendar1.SpecialDates = SpecialDates;

            specialDateInfo.Add(specialDate1Info);
            specialDateInfo.Add(specialDate2Info);
        }*/

        private void MakeAllSpecialDates()
        {
            for(int i = 0; i < this.PersonsPantry.getPantrySize(); i++)
            {
                Product currentProduct = this.PersonsPantry.getProductByIndex(i);
                if (currentProduct.ExpirationDates.Count > 0)
                {
                    for(int j = 0; j < currentProduct.ExpirationDates.Count; j++)
                    {
                        SpecialDates.Add(SpecialDateMaker(currentProduct, j));
                        specialDateInfo.Add(SpecialDateInfoMaker(currentProduct, j));
                    }
                }
            }
            this.sfCalendar1.SpecialDates = SpecialDates;
        }

        private SpecialDate SpecialDateMaker(Product p, int index)
        {
            
            ExpirationDate expDate = p.ExpirationDates[index];
            DateTime actualExpDate = p.ExpirationDates[index].ActualDate;
            int amount = AmountOnADate(actualExpDate);

            SpecialDate date = new SpecialDate();
            date.BackColor = System.Drawing.Color.LightBlue;
            date.Value = actualExpDate;
            date.ForeColor = System.Drawing.Color.Black;
            if (amount > 1)
            {
                date.Description = amount + " expiring items";
            }
            else
            {
                date.Description = amount + " expiring item";
            }
            date.IsDateVisible = true;

            return date;
        }

        private int AmountOnADate(DateTime date)
        {
            int amount = 0;
            for (int i = 0; i < this.PersonsPantry.getPantrySize(); i++)
            {
                Product currentProduct = this.PersonsPantry.PantryList[i];
                if (currentProduct.ExpirationDates.Count > 0)
                {
                    for (int j = 0; j < currentProduct.ExpirationDates.Count; j++)
                    {
                        if (currentProduct.ExpirationDates[j].ActualDate == date)
                        {
                            amount += currentProduct.ExpirationDates[j].Amount;
                        }
                    }
                }
            }
            return amount;
        }

        private string SpecialDateInfoMaker(Product p, int index)
        {
            string info = string.Empty;
            info += "Item: " + p.Name + "\r\n";
            if(p.Location != string.Empty)
            {
                info += "Location: " + p.Location + "\r\n";
            }
            if(p.Type != string.Empty)
            {
                info += "Type: " + p.Type + "\r\n";
            }
            info += "Amount: " + p.ExpirationDates[index].Amount + "\r\n \r\n \r\n";
            return info;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            var frm = new HomePage(this.PersonsPantry);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        
        // Occurs before the selected date is changed in Calendar.
        private void sfCalendar1_SelectionChanging(SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangingEventArgs e)
        {
            var newDate = e.NewValue;
            if (newDate == new System.DateTime(2019, 08, 13))
                e.Cancel = true;
            //textBox1.Text = "POG";
        }

        // Occurs after the selected date is changed in Calendar.
        private void sfCalendar1_SelectionChanged(SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            // this.sfCalendar1.SelectionChanged += sfCalendar1_SelectionChanged;

            var newDate = e.NewValue;
            
            //var oldDate = e.OldValue;
            
            if (newDate != null)
            {
                currentDate = (DateTime)newDate;
            }
            //textBox1.Text = currentDate.ToString();

        }

        private void sfCalendar1_Click(object sender, EventArgs e)
        {
            ///textBox1.Text = "TESTTTTTTTTTTTTT";
        }

        private void sfCalendar1_CellClick(object sender, Syncfusion.WinForms.Input.Events.CalendarCellEventArgs e)
        {
            //this.sfCalendar1.CellClick += sfCalendar1_CellClick;

            // e.DateRange - Start and end range value of clicked cell
            // e.IsBlackoutDate - Indicate whether the date cell is BlackoutDate
            // e.IsSpecialDate - Indicate whether the date cell is SpecialDate
            // e.IsWeekNumber - Indicate whether the date cell is WeekNumber            
            // e.Text = "TEST";
            // e.Value - Clicked cell date value
            // e.ViewType - Specifies the calendar viewtype
            richTextBox1.Text = string.Empty;
            if (e.IsSpecialDate == true)
            {
                removebutton.Enabled = true;
                //textBox1.Text = SpecialDates[0].Value.ToString();

                if (SpecialDates.Count > 0)
                {
                    int count = 0;
                    foreach (SpecialDate dat in SpecialDates)
                    {
                        if (dat.Value == currentDate)
                        {
                            richTextBox1.Text += specialDateInfo[count];

                        }
                        count++;
                    }
                }
                else
                    return;
            }
            else
            {
                removebutton.Enabled = false;
                richTextBox1.Text = "";
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< this.SpecialDates.Count; i++)
            {
                if (this.SpecialDates[i].Value == currentDate)
                {
                    this.SpecialDates.Remove(SpecialDates[i]);
                    this.specialDateInfo.Remove(specialDateInfo[i]);
                }
            }
            
            removebutton.Enabled = false;
            richTextBox1.Text = "";

            for (int i = 0; i < this.PersonsPantry.getPantrySize(); i++)
            {
                Product currentProduct = this.PersonsPantry.PantryList[i];
                if (currentProduct.ExpirationDates.Count > 0)
                {
                    for (int j = 0; j < currentProduct.ExpirationDates.Count; j++)
                    {
                        if (currentProduct.ExpirationDates[j].ActualDate == currentDate)
                        {
                            currentProduct.removeStock(currentProduct.ExpirationDates[j].Date, currentProduct.ExpirationDates[j].Amount);
                            if (currentProduct.Stock == 0)
                            {
                                this.PersonsPantry.removeFromPantry(currentProduct);
                            }
                        }
                    }
                }
            }
        }
    }
}
