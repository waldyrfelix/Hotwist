using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotwist.Web.Controllers;
using System.Web.Mvc;
using System.Web;
using Moq;
using System.Web.Routing;
using Hotwist.Web.ViewModels;

namespace Hotwist.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Quando_Subir_Logo_Gravar_Na_Pasta_Uploads()
        {
            // arrange
            var mockPostedFile = new Mock<HttpPostedFileBase>();
            mockPostedFile.Setup(postedFile => postedFile.SaveAs(@"C:\upload\logo.png"));
            mockPostedFile.SetupGet(postedFile => postedFile.FileName).Returns("logo.png");

            var mockServerUtil = new Mock<HttpServerUtilityBase>();
            mockServerUtil.Setup(server => server.MapPath("~/Content/uploads"))
                .Returns(@"C:\upload");

            var mockHttpContext = new Mock<HttpContextBase>();
            mockHttpContext.Setup(httpContext => httpContext.Server)
                .Returns(mockServerUtil.Object);

            var controller = new HomeController();
            controller.ControllerContext = new ControllerContext(mockHttpContext.Object, new RouteData(), controller);

            // act
            controller.Upload(mockPostedFile.Object);

            // assert
            mockPostedFile.Verify(x => x.SaveAs(@"C:\upload\logo.png"), Times.Once());
        }

        [TestMethod]
        public void Quando_Fizer_Upload_Da_Logo_Mostrar_Logo_Na_Tela()
        {
            // arrange
            var mockPostedFile = new Mock<HttpPostedFileBase>();
            mockPostedFile.Setup(postedFile => postedFile.SaveAs(@"C:\upload\logo.png"));
            mockPostedFile.SetupGet(postedFile => postedFile.FileName).Returns("logo.png");

            var mockServerUtil = new Mock<HttpServerUtilityBase>();
            mockServerUtil.Setup(server => server.MapPath("~/Content/uploads"))
                .Returns(@"C:\upload");

            var mockHttpContext = new Mock<HttpContextBase>();
            mockHttpContext.Setup(httpContext => httpContext.Server)
                .Returns(mockServerUtil.Object);

            var controller = new HomeController();
            controller.ControllerContext = new ControllerContext(mockHttpContext.Object, new RouteData(), controller);

            // act
            ActionResult resultado = controller.Upload(mockPostedFile.Object);

            // assert
            Assert.IsNotNull(resultado);
            Assert.IsInstanceOfType(resultado, typeof(ViewResult));

            var viewResult = resultado as ViewResult;
            Assert.AreEqual("Index", viewResult.ViewName);
            Assert.IsNotNull(viewResult.Model);
            Assert.IsInstanceOfType(viewResult.Model, typeof(LogoUploadViewModel));
        }

    }
}
