
using Autofac;
using Week4_DemoBank_Business.Abstract;
using Week4_DemoBank_Business.Concrete;
using Week4_DemoBank_DataAccess.Abstract;
using Week4_DemoBank_DataAccess.EntityFramework;

namespace Week4_DemoBank_Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
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
