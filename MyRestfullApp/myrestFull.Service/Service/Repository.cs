using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyRestfull.Data;

namespace myrestFull.Service.Service
{
    public class Repository : IRepository
    {
        public List<User> GetAllUsers()
        {
            using (bdEntities context = new bdEntities())
            {
                return context.User.ToList();
            }
        }
    }
}