using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_DataAccess.EntityFramework;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
