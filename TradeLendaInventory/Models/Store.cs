﻿using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Store
    {


        public string StoreId { get; set; } 


        [Required]
        public string StoreName { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

     
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}