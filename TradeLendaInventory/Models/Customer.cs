using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Customer
    {
        
       
        [Key]
        public string CustomerId { get; set; }
        public string FullName { get; set; }

        public int Code { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? ShippingAddress { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }
        public string? Description { get; set; }

        public PurchaseOrder? PurchaseOrders { get; set; }
    }

    public class PurchaseOrder
    {
        [Key]
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<OrderItem>? Items { get; set; }
        public bool Status { get; set; }
        public DateTime OrderPlacedAt { get; set; }
        public DateTime? OrderFulfilledAt { get; set; }
        public decimal TotalAmount { get; set; }


    }



    public class OrderItem
    {
        [Key]
        public string OrderItemId { get; set; }
        public string PurchaseOrderId { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        // Navigation property

    }
}
