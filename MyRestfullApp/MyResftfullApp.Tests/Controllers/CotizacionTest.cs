using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyResftfullApp.Controllers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net;

namespace MyResftfullApp.Tests.Controllers
{
    [TestClass]
    public class CotizacionTest
    {
        [TestMethod]
        public void TestGetPesos()
        {
            // Disponer
            CotizacionController controller = new CotizacionController();

            // Actuar
            IHttpActionResult actionResult = controller.Get("Pesos");

            // Declarar
            Assert.IsInstanceOfType(actionResult, typeof(UnauthorizedResult));
        }

        [TestMethod]
        public void TestGetReal()
        {
            // Disponer
            CotizacionController controller = new CotizacionController();

            // Actuar
            IHttpActionResult actionResult = controller.Get("Real");

            // Declarar
            Assert.IsInstanceOfType(actionResult, typeof(UnauthorizedResult));
        }

        [TestMethod]
        public void TestGetDolar()
        {
            // Disponer
            CotizacionController controller = new CotizacionController();

            // Actuar
            IHttpActionResult actionResult = controller.Get("Dolar");
            var contentResult = actionResult as OkNegotiatedContentResult<string>;

            // Declarar
            Assert.IsNotNull(actionResult);
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.IsInstanceOfType(contentResult, typeof(OkNegotiatedContentResult<string>));
        }
    }
}
