using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    //[Authorize]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Identity()
        {
            return Content("We are using Identity");
        }

        [AllowAnonymous]
        public ActionResult NonIdentiy()
        {
            return Content("We are not using Identity");
        }
    }
}