using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface IBill
    {
        IEnumerable<Bill> getAll();
        void Add(Bill bill);
        void Update(Bill bill);
        void Delete(string id);
        Bill Get(string id);
    }
}
