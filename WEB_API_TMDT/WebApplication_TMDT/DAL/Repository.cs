using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DAL
{
    public class Repository : IRepository
    {
        private readonly WED_API_TMDTContext context;
        public Repository(WED_API_TMDTContext cntext)
        {
            this.context = cntext;
        }
        public void Add<T>(T entity) where T : class
        {
            this.context.Add(entity);
        }

        public void Delete<T>(string id) where T : class
        {
            var entry = this.context.Set<T>().Find(id);
            if (entry!=null)
                this.context.Remove(entry);
        }

        public List<T> getAll<T>() where T : class
        {
            return this.context.Set<T>().ToList();
        }

        public T getByID<T>(string id) where T : class
        {
            var entry = this.context.Set<T>().Find(id);
            return entry;
        }

        public void Update<T>(T entity) where T : class
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
