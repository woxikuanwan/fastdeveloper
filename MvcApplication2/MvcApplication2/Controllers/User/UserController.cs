using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
namespace MvcApplication2.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            //MvcApplication2.Models.User u=new User();
            //u.Userid=1;
            //u.Username="sadf";
            //ViewBag.aaa = "sdafasf";
            //ViewBag.name = "周江霄";
            //ViewData["name1"] = "周江霄";  
            return View("Address");
        }

    }
}
