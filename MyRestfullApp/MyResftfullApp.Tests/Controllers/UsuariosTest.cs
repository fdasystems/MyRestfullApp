using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using myrestFull.Service.Service;
using MyRestfull.Data;
using System.Linq;
using System.Collections.Generic;
using MyResftfullApp.Controllers;
using System.Web.Http;

namespace MyResftfullApp.Tests.Controllers
{
    [TestClass]
    public class UsuariosTest
    {
        [TestMethod]
        public void TestGetAllUsers()
        {
            //Disponer
            List<User> users = fillUsers();
            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetAllUsers()).Returns(users);
            var usuarioController = new UsuariosController(mockRepository.Object);

            //Actuar
            var result = usuarioController.GetAllUsers();
            var Listresult = ((System.Web.Http.Results.OkNegotiatedContentResult<List<User>>)(result)).Content;


            //Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual(users.Count, Listresult.Count);
        }

        private List<User> fillUsers() 
        {
            List<User> listUsers = new List<User>();
            for(int i= 1; i<5; i++)
            {
                User user = new User();
                user.Id = i;
                user.nombre = "user" + i;
                user.apellido = "apellido" + i;
                user.email = user.nombre + "@email.com";
                user.password = "password"+i;

                listUsers.Add(user);
            }

            return listUsers;
        }

    }
}
