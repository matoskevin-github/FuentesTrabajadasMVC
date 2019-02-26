using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchAutoCompleteWithASPNETMVCEF.Models
{
    public class ProductModel
    {
        private EmpresaBDEntities empresa = new EmpresaBDEntities();
        public List<string> Search(string name)
        {        
            return empresa.Product.Where(p => p.Name.StartsWith(name)).Select(p => p.Name).ToList();
        }
    }
}