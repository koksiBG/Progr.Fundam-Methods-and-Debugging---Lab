using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Math_Power
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double square = RaiseToPower(number, power);
            Console.WriteLine(square);
        }

        static double RaiseToPower(double number, int power)
        {
            
            double result = Math.Pow(number, power);
            return result;
        }
    }
}