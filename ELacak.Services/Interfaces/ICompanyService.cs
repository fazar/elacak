using ELacak.Services.DAO;
using System.Collections.Generic;

namespace ELacak.Services.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDao> Get();
    }
}
