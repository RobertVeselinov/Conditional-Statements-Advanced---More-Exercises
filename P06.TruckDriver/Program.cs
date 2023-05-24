using System;

namespace P06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    price += kmPerMonth * 0.75 * 4;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    price += kmPerMonth * 0.95 * 4;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    price += kmPerMonth * 1.45 * 4;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    price += kmPerMonth * 0.90 * 4;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    price += kmPerMonth * 1.10 * 4;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    price += kmPerMonth * 1.45 * 4;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    price += kmPerMonth * 1.05 * 4;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    price += kmPerMonth * 1.25 * 4;
                }
                else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    price += kmPerMonth * 1.45 * 4;
                }
            }
            price -= price * 0.1;
            Console.WriteLine($"{price:f2}");
        }
    }
}
