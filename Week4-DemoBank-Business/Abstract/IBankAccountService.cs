using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_DemoBank_Entities.Concrete;
using Week4_DemoBank_Entities.Utilities.Result;

namespace Week4_DemoBank_Business.Abstract
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
