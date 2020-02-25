using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public WED_API_TMDTContext context { get; }
        public UnitOfWork( WED_API_TMDTContext cntext)
        {
            this.context = context;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public void SaveChages()
        {
            this.context.SaveChanges();
        }
    }
}
