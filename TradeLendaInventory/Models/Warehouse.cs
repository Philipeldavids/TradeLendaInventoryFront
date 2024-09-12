namespace TradeLendaInventory.Models
{
    public class Warehouse
    {
        public string WarehouseId { get; set; } 
        public string WarehouseName { get; set; }

        public string ContactPhone { get; set; }       

        public Supplier supplier { get; set; } = new Supplier();

        public Stock Stock { get; set; } = new Stock();

        public int Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Status { get; set; }

    }
}
