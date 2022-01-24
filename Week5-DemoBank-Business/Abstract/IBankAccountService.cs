using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_Business.Utilities.Result;
using Week5_DemoBank_Entities.Concrete;
using Week5_DemoBank_Entities.Utilities.Result;

namespace Week5_DemoBank_Business.Abstract
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
