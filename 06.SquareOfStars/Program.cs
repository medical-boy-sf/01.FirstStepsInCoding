using System;

namespace _06.SquareOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 3 && n <= 100)
            {
                Console.WriteLine(new String('*', n));

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write("*");
                    Console.Write(new string(' ', n - 2));
                    Console.WriteLine("*");
                }

                Console.WriteLine(new String('*', n));
            }
        }
    }
}
