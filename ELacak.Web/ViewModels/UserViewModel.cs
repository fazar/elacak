using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELacak.Web.ViewModels
{
    public class UserViewModel
    {
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