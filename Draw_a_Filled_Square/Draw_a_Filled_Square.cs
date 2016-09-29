using System;

namespace Draw_a_Filled_Square
{
    class Draw_a_Filled_Square
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddleRow(n);
            PrintHeaderRow(n);

        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new
              string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
                Console.Write("\\/");
            Console.WriteLine('-');
        }
    }
}