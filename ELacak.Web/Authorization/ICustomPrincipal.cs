using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Web.Authorization
{
    public interface ICustomPrincipal : IPrincipal
    {
        int Id { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        bool IsActive { get; set; }
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
        bool IsSuperAdmin { get; set; }
    }
}
