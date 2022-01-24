
using Week5_DemoBank_DataAccess.EntityFramework;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_DataAccess.Abstract
{
    public interface IBankAccountDal : IEntityRepository<BankAccount>
    {

    }
}
