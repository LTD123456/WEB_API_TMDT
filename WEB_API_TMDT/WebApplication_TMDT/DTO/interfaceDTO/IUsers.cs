using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface IUsers
    {
        IEnumerable<Users> getAll();
        void Add(Users user);
        void Update(Users user);
        void Delete(string id);
        Users Get(string id);
    }
}
