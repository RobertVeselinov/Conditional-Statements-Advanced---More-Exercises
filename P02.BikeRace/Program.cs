using System;

namespace P02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorsBicyclers = int.Parse(Console.ReadLine());
            int seniorsBicyclers = int.Parse(Console.ReadLine());
            string routeType = Console.ReadLine();

            int quantityBicyclers = juniorsBicyclers + seniorsBicyclers;
            double priceJuniors = 0;
            double priceSeniors = 0;

            if (routeType == "trail")
            {
                priceJuniors = juniorsBicyclers * 5.50;
                priceSeniors = seniorsBicyclers * 7;
            }
            else if (routeType == "cross-country")
            {
                if (quantityBicyclers >= 50)
                {
                    priceJuniors = juniorsBicyclers * (8 - 8 * 0.25);
                    priceSeniors = seniorsBicyclers * (9.50 - 9.50 * 0.25);
                }
                else
                {
                    priceJuniors = juniorsBicyclers * 8;
                    priceSeniors = seniorsBicyclers * 9.50;
                }
            }
            else if (routeType == "downhill")
            {
                priceJuniors = juniorsBicyclers * 12.25;
                priceSeniors = seniorsBicyclers * 13.75;
            }
            else if (routeType == "road")
            {
                priceJuniors = juniorsBicyclers * 20;
                priceSeniors = seniorsBicyclers * 21.50;
            }
            double sumAll = priceJuniors + priceSeniors;
            sumAll -= sumAll * 0.05;

            Console.WriteLine($"{sumAll:f2}");
        }
    }
}
