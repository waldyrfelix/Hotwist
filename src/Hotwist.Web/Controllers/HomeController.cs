using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Hotwist.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase logo)
        {
            string caminho = Server.MapPath("~/Content/uploads");
            logo.SaveAs(Path.Combine(caminho, logo.FileName));

            return new EmptyResult();
        }
    }
}
