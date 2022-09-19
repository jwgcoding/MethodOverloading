// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    class Program
    {
        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        //Now create an overload of the Add method to account for being able to add two decimals together
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue)
            {
                sum = num1 + num2;
               
                response = (sum == 1) ? $"{sum} dollar." : $"{sum} dollars."; 
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine();
            Console.WriteLine(Add(10, 6, true));
            Console.WriteLine();
        }


    }
}