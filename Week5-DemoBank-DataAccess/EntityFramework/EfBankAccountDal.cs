using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_DataAccess.Abstract;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_DataAccess.EntityFramework
{
    public class EfBankAccountDal : EfEntityRepositoryBase<BankAccount, BankContext>, IBankAccountDal
    {

    }
}
