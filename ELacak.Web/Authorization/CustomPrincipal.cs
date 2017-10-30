using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ELacak.Web.Authorization
{
    public class CustomPrincipal : ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }
        public CustomPrincipal(string email)
        {
            this.Identity = new GenericIdentity(email);
        }

        public bool IsInRole(string role)
        {
            if (Roles.Count() > 0)
            {
                return Roles.Contains(role) ? true : false;
            }
            return false;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string[] Roles { get; set; }
        public string DefaultUrl { get; set; }
    }
}