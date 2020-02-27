using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication_TMDT.Models
{
    public partial class EMDBContext : DbContext
    {
        public EMDBContext()
        {
        }

        public EMDBContext(DbContextOptions<EMDBContext> options)
            : base(options)
        {
            
        }

        
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        
    }
}
