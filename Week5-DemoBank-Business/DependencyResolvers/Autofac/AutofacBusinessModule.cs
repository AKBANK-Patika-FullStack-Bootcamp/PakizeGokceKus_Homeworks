

using Autofac;

using Week5_DemoBank_Business.Abstract;
using Week5_DemoBank_Business.Concrete;
using Week5_DemoBank_Business.Utilities.Security.Jwt;
using Week5_DemoBank_DataAccess.Abstract;
using Week5_DemoBank_DataAccess.EntityFramework;

namespace Week5_DemoBank_Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            //Autofac kullanılmıştır
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<BankAccountManager>().As<IBankAccountService>();
            builder.RegisterType<EfBankAccountDal>().As<IBankAccountDal>();
        }
    }
}
