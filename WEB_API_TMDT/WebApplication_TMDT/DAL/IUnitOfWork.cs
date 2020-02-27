using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        EMDBContext context { get; }
        void SaveChages();
    }
}
