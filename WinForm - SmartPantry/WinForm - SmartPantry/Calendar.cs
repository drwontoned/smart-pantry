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
        public Pantry PersonsShoppinglist = new Pantry();
        public HomePage home;
        public List<SpecialDate> SpecialDates = new List<SpecialDate>();
        public List<String> specialDateInfo = new List<String>();
        public DateTime currentDate;
        
        public Calendar(HomePage home)
        {
            InitializeComponent();
            createSpecialDates();
            //richTextBox1.Text = "INIT";
            //sfCalendar1.AllowMultipleSelection = true;
            this.home = home;
            sfCalendar1.ShowToolTip = true;
            removebutton.Enabled = false;
        }

        private void createSpecialDates()
        {
            SpecialDate specialDate1 = new SpecialDate();
            specialDate1.BackColor = System.Drawing.Color.IndianRed;
            specialDate1.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            //specialDate1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate1.ForeColor = System.Drawing.Color.Black;
            specialDate1.Description = "1 expiring item";
            specialDate1.IsDateVisible = true;
            string specialDate1Info = "Item: Bread\nLocation: Cupboard\nAmount: 1";

            SpecialDate specialDate2 = new SpecialDate();
            specialDate2.BackColor = System.Drawing.Color.IndianRed;
            specialDate2.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            //specialDate1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate2.ForeColor = System.Drawing.Color.Black;
            specialDate2.Description = "1 expiring item";
            specialDate2.IsDateVisible = true;
            string specialDate2Info = "Item: Milk\nLocation: Fridge\nAmount: 1";

            SpecialDates.Add(specialDate1);
            SpecialDates.Add(specialDate2);
            this.sfCalendar1.SpecialDates = SpecialDates;

            specialDateInfo.Add(specialDate1Info);
            specialDateInfo.Add(specialDate2Info);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.home.Location = this.Location;
            this.home.StartPosition = FormStartPosition.Manual;
            this.home.FormClosing += delegate { this.Show(); };
            this.home.Show();
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
                            richTextBox1.Text = specialDateInfo[count];

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
            if (SpecialDates.Count > 0)
            {
                if (SpecialDates[0].Value == currentDate)
                {
                    SpecialDates.Remove(SpecialDates[0]);
                    specialDateInfo.Remove(specialDateInfo[0]);
                    removebutton.Enabled = false;
                    richTextBox1.Text = "";
                }
                else if (SpecialDates[1].Value == currentDate)
                {
                    SpecialDates.Remove(SpecialDates[1]);
                    specialDateInfo.Remove(specialDateInfo[1]);
                    removebutton.Enabled = false;
                    richTextBox1.Text = "";
                }
            }
            else
                return;
        }
    }
}
