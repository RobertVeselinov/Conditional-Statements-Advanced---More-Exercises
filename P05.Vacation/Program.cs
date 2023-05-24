using System;

namespace P05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string stayPlace = string.Empty;
            double price = 0;
            string location = string.Empty;

            if (budget <= 1000)
            {
                stayPlace = "Camp";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                stayPlace = "Hut";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                stayPlace = "Hotel";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.9;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.9;
                }
            }
            Console.WriteLine($"{location} - {stayPlace} - {price:f2}");
        }
    }
}
