using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestfull.Data;

namespace myrestFull.Service.Service
{
    public interface IRepository
    {
        List<User> GetAllUsers();
    }
}
