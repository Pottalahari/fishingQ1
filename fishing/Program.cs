using System;
using System.Reflection.Metadata;
namespace BuyingFish
{
    public class FishUtlity
    {
        public string? Species { get; set; }
        public double PriceFish { get; set; }
    }
    public class Fish : FishUtlity
    {
        public void AddFish(string species, double pricefish)
        {
            Species = species;
            PriceFish = pricefish;
        }
        public bool BuyFish()
        {
            if (Species == "Clownfish" || Species == "Goldfish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculatePrice(int numberOfFishes)
        {
            double AdditionalCharges = 0;
            if (Species == "Clownfish")
            {
                AdditionalCharges = 100;
            }
            else if (Species == "Goldfish")
            {
                AdditionalCharges = 150;
            }
            return numberOfFishes * PriceFish + AdditionalCharges;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a name of the Species:");
            string? species = Console.ReadLine();
            Console.WriteLine("enter the price of fish:");
            double PriceFish = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of fishes:");
            int numberOfFishes = int.Parse(Console.ReadLine());
            Fish fish = new Fish();
            fish.AddFish(species, PriceFish);
            if (!fish.BuyFish())
            {
                Console.WriteLine($"{species} is not found");
                return;
            }
            double result = fish.CalculatePrice(numberOfFishes);
            Console.WriteLine("Total cost " + result);

        }

    }
}