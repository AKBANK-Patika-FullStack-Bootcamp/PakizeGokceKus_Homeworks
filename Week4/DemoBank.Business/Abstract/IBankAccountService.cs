

using DemoBank.Entities.Concrete;
using Deviser.Bank.Core.Utilities.Result;
using System.Collections.Generic;

namespace DemoBank.Business.Abstract
{
   public interface IBankAccountService
    {
        IDataResult<BankAccount> GetById(int bankaccountcode);
        List<BankAccount> GetList();
        IResult Add(BankAccount bankAccount);
        IResult Update(BankAccount bankAccount);

       // List<BankAccount> Join(int bankaccountCode);
    }
}
