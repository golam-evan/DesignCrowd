using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignCrowd.WinForm
{
    public class PublicHolidayCalculator
    {
        public List<DateTime> Calculatate(DateTime firstDate, DateTime secondDate)
        {
            List<String> mandatoryHolidays = new List<string> { "January 1", "January 26", "April 25", "December 25", "December 26" };

            List<DateTime> holidays = new List<DateTime>();

            if(secondDate.DayOfYear < firstDate.DayOfYear)
            {
                holidays.Add(QueenBirthday(secondDate));
                holidays.Add(CalcGoodFri(secondDate.Year));
            }

            for (var day = firstDate.Date; day.Date <= secondDate.Date; day = day.AddYears(1))
            {
                //Queens birthday
                holidays.Add(QueenBirthday(day));
                //GoodFriday
                holidays.Add(CalcGoodFri(day.Year));
            }

            for (var day = firstDate.Date; day.Date <= secondDate.Date; day = day.AddDays(1))
            {
                var monthName = day.ToString("MMMM");
                var dayName = day.DayOfWeek.ToString();
                if (dayName == "Saturday" || dayName == "Sunday")      //weekly holiday
                {
                    if ($"{monthName} {day.Day}" == "January 1" || $"{monthName} {day.Day}" == "January 26")
                    {
                        var nextMonday = day.AddDays(dayName == "Saturday" ? 2 : 1);
                        holidays.Add(nextMonday);
                    }
                }

                if (mandatoryHolidays.Any(x => x == $"{monthName} {day.Day}"))
                {
                    holidays.Add(day);
                }
            }

            return holidays.Distinct().OrderBy(x => x).ToList();
        }

        private DateTime QueenBirthday(DateTime currentYear)
        {
            DateTime FindNext(DayOfWeek dayOfWeek, DateTime after)
            {
                DateTime day = after;
                while (day.DayOfWeek != dayOfWeek) 
                    day = day.AddDays(1);
                return day;
            }
            var day = new DateTime(currentYear.Year, 6, 1);
            day = FindNext(DayOfWeek.Monday, day);
            day = FindNext(DayOfWeek.Monday, day.AddDays(1));
            return day;
        }

        private DateTime CalcGoodFri(int yr)
        {
            //int yr = 2010;  // The year for which to determine the date of Good Friday.
            int a = yr % 19;
            int b = yr / 100;
            int c = yr % 100;
            int d = b / 4;
            int e = b % 4;
            int i = c / 4;
            int k = c % 4;
            int g = (8 * b + 13) / 25;
            int h = ((19 * a) + b - d - g + 15) % 30;
            int l = ((2 * e) + (2 * i) - k + 32 - h) % 7;
            int m = (a + (11 * h) + (19 * l)) / 433;
            int days_to_good_friday = h + l - (7 * m) - 2;
            int mo = (days_to_good_friday + 90) / 25;
            int da = (days_to_good_friday + (33 * mo) + 19) % 32;
            return new DateTime(yr, mo, da);    // Returns the date of Good Friday
        }
    }
}