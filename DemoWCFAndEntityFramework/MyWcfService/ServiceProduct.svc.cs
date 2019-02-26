using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyWcfService.model;

namespace MyWcfService
{
    public class ServiceProduct : IServiceProduct
    {
        private EmpresaBDEntities entities = new EmpresaBDEntities();
        public Product find(int Id)
        {
            return entities.Product.Single( p => p.Id == Id);
        }

        public List<Product> findAll()
        {
            return entities.Product.ToList();
        }
    }
}
