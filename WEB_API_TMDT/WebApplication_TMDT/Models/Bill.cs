using System;
using System.Collections.Generic;

namespace WebApplication_TMDT.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
        }

        public string BillId { get; set; }
        public string UserId { get; set; }
        public decimal? Total { get; set; }
        public string Payment { get; set; }
        public string Address { get; set; }
        public DateTime? Date { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
    }
}
