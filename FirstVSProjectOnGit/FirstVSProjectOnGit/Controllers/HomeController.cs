using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstVSProjectOnGit.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Just added a comment to check how we commit things.
            return View();
        }
    }
}
