using ELacak.Model.Persistence;
using ELacak.Services;
using ELacak.Services.Interfaces;
using StructureMap;

namespace ELacak.Web.IoC
{
    public class ScanningRegistry : Registry
    {
        public ScanningRegistry()
        {
            For<ICompanyService>().Use<CompanyService>();
            For<IUserService>().Use<UserService>();
            For<IDataContext>().Use<DataContext>();
            //// Usually from web.config, but hardcoded here for simplicity
            //var databaseConnectionString = "testconnectionstring";

            //For<IEmailService>().Use<EmailService>().Ctor<string>("connectionString").Is(databaseConnectionString);


            Policies.SetAllProperties(y => y.WithAnyTypeFromNamespaceContainingType<CompanyService>());
        }
    }
}