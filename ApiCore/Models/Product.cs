using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCore.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int FkCategoryId { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
