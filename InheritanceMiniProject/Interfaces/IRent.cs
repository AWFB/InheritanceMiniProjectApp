namespace InheritanceMiniProject
{
    public interface IRent : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
