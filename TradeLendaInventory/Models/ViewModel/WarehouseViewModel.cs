namespace TradeLendaInventory.Models.ViewModel
{
    public class WarehouseViewModel
    {
        public List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();

        public Warehouse warehouse { get; set; }  = new Warehouse();
    }
}
