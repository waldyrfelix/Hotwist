using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Hotwist.Web.ViewModels;

namespace Hotwist.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new LogoUploadViewModel());
        }

        public ActionResult Upload(HttpPostedFileBase logo)
        {
            string caminho = Server.MapPath("~/Content/uploads");
            logo.SaveAs(Path.Combine(caminho, logo.FileName));

            var viewModel = new LogoUploadViewModel();
            viewModel.UrlDaImagem = "/Content/uploads/" + logo.FileName;

            return View("Index", viewModel);
        }
    }
}
