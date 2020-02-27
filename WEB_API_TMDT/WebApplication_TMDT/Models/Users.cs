using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_TMDT.Models
{
    public partial class Users
    {
        public Users()
        {
            //Bill = new HashSet<Bill>();
        }
        [Key]
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserRole { get; set; }

        //public virtual ICollection<Bill> Bill { get; set; }
    }
}
