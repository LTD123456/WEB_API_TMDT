using System;
using System.Collections.Generic;

namespace WebApplication_TMDT.Models
{
    public partial class Cart
    {
        public string CartId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public decimal? Total { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
