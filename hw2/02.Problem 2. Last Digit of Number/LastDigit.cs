using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem_2.Last_Digit_of_Number
{
    class LastDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            // the method
            Console.WriteLine("The last digit is: {0}", GetLastDigitAsWord(number));
        }
        private static string GetLastDigitAsWord(int num)
        {
            string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = num % 10;

            return digitAsWord[digit];
        }
    }
}
