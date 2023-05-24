using System;

namespace P01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string vipOrNormal = Console.ReadLine();
            int quantityPeople = int.Parse(Console.ReadLine());

            double ticketsPrice = 0;
            double transportPrice = 0;

            switch (vipOrNormal)
            {
                case "VIP":
                    ticketsPrice = 499.99;
                    break;
                case "Normal":
                    ticketsPrice = 249.99;
                    break;
            }

            if (quantityPeople >= 1 && quantityPeople <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (quantityPeople >= 5 && quantityPeople <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (quantityPeople >= 10 && quantityPeople <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (quantityPeople >= 25 && quantityPeople <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else if (quantityPeople >= 50)
            {
                transportPrice = budget * 0.25;
            }
            ticketsPrice = ticketsPrice * quantityPeople;
            budget = budget - transportPrice;

            if (budget >= ticketsPrice)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budget - ticketsPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(ticketsPrice - budget):f2} leva.");
            }
        }
    }
}
