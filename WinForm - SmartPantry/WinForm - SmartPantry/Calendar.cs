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
    public partial class Calendar : Form
    {
        public Pantry PersonsShoppinglist = new Pantry();
        private HomePage home;
        public Calendar(HomePage home)
        {
            InitializeComponent();
            textBox1.Text = "INIT";
            //sfCalendar1.AllowMultipleSelection = true;
            this.home = home;
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
        private void sfCalendar1_SelectionChanging(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangingEventArgs e)
        {
            var newDate = e.NewValue;
            if (newDate == new System.DateTime(2019, 08, 13))
                e.Cancel = true;
            //textBox1.Text = "POG";
        }

        // Occurs after the selected date is changed in Calendar.
        private void sfCalendar1_SelectionChanged(Syncfusion.WinForms.Input.SfCalendar sender, Syncfusion.WinForms.Input.Events.SelectionChangedEventArgs e)
        {
            var newDate = e.NewValue;
            var oldDate = e.OldValue;
            //textBox1.Text = "POG2";
        }

        private void sfCalendar1_Click(object sender, EventArgs e)
        {
            ///textBox1.Text = "TESTTTTTTTTTTTTT";
        }

        private void sfCalendar1_CellClick(object sender, Syncfusion.WinForms.Input.Events.CalendarCellEventArgs e)
        {
            // e.DateRange - Start and end range value of clicked cell
            // e.IsBlackoutDate - Indicate whether the date cell is BlackoutDate
            // e.IsSpecialDate - Indicate whether the date cell is SpecialDate
            // e.IsWeekNumber - Indicate whether the date cell is WeekNumber
            textBox1.Text = e.Text;

            //e.Text = "TEST";
            // e.Value - Clicked cell date value
            // e.ViewType - Specifies the calendar viewtype
        }
    }
}
