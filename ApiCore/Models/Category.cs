using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCore.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
