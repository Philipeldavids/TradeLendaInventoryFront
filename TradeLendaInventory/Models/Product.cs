using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace TradeLendaInventory.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Store { get; set; }
        public string Warehouse { get; set; }

        public Category? Category { get; set; } = new Category();

        public string CategoryId { get; set; }

        public Brand? Brand { get; set; } = new Brand();
        public string BrandId { get; set; }

        public string Barcode { get; set; }
        public decimal Price { get; set; }
        public bool IsExpired { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

        public string CreatedBy { get; set; }


        public string SKU { get; set; }

        public string ProductImageUrl { get; set; }

        public DateTime ManufacturedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal UnitCost { get; set; }
        public DateTime CreatedAt { get; set; }

    }

    public class Brand
    {
        [Key]
        public string BrandId { get; set; }
        public string BrandName { get; set; }
        public string? Logo { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Status { get; set; }
    }

    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; } 
        public string CategorySLug { get; set; } 

        public DateTime CreatedOn { get; set; }

        public bool Status { get; set; }



    }
}
