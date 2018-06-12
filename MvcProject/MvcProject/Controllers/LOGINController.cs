using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models;
using System.Diagnostics;
namespace MvcProject.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /LOGIN/
        public ActionResult Index()
        {
            return View();
        }
        public string Check(Login1 log2)
        {
            Login log=new Login();
            //string name=Request["name"];
            //string pass = Request["password"];
            log.Logins.Add(log2);
            return "I am CALLED.";
        }
	}
}