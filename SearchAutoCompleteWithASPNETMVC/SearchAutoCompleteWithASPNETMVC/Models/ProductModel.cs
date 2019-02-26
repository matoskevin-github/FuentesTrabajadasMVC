using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchAutoCompleteWithASPNETMVC.Models
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product { Id = "p01", Name = "Nokia 1", Price = 1000 });
            listProducts.Add(new Product { Id = "p02", Name = "Nokia 2", Price = 2000 });
            listProducts.Add(new Product { Id = "p03", Name = "Samsung 1", Price = 3000 });
            listProducts.Add(new Product { Id = "p04", Name = "Samsung 2", Price = 4000 });
            listProducts.Add(new Product { Id = "p05", Name = "Samsung 3", Price = 5000 });
            listProducts.Add(new Product { Id = "p06", Name = "Apple 1", Price = 6000 });
            listProducts.Add(new Product { Id = "p07", Name = "Apple 2", Price = 7000 });
            return listProducts;
        }

        public List<string> Search(string name)
        {
            return this.findAll().Where(p => p.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)).Select(p => p.Name).ToList();
        }
    }
}