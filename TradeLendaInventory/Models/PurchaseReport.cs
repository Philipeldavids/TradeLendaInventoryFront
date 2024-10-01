namespace TradeLendaInventory.Models
{
    public class PurchaseReport
    {
        public Product Product { get; set; } = new Product();
        public decimal PurchaseAmount { get; set; }
        public int PurchaseQuatity { get; set; }
        public int InstockQty { get; set; }
    }
}
