using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{

    public class DateDifferenceCalculator
    {
        private DateTime date1;
        private DateTime date2;

        public DateDifferenceCalculator(DateTime date1, DateTime date2)
        {
            this.date1 = date1;
            this.date2 = date2;
        }

        public void CalculateDifference(out int years, out int months, out int days)
        {
            if (date1 > date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            years = date2.Year - date1.Year;
            months = date2.Month - date1.Month;
            days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(date2.Year, date2.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }
        }

    }
}
