using System;

namespace P03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityChrysanthemums = int.Parse(Console.ReadLine());
            int quantityRoses = int.Parse(Console.ReadLine());
            int quantityTulipls = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            int quantityAll = quantityChrysanthemums + quantityRoses + quantityTulipls;
            double priceChrisanthemums = 0;
            double priceRoses = 0;
            double priceTulipls = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrisanthemums += quantityChrysanthemums * 2.00;
                priceRoses += quantityRoses * 4.10;
                priceTulipls += quantityTulipls * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrisanthemums += quantityChrysanthemums * 3.75;
                priceRoses += quantityRoses * 4.50;
                priceTulipls += quantityTulipls * 4.15;
            }
            double sumAll = priceChrisanthemums + priceRoses + priceTulipls;

            if (day == "Y")
            {
                sumAll += sumAll * 0.15;
            }

            if (quantityTulipls > 7 && season == "Spring")
            {
                sumAll -= sumAll * 0.05;
            }
            if (quantityRoses >= 10 && season == "Winter")
            {
                sumAll -= sumAll * 0.1;
            }
            if (quantityAll > 20)
            {
                sumAll -= sumAll * 0.2;
            }
            sumAll += 2;
            Console.WriteLine($"{sumAll:f2}");

        }
    }
}
