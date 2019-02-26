using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespositoryInASPNETMVCEF.Models
{
    public interface ICRUDRepository<T> where T : class
    {
        IEnumerable<T> findAll();
        T find(object Id);
        void create(T obj);
        void delete(object Id);
        void update(T obj);
        long count();

    }
}
