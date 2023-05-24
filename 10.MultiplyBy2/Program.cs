using System;

namespace P10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2 = 0;
            for (int i = 1; i >= 0; i++)
            {
                n1 = double.Parse(Console.ReadLine());

                if (n1 >= 0)
                {
                    n2 = n1 * 2;
                    Console.WriteLine($"Result: {n2:f2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                    break;
                }

            }
        }
    }
}
