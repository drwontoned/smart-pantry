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
        private HomePage home;
        public List<SpecialDate> SpecialDates = new List<SpecialDate>();
        
        public Calendar(HomePage home)
        {
            InitializeComponent();
            createSpecialDates();
            textBox1.Text = "INIT";
            //sfCalendar1.AllowMultipleSelection = true;
            this.home = home;
            sfCalendar1.ShowToolTip = true;




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

            SpecialDate specialDate2 = new SpecialDate();
            specialDate2.BackColor = System.Drawing.Color.IndianRed;
            specialDate2.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            //specialDate1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic,System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            specialDate2.ForeColor = System.Drawing.Color.Black;
            specialDate2.Description = "1 expiring item";
            specialDate2.IsDateVisible = true;

            SpecialDates.Add(specialDate1);
            SpecialDates.Add(specialDate2);
            this.sfCalendar1.SpecialDates = SpecialDates;
        }

        //public List<SpecialDate> SpecialDates { get; set; }

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
            textBox1.Text = sfCalendar1.ViewMode.ToString();
            
            //e.Text = "TEST";
            // e.Value - Clicked cell date value
            // e.ViewType - Specifies the calendar viewtype
        }

        //private void SfCalendar_ToolTipOpening(SfCalendar sender, Syncfusion.WinForms.Input.Events.ToolTipOpeningEventArgs e)
        //{
            
        //    if (e.Value.Value.Date == new DateTime(2021, 04, 20))
        //    {
        //        e.ToolTipInfo.Items[0].Text = "Valentine's Day";
        //    }
        //    //if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Month && e.Value.Value.Date == new DateTime(2021, 04, 20))
        //    //{
        //    //    e.ToolTipInfo.Items[0].Text = "Valentine's Day";
        //    //}
        //    //if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Year && e.Value.Value.Month == DateTime.Now.Month)
        //    //{
        //    //    e.ToolTipInfo.Items[0].Text = e.Value.Value.Date.ToString("MMM");
        //    //}
        //    //if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Decade && e.RowIndex == 0)
        //    //{
        //    //    e.ToolTipInfo.Items[0].Text = "Decade";
        //    //}
        //    //if (e.ViewType == Syncfusion.WinForms.Input.Enums.CalendarViewType.Century && e.ColumnIndex == 1)
        //    //{
        //    //    e.ToolTipInfo.Items[0].Text = "Century";
        //    //}
        //}
    }
}
