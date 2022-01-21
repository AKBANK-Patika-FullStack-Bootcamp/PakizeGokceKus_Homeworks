using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_DemoBank_Business.Abstract;
using Week4_DemoBank_DataAccess.Abstract;
using Week4_DemoBank_Entities.Concrete;
using Week4_DemoBank_Entities.Utilities.Result;

namespace Week4_DemoBank_Business.Concrete
{
    //public class BankAccountManager : IBankAccountService
    //{
    //    private IBankAccountDal _bankAccountDal;

    //    public BankAccountManager(IBankAccountDal bankAccountDal)
    //    {
    //        _bankAccountDal = bankAccountDal;
    //    }

    //    //public IDataResult<BankAccount> GetById(int bankaccountCode)
    //    //{
    //    //    return new SuccessDataResult<BankAccount>(_bankAccountDal.Get(b => b.BankAccountCode == bankaccountCode));//Transaction yaparken tekrar incele
    //    //}

    //    //public List<BankAccount> GetList()
    //    //{
    //    //    return new List<BankAccount>(_bankAccountDal.GetList().ToList());
    //    //}

    //    //public IResult Add(BankAccount bankAccount)
    //    //{
    //    //    _bankAccountDal.Add(bankAccount);
    //    //    return new SuccessResult(Messages.BankAccountAdded);
    //    //}

    //    //public IResult Update(BankAccount bankAccount)
    //    //{
    //    //    _bankAccountDal.Update(bankAccount);
    //    //    return new SuccessResult(Messages.BankAccountUpdated);
    //    //}

    //    //deneme
    //    //public virtual List<BankAccount> Join(int bankaccountCode)
    //    //{
    //    //    using var joinBankContext = new BankContext();
    //    //    var bank = joinBankContext.HBankAccounts.Include(a => a.BankTransactions).Where(a => a.BankAccountCode == bankaccountCode).ToList();
    //    //    return bank;
    //    //    return new BankAccount();
    //    //}
    //}
}
