using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RespositoryInASPNETMVCEF.Models
{
    public class CRUDRepository<T> : ICRUDRepository<T>where T : class
    {
        private EmpresaBDEntities entities;
        private DbSet<T> table;

        public CRUDRepository()
        {
            entities = new EmpresaBDEntities();
            table = entities.Set<T>();
        }

        public IEnumerable<T> findAll()
        {
            return table.ToList();
        }

        public T find(object Id)
        {
            return table.Find(Id);
        }

        public void create(T obj)
        {
            table.Add(obj);
            entities.SaveChanges();
        }

        public void delete(object Id)
        {
            T t = table.Find(Id);
            table.Remove(t);
            entities.SaveChanges();
        }

        public void update(T obj)
        {
            table.Attach(obj);
            entities.Entry(obj).State = EntityState.Modified;
            entities.SaveChanges();                
        }

        public long count()
        {
            return table.Count();  
        }




        
    }
}
