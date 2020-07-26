using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesignCrowd.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Parse(dtStartDate.Text);
            var endDate = DateTime.Parse(dtEndDate.Text);
            lblResult.Text = new BusinessDayCounter().WeekdaysBetweenTwoDates(startDate, endDate).ToString();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            List<DateTime> publicHolidays = new List<DateTime>();
            publicHolidays.Add(DateTime.Parse("2013-12-25"));
            publicHolidays.Add(DateTime.Parse("2013-12-26"));
            publicHolidays.Add(DateTime.Parse("2014-01-01"));

            var startDate = DateTime.Parse(dtStartDate.Text);
            var endDate = DateTime.Parse(dtEndDate.Text);

            lblResult.Text = new BusinessDayCounter().BusinessDaysBetweenTwoDates(startDate, endDate, publicHolidays).ToString();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Parse(dtStartDate.Text);
            var endDate = DateTime.Parse(dtEndDate.Text);
            var publicHolidays = new PublicHolidayCalculator().Calculatate(startDate, endDate);
            lblResult.Text = new BusinessDayCounter().BusinessDaysBetweenTwoDates(startDate, endDate, publicHolidays).ToString();
        }
    }
}