using System;

namespace PascalTriangle
{
    class Program
{
    static public void Main()
    {
        int i, n, c;
        Console.WriteLine("Input rows number:");
        string s = Console.ReadLine();
        n = Convert.ToInt32(s);

        for (i = 0; i < n; i++)
        {
            for (c = 0; c <= (n - i); c++)
            {
                Console.Write(" ");
            }
            for (c = 0; c <= i; c++)
            {
                Console.Write(" ");
                Console.Write("*");
                    // Console.Write(Factorial.factorial(i) / (Factorial.factorial(c) * Factorial.factorial(i - c)));
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
}