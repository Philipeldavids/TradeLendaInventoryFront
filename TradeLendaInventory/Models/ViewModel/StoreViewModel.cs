namespace TradeLendaInventory.Models.ViewModel
{
    public class StoreViewModel
    {
        public List<Store> Stores { get; set; } = new List<Store>();
        public StoreModel store { get; set; } = new StoreModel();
    }
}
