﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaWithASPNETMVC.Areas.Admin.Controllers
{
    public class ProductAdminController : Controller
    {
        // GET: Admin/ProductAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}