using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;


namespace WebApplication_TMDT.DAL
{
    public class Repository:IRepository
    {
        private readonly EMDBContext Context;

        public Repository()
        {
        }

        public Repository(EMDBContext cntext)
        {
            this.Context = cntext;
        }
        public IEnumerable<T>GetAll<T>() where T : class
        {
            return this.Context.Query<T>().ToList();
        }

        public T Get<T>(string id) where T : class
        {
            return this.Context.Set<T>().Find(id);
        }
        public void Add<T>(T entity) where T : class
        {
            this.Context.Set<T>().Add(entity);
        }
        public void Delete<T>(string id) where T : class
        {
            T existing = this.Context.Set<T>().Find(id);
            if (existing != null) this.Context.Set<T>().Remove(existing);
        }

        //public IEnumerable<T> Get()
        //{
        //    return this.Context.Set<T>().AsEnumerable<T>();
        //}

        //public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        //{
        //    return this.Context.Set<T>().Where(predicate).AsEnumerable<T>();
        //}

        public void Update<T>(T entity) where T : class
        {
            this.Context.Update<T>(entity);
        }
        public void UpdateRange<T>(List<T> entitys) where T : class
        {
            this.Context.UpdateRange(entitys);
        }
    }
}
