using System;
using System.Collections.Generic;

namespace WebApplication_TMDT.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetail = new HashSet<BillDetail>();
            Cart = new HashSet<Cart>();
        }

        public string ProductId { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductImage { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
