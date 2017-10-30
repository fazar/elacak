using ELacak.Model.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELacak.Services
{
    public class BaseService
    {
        private readonly IDataContext _dataContext;

        public BaseService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        protected IDataContext DataContext
        {
            get { return _dataContext; }
        }
    }
}
