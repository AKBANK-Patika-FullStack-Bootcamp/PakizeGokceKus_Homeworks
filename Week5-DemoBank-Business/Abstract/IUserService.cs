using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByBankAccountName(string bankaccountName);
    }
}
