using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELacak.Model.Entities;

namespace ELacak.Model.Persistence
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext() :
            base("DefaultConnection")
        {

        }

        public IDbSet<Company> Companies { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<DocumentType> DocumentTypes { get; set; }
        public IDbSet<Role> Roles { get; set; }
    }
}
