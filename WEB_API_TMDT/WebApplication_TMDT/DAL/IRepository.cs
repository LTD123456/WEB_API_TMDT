using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_TMDT.DAL
{
    public interface IRepository
    {
        List<T> getAll<T>() where T : class;
        T getByID<T>(string id) where T : class;
        void Add<T>(T entity) where T : class;
        void Delete<T>(string id) where T : class;
        void Update<T>(T entity) where T : class;
    }
}
