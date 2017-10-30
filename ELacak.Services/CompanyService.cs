using System;
using ELacak.Services.Interfaces;
using System.Collections.Generic;
using ELacak.Services.DAO;
using ELacak.Model.Persistence;
using System.Linq;

namespace ELacak.Services
{
    public class CompanyService : BaseService, ICompanyService
    {
        public CompanyService(IDataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<CompanyDao> Get()
        {
            var companies = DataContext.Companies.ToList();
            return new List<CompanyDao>();
        }
    }
}
