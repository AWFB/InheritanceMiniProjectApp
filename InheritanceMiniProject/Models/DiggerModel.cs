using System;

namespace InheritanceMiniProject
{
    // Rent / Return only
    public class DiggerModel : InventoryItemModel, IRent 
    {
        public void DigHole()
        {
            Console.WriteLine("Diggy Diggy Hole");
        }

        public void Rent()
        {
            QuantityInStock -= 1; // Yes, I know I would need a check here to make sure stock is > 1
            Console.WriteLine("Rented Successfully");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The digger has been returned");
        }
    }
}
