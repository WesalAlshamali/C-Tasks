using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 Correct the syntax error:

            //string[] ARR = [1, 7  9  45,]
            //int arr2 = ["Str" "alex","moh"
            //string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] ARR = { "1", "7", "9", "45" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox" ,"over" ,"lazy", "dog"};

            //Q2 What the index of "Banana","Tomato" ?
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
           Console.WriteLine( fruits[0]);//Tomato
            Console.WriteLine(fruits[1]);//Banana

            //Q3
            

            string[] favfood = {"pizaa","mansaf","macronaa"};
            foreach (string item in fruits) {
                Console.WriteLine(item);
            }
            string[] favspoort= { "football", "runinng", "anything" };
            foreach (string items in favspoort)
            {
                Console.WriteLine(items);
            }
            string[] favmovie = { "littlewomen", "prisoners", "anything" };
            foreach (string i in favspoort)
            {
                Console.WriteLine(i);
            }

            //Q4
          
            Console.WriteLine("first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("third number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("you intered:"+num1 + "," +num2+","+num3);
            int sum=num1 + num2+num3;
            Console.WriteLine("the sum is :" +sum);

            //Q5
           
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

            //Q6 
            
            //int n = 3; 

            //for (int i = 1; i <= n; i++)
            //{


            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // ---Q7---
            int n = 4; // Number of rows
            int number = 1;

            for (int i = 1; i <= n; i++)
            {
             
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();






        }
    }
}
