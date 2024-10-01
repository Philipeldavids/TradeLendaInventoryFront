namespace TradeLendaInventory.Models.ViewModel
{
    public class PurchaseVIewModel
    {
        public List<Purchase> Purchases { get; set; } = new List<Purchase>();

        public Purchase purchase { get; set; } = new Purchase();
    }
}
