

using DemoBank.DataAccess.EntityFramework.Context;
using DemoBank.Entities.Concrete;
using Deviser.Bank.Core.DataAccess.EntityFramework;
using Deviser.Bank.DataAccess.Abstract;

namespace Deviser.Bank.DataAccess.Concrete.EntityFramework
{
     public class EfBankAccountDal:EfEntityRepositoryBase<BankAccount,BankContext>,IBankAccountDal
     {
         
     }
}
