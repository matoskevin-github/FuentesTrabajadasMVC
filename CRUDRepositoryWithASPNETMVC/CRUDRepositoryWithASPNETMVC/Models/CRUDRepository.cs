using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDRepositoryWithASPNETMVC.Models
{
    public class CRUDRepository<T> : ICRUDRepository<T> where T : class
    {
        private EmpresaBDEntities db;
        private DbSet<T> table;

        public CRUDRepository()
        {
            db = new EmpresaBDEntities();
            table = db.Set<T>();
        }

        public void create(T obj)
        {
            table.Add(obj);
            db.SaveChanges();
        }

        public void delete(object id)
        {
            T t = table.Find(id);
            table.Remove(t);
            db.SaveChanges();
        }

        public T find(object id)
        {
            return table.Find(id);
        }

        public IEnumerable<T> findAll()
        {
            return table.ToList();

        }

        public void update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public long count()
        {
            return table.Count();
        }
    }
}