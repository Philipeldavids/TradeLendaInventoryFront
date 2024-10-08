﻿using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        public Supplier Supplier { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string ProductName { get; set; }

        public string Reference { get; set; }

        public string Status { get; set; }

        public decimal Paid { get; set; }

        public decimal Due { get; set; }

        public string CreatedBy { get; set; }

        public List<Product> Products { get; set; }

        public decimal Discount { get; set; }

        public decimal TaxPercentage { get; set; }

        public decimal TaxAmount
        {
            get
            {
                return (TotalCost - Discount) * (TaxPercentage / 100);
            }
        }

        public decimal TotalCost
        {
            get
            {
                return Products?.Sum(p => p.UnitCost) ?? 0;
            }
        }

        public decimal Shipping { get; set; }

    }
}
