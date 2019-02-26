using ConsumeJSONInAngularJSWithASPNETWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ConsumeJSONInAngularJSWithASPNETWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            ProductModel pm = new ProductModel();
            return pm.findAll().AsEnumerable();
        }

        public Product Get(string id)
        {
            ProductModel pm = new ProductModel();
            return pm.find(id);
        }
    }
}
