namespace TradeLendaInventory.Models.ViewModel
{
    public class SupplierViewModel
    {
        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public Supplier supplier { get; set; } = new Supplier();
    }
}
