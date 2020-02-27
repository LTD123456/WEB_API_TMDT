using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public EMDBContext context { get; }
        public UnitOfWork(EMDBContext context)
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
