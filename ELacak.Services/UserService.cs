using ELacak.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELacak.Services.DAO;
using System.Data.Entity;
using SimpleCrypto;
using ELacak.Model.Persistence;

namespace ELacak.Services
{
    public class UserService : BaseService, IUserService
    {
        private PBKDF2 crypto = new PBKDF2();

        public UserService(IDataContext dataContext) : base(dataContext)
        {
        }

        public UserDao Login(string email, string password)
        {
            var user = DataContext.Users.Include(x => x.Department).Include(x => x.Roles).FirstOrDefault(x => x.Email == email);
            if (user != null && user.Password == crypto.Compute(password, user.PasswordSalt))
            {
                var userDao = new UserDao
                {
                    Id = user.Id,
                    Username = user.Username,
                    DefaultUrl = user.DefaultUrl,
                    DepartmentId = user.Department.Id,
                    DepartmentName = user.Department.Name,
                    IsActive = user.IsActive,
                    Email = user.Email,
                    IsSuperAdmin = user.IsSuperAdmin
                };

                foreach (var role in user.Roles)
                {
                    userDao.Roles.Add(new UserDao.Role { Name = role.Name });
                }

                return userDao;
            }
            return null;
        }
    }
}
