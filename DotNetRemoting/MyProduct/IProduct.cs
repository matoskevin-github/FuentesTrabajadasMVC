﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProduct
{
    public interface IProduct
    {
        Product find();
        List<Product> findAll();
    }
}
