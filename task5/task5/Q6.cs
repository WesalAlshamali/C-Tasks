using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{

    public class DateConverter
    {
        public static void Main()
        {
            string dateString = "12-08-2004";

            // Convert string to Date (yyyy-MM-dd format)
            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            string convertedDate = date.ToString("yyyy-MM-dd");
            Console.WriteLine($"Converted Date: {convertedDate}");

            // Convert string to DateTime (with time)
            DateTime dateTime = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            Console.WriteLine($"Converted DateTime: {dateTime}");
        }
    }
}
