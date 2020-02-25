using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        WED_API_TMDTContext context { get; }
        void SaveChages();
    }
}
