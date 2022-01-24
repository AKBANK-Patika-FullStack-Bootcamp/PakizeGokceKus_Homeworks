using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_DataAccess.Abstract;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_DataAccess.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, BankContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new BankContext())
            {
                var result = from operationClaim in context.AOperationClaims
                             join userOperationClaim in context.AUserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                return result.ToList();
            }

        }
    }
}
