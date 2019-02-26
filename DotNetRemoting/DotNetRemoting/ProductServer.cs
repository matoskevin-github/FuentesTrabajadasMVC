using MyProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRemoting
{
    public class ProductServer : MarshalByRefObject, IProduct
    {
        public Product find()
        {
            //throw new NotImplementedException();
            return new Product { Id = "P01", Name = "Product 1", Price = 100 };
        }

        public List<Product> findAll()
        {
            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product { Id = "P01", Name = "Product 1", Price = 100 });
            listProducts.Add(new Product { Id = "P02", Name = "Product 2", Price = 200 });
            listProducts.Add(new Product { Id = "P03", Name = "Product 3", Price = 300 });
            //throw new NotImplementedException();
            return listProducts;
        }
    }
}
