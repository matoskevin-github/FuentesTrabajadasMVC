using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFAndJSONServer
{
    public class ServiceProduct : IServiceProduct
    {

        [WebInvoke(Method = "GET", UriTemplate = "find", ResponseFormat = WebMessageFormat.Json)]
        public Product find()
        {
            return new Product { Id = "p01", Name = "Name 1", Price = 1000 };
        }

        [WebInvoke(Method = "GET", UriTemplate = "findAll", ResponseFormat = WebMessageFormat.Json)]
        public List<Product> findAll()
        {
            List<Product> result = new List<Product>();
            result.Add(new Product { Id = "p01", Name = "Name 1", Price = 1000 });
            result.Add(new Product { Id = "p02", Name = "Name 2", Price = 2000 });
            result.Add(new Product { Id = "p03", Name = "Name 3", Price = 3000 });
            return result;
        }
    }
}

