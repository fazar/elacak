using ELacak.Model.Persistence;
using ELacak.Services;
using ELacak.Services.Interfaces;
using ELacak.Web.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELacak.Web
{
    public partial class _Default : BasePageWithIoC
    {
        public ICompanyService CompanyService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Test();
        }

        private void Test()
        {
            var companies = CompanyService.Get();
        }
    }
}