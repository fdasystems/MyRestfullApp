using myrestFull.Service.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MyResftfullApp.Controllers
{
    public class CotizacionController : ApiController
    {
        private IHttpActionResult GetCotizacion(string monedaACotizar)
        {
            try
            {
                IMoneda moneda = null;
                IHttpActionResult resultGet = null;

                switch (monedaACotizar)
                {
                    case "Pesos": moneda = new Peso();
                        break;
                    case "Real": moneda = new Real();
                        break;
                    case "Dolar": moneda = new Dolar();
                        break;
                    default: resultGet = NotFound();
                        break;

                }

                if (resultGet != null)
                    return resultGet;


                var result = moneda.cotizacion();

                return Ok(result);
            }
            catch (NotImplementedException)
            {
                return Unauthorized();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        // GET MyResftfullApp/Cotizacion/Moneda
        public IHttpActionResult Get(string Id)
        {
            IHttpActionResult result = null;

            result = GetCotizacion(Id);

            return result;
        }


    }
}
