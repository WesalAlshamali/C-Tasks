using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //-------------Q1-------------
            Q1 myObject = new Q1();
            //-------------Q2-------------
            Q2 intro = new Q2();
            intro.DisplayMessage("Scott");
            //-------------Q3-------------
            FactorialCalculator calculator = new FactorialCalculator();

           
            int number = 5;
            int factorial = calculator.CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is: {factorial}");

            //-------------Q4--------------
            ArraySorter sorter = new ArraySorter();

            int[] array = { 11, -2, 4, 35, 0, 8, -9 };

            
            int[] sortedArray = sorter.SortArray(array);

           
            Console.Write("Sorted array: { ");
            foreach (int num in sortedArray)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("}");

            //-------------Q5--------------
            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);

            DateDifferenceCalculator calc = new DateDifferenceCalculator(date1, date2);
            int years, months, days;
            calc.CalculateDifference(out years, out months, out days);

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
            //-------------Q6--------------
            string dateString = "12-08-2004";

            // Convert string to Date (yyyy-MM-dd format)
            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            string convertedDate = date.ToString("yyyy-MM-dd");
            Console.WriteLine($"Converted Date: {convertedDate}");

            // Convert string to DateTime (with time)
            DateTime dateTime = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            Console.WriteLine($"Converted DateTime: {dateTime}");

            Console.ReadKey();
        }
    }
}
