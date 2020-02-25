using System;
using System.Collections.Generic;

namespace WebApplication_TMDT.Models
{
    public partial class BillDetail
    {
        public string BillDetailId { get; set; }
        public string BillId { get; set; }
        public string ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
