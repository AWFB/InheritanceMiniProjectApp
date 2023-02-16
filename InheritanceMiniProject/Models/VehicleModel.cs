using System;

namespace InheritanceMiniProject
{
    // buy or rent
    public class VehicleModel : InventoryItemModel, IPurchase, IRent
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("Vehicle purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("Vehicle rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("Vehicle rented");
        }
    }
}
