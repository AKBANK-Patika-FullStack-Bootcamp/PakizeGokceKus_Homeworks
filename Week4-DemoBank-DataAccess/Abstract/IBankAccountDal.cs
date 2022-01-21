using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_DemoBank_DataAccess.EntityFramework;
using Week4_DemoBank_Entities.Concrete;

namespace Week4_DemoBank_DataAccess.Abstract
{
    public interface IBankAccountDal : IEntityRepository<BankAccount>
    {

    }
}
