namespace TradeLendaInventory.Models
{
    public class SalesReport
    {
        public Product Product { get; set; } = new Product();
        public int SoldQty {get; set;}
        public decimal SoldAmount { get; set;}
        public int InstockQty { get; set;}
    }
}
