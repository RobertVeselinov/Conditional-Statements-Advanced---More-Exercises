using System;

namespace P07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int quantityStudents = int.Parse(Console.ReadLine());
            int quantityNights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = String.Empty;

            if (season == "Winter")
            {
                if (group == "boys" || group == "girls")
                {
                    price += quantityNights * 9.60 * quantityStudents;
                }
                else if (group == "mixed")
                {
                    price += quantityNights * 10 * quantityStudents;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys" || group == "girls")
                {
                    price += quantityNights * 7.20 * quantityStudents;
                }
                else if (group == "mixed")
                {
                    price += quantityNights * 9.50 * quantityStudents;
                }
            }
            else if (season == "Summer")
            {
                if (group == "boys" || group == "girls")
                {
                    price += quantityNights * 15 * quantityStudents;
                }
                else if (group == "mixed")
                {
                    price += quantityNights * 20 * quantityStudents;
                }
            }

            if (quantityStudents >= 50)
            {
                price -= price * 0.5;
            }
            else if (quantityStudents >= 20 && quantityStudents < 50)
            {
                price -= price * 0.15;
            }
            else if (quantityStudents >= 10 && quantityStudents < 20)
            {
                price -= price * 0.05;
            }

            if (season == "Winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                }
                else if (group == "boys")
                {
                    sport = "Football";
                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {price:f2} lv.");

        }
    }
}
