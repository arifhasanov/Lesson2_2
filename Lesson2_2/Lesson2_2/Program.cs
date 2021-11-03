using System;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelTypes = new[] {"AI92","AI95","AI98"};
            var fuelPrices = new[] {1.7m, 1.8m, 1.9m };
            int selectedFuelType = 0;
            decimal quantity = 0, total = 0;


            Console.WriteLine("Welcome to LUKOIL gas station! Please select the fuel you want to purchase:");
            for(int i = 0; i < fuelTypes.Length; i++)
            {
                Console.WriteLine($"{i+1}. -> {fuelTypes[i]}, price per lt: {fuelPrices[i]} €/lt");
            }

            selectedFuelType = int.Parse(Console.ReadLine()) - 1;
            if(selectedFuelType >= 0 && selectedFuelType < fuelTypes.Length)
            {
                Console.WriteLine("How many liters do you want to purchase?");
                quantity = decimal.Parse(Console.ReadLine());
                total = quantity * fuelPrices[selectedFuelType];
                PrintingReceipt(quantity, fuelPrices[selectedFuelType],total,fuelTypes[selectedFuelType]);

            }
            else
            {
                Console.WriteLine("You have selected wrong fuel type. Please select the correct number");
            }

        }

        static void PrintingReceipt(decimal quantity, decimal price, decimal total, string fuelType)
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*             WELCOME TO             *");
            Console.WriteLine("*               LUKOIL               *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("Thank you for your purchase!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Fuel type: {fuelType}");
            Console.WriteLine($"Price: {price} €/lt");
            Console.WriteLine($"Quantity: {quantity} lt");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Total: {total} €");
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();
        }
    }
}
