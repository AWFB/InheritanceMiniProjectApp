using System;
using System.Collections.Generic;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRent> rentables = new List<IRent>();
            List<IPurchase> purchasables = new List<IPurchase>();

            var vehicle = new VehicleModel { DealerFee = 30, ProductName = "Audi A4" };
            var book = new BookModel { ProductName = "Red Rising", NumberOfPages = 400 };
            var digger = new DiggerModel { ProductName = "JCB", QuantityInStock = 5 };

            rentables.Add(vehicle);
            rentables.Add(digger);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            bool IsValidOption = true;

            do
            {
                Console.WriteLine("Rent or Buy? (rent / buy)");
                string rentOrBuyDecision = Console.ReadLine();

                if (rentOrBuyDecision.ToLower() == "rent")
                {
                    foreach (var item in rentables)
                    {
                        Console.WriteLine($"Item: { item.ProductName}");
                        Console.Write("Do you want to rent this item (y/n)");
                        string wantToRent = Console.ReadLine();

                        if (wantToRent.ToLower() == "y")
                        {
                            item.Rent();
                        }

                        Console.Write("Do you want to return this item (y/n)");
                        string wantToReturn = Console.ReadLine();

                        if (wantToReturn.ToLower() == "y")
                        {
                            item.ReturnRental();
                        }

                    }
                }
                else if (rentOrBuyDecision.ToLower() == "buy")
                {
                    foreach (var item in purchasables)
                    {
                        Console.WriteLine($"Item: {item.ProductName}");
                        Console.Write("Do you want to purchase this item (y/n)");
                        string wantToBuy = Console.ReadLine();

                        if (wantToBuy.ToLower() == "y")
                        {
                            item.Purchase();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid option");
                    IsValidOption = false;
                } 

            } while (IsValidOption == false);

            Console.WriteLine("Thank you for visiting");

            Console.ReadLine();
        }
    }
}
