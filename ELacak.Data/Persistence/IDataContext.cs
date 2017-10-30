using ELacak.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Model.Persistence
{
    public interface IDataContext
    {
        IDbSet<Company> Companies { get; set; }
        IDbSet<Department> Departments { get; set; }
        IDbSet<DocumentType> DocumentTypes { get; set; }
        IDbSet<Role> Roles{ get; set; }
        IDbSet<User> Users{ get; set; }

        Database Database { get; }
        int SaveChanges();
        DbEntityEntry Entry(object entity);
    }
}
