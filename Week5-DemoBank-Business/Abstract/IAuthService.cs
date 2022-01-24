using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DemoBank_Business.Utilities.Result;
using Week5_DemoBank_Business.Utilities.Security.Jwt;
using Week5_DemoBank_Entities.Concrete;
using Week5_DemoBank_Entities.Dtos;

namespace Week5_DemoBank_Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string bankAccountName);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
