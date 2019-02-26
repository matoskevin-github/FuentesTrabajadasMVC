using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;

namespace WCFAndJSONClient.Models
{
    public class ProductServiceClient
    {
        private string BASE_URL = "http://localhost:52606/ServiceProduct.svc/";

        public Product find()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(BASE_URL + "find");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Product>(content);
        }

        public List<Product> findAll()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(BASE_URL + "findAll");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Product>>(content);
        }
    }
}