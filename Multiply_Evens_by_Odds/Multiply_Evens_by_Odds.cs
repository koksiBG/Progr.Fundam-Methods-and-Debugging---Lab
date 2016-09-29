using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Multiply_Evens_by_Odds
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndodds(n));
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) sum += lastDigit;
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0) sum += lastDigit;
                n /= 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvenAndodds(int n)
        {
            int sumOdd = GetSumOfOddDigits(n);
            int sumEven = GetSumOfEvenDigits(n);
            int multipleOfEvenAndodds = sumOdd * sumEven;
            return multipleOfEvenAndodds;
        }
    }
}