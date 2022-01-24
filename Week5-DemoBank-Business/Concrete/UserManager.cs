using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_Business.Abstract;
using Week5_DemoBank_DataAccess.Abstract;
using Week5_DemoBank_Entities.Concrete;

namespace Week5_DemoBank_Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }



        public User GetByBankAccountName(string bankaccountName)
        {
            return _userDal.Get(u => u.BankAccountName == bankaccountName);
        }
    }
}
