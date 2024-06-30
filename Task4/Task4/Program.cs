using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static (int, double) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = (double)sum / numbers.Length;
            return (sum, average);
        }
        static void Main(string[] args)
        {
            //-----------Q1---------
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number-{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            (int sum, double average) = CalculateSumAndAverage(numbers);

            Console.WriteLine($"The sum of 10 numbers is: {sum}");
            Console.WriteLine($"The average is: {average:F6}");

            //-----------Q2------------
            Console.Write("Input number of terms: ");
            int n = int.Parse(Console.ReadLine());

            DisplayCubes(n);
            //---------Q3------------
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            int[] filteredYears = GetYears(years);

            Console.WriteLine("Years greater than 1950:");
            foreach (int yeara in filteredYears)
            {
                Console.WriteLine(yeara);
            }
            //---Q4-------
            int ageInYears = 25; // Example age in years

            int ageInDays = CalculateAgeInDays(ageInYears);

            Console.WriteLine($"Age in years: {ageInYears}");
            Console.WriteLine($"Age in days: {ageInDays}");

            //-----------Q5-----

            int totalLegs = CountLegs(2, 3, 5);
            Console.WriteLine($"Total number of legs: {totalLegs}");
            //-------------Q6---------

            string username = "user1";
            string password = "password1";

            string result = Login(username, password);
            Console.WriteLine($"Login result: {result}");
            //-------------Q7---------
            int baseNumber = 2;
            int exponent = 5;

            double result2 = CalculatePower(baseNumber, exponent);
            Console.WriteLine($"{baseNumber}^{exponent} = {result2}");

            //-------------Q8--------
            int year = 2020;

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            //-------------------Q9--------------
            int number = 17;

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
            //------------------Q10------------
            string sentence = "Hello, this is a sample sentence.";

            int wordCount = CountWords(sentence);
            Console.WriteLine($"Number of words in the sentence: {wordCount}");
            Console.ReadKey();
        }
        static void DisplayCubes(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{cube}");
            }
        }
        static int[] GetYears(int[] years)
        {
            return years.Where(year => year > 1950).ToArray();
        }
        static int CalculateAgeInDays(int ageInYears)
        {
            int daysInAYear = 365;
            int ageInDays = ageInYears * daysInAYear;
            return ageInDays;
        }
        static int CountLegs(int chickens, int cows, int pigs)
        {

            if (chickens % 2 != 0 || cows % 2 != 0 || pigs % 2 != 0)
            {
                throw new ArgumentException("Input must be even numbers.");
            }

            int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return totalLegs;
        }
        static string Login(string username, string password)
        {

            string[,] users = {
            { "user1", "password1" },
            { "user2", "password2" },
            { "user3", "password3" }
        };


            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (username == users[i, 0] && password == users[i, 1])
                {
                    return "Pass";
                }
            }

            return "Failed";
        }
        static double CalculatePower(int baseNumber, int exponent)
        {
           
            double result3 = Math.Pow(baseNumber, exponent);
            return result3;
        }
        static bool IsLeapYear(int year)
        {
            
            if (year < 1900 || year > 2024)
            {
                throw new ArgumentOutOfRangeException("Year must be between 1900 and 2024.");
            }

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPrime(int number)
        {

            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
            static int CountWords(string sentence)
            {
                int wordCount = 0;
                bool inWord = false;

                // Iterate through each character in the sentence
                foreach (char c in sentence)
                {
                    // Check if current character is a letter or digit (part of a word)
                    if (char.IsLetterOrDigit(c))
                    {
                        // If not already in a word, count it as a new word
                        if (!inWord)
                        {
                            wordCount++;
                            inWord = true;
                        }
                    }
                    else
                    {
                        // If current character is not a letter or digit (space or punctuation), not in a word
                        inWord = false;
                    }
                }

                return wordCount;
            }
        }
        }
   

