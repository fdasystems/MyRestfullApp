using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyRestfull.Data;
using myrestFull.Service.Service;

namespace MyResftfullApp.Controllers
{
    public class UsuariosController : ApiController
    {
        private IRepository _repository;


        public UsuariosController(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                return Ok(_repository.GetAllUsers());
            }
            catch
            {
                return InternalServerError();
            }
        }

    }
}