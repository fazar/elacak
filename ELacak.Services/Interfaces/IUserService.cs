using ELacak.Services.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Services.Interfaces
{
    public interface IUserService
    {
        UserDao Login(string username, string password);
    }
}
