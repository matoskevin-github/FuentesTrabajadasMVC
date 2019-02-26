using LoginWithASPNETMVC.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginWithASPNETMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Index()
        {
            AccountViewModel avm = new AccountViewModel();            
            return View("Index",avm);
        }

        [HttpPost]
        public ViewResult Login(AccountViewModel avm)
        {
            if (avm.Account.Username.Equals("abc") && avm.Account.Password.Equals("123"))
            {
                Session["username"] = avm.Account.Username;
                return View("Welcome");
            }else
            {
                ViewBag.Error = "Account's Invalid";
                return View("Index");
            }
        }
    }
}