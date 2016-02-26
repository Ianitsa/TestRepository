using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bigger_Num
{
    class BiggerNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers, each on a separate line.");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            
            int max = GetMax(firstNumber, secondNumber);

            
            Console.WriteLine("Output:");
            Console.WriteLine(max);
        }
        private static int GetMax(int a, int b)
        {
            int maxNum = (a > b) ? a : b;
            return maxNum;
        }
    }
}
