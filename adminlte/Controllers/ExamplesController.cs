using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBModels;
using Models;

namespace adminlte.Controllers
{
    public class ExamplesController : Controller
    {
        EcommerceEntities db;
        
        
        // GET: Examples
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page404()
        {
            return View();
        }

        public ActionResult Page500()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }

        public ActionResult InvoicePrint()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult Lockscreen()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public String LoginAuth(LoginModel model)
        {
            String user = model.username;
            var data = db.App_users.Where(x => x.Username == user).ToList();
            if (data.Count > 0)
            {
                return "Record exists";
            }
            else
            {
                return "Record does not exists";
            }
        }

        public ActionResult Pace()
        {
            return View();
        }

        public ActionResult PageProfile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}