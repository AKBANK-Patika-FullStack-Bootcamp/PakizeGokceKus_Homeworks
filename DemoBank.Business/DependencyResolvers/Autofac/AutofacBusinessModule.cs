using Autofac;
using DemoBank.Business.Abstract;
using DemoBank.Business.Concrete;
using Deviser.Bank.DataAccess.Abstract;
using Deviser.Bank.DataAccess.Concrete.EntityFramework;

namespace Deviser.Bank.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Autofac kullanılmıştır
            //builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<BankAccountManager>().As<IBankAccountService>();
            builder.RegisterType<EfBankAccountDal>().As<IBankAccountDal>();
        }
    }
}
