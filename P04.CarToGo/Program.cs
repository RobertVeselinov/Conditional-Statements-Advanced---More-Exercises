using System;

namespace P04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string carClass = string.Empty;
            string carType = string.Empty;

            if (budget <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget - budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget - budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";

                if (season == "Summer") 
                {
                    carType = "Cabrio";
                    price = budget - budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget - budget * 0.8;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget - budget * 0.9;
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {budget - price:f2}");
        }
    }
}
