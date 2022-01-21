using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_DemoBank_DataAccess.Abstract;
using Week4_DemoBank_Entities.Concrete;

namespace Week4_DemoBank_DataAccess.EntityFramework
{
    public class EfBankAccountDal : EfEntityRepositoryBase<BankAccount, BankContext>, IBankAccountDal
    {

    }
}
