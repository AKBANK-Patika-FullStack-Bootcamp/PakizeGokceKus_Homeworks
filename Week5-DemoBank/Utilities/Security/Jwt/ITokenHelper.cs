using System.Collections.Generic;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_Business.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
