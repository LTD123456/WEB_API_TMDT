using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication_TMDT.DAL
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : class;
        //IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add<T>(T entity) where T : class;
        
        void Delete<T>(string ID) where T : class;

        void Update<T>(T entity) where T : class;

        T Get<T>(string ID) where T : class;

       void UpdateRange<T>(List<T> entity) where T : class;
    }
}
