using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Services.DAO
{
    public class UserDao
    {
        public UserDao()
        {
            Roles = new List<Role>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public string DefaultUrl { get; set; }
        public bool IsSuperAdmin { get; set; }
        public IList<Role> Roles { get; set; }

        public class Role
        {
            public string Name { get; set; }
        }
    }
}
