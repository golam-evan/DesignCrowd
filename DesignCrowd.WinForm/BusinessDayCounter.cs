using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignCrowd.WinForm
{
    public class BusinessDayCounter
    {
        public int WeekdaysBetweenTwoDates(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate >= secondDate) return 0;

            var weekdays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            var days = new List<string>();

            for (var day = firstDate.Date; day.Date <= secondDate.Date; day = day.AddDays(1))
            {
                if (day == firstDate || day == secondDate) 
                    continue;
                days.Add(day.DayOfWeek.ToString());
            }

            return days.FindAll(x => weekdays.Contains(x)).Count();
        }

        public int BusinessDaysBetweenTwoDates(DateTime firstDate, DateTime secondDate, IList<DateTime> publicHolidays)
        {
            if (firstDate >= secondDate) return 0;
           
            var weekdays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            var days = new List<string>();

            for (var day = firstDate.Date; day.Date <= secondDate.Date; day = day.AddDays(1))
            {
                if (day == firstDate || day == secondDate) 
                    continue;

                var notFoundPublicHoliday = !publicHolidays.Any(x => x == day);
                if (notFoundPublicHoliday)
                    days.Add(day.DayOfWeek.ToString());
            }
  

          return days.FindAll(x => weekdays.Contains(x)).Count();
        }
    }
}