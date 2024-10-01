using System;
using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Stock
    {
        [Key]
        public string? StockId { get; set; } 
        public string? WarehouseID { get; set; }      

        public DateTime? DateAdded { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public string? Person { get; set; }

        public string? Quantity { get; set; }
        public string?  Shop { get; set; }

    }

    public class StockAdjustment
    {
        public string StockAdjustmentId { get; set; } = Guid.NewGuid().ToString();
        public string StockId { get; set; }
        public int QuantityAdjusted { get; set; }
        public string Reason { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public string AdjustedBy { get; set; }
    }

    public class StockTransfer
    {
        public string StockTransferId { get; set; } = Guid.NewGuid().ToString();
        public int QuantityTransferred { get; set; }
        public DateTime TransferDate { get; set; }
        public Warehouse FromWarehouse { get; set; }
        public Warehouse ToWarehouse { get; set; }
    }

}
