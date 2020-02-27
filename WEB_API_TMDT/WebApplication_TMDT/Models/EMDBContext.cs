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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        
    }
}
