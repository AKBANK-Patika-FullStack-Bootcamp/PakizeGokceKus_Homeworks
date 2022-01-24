using System;
using System.Collections.Generic;
using System.Text;
using Week5_DemoBank_Business.Abstract;
using Week5_DemoBank_Business.Constants;
using Week5_DemoBank_Business.Utilities.Hashing;
using Week5_DemoBank_Business.Utilities.Result;
using Week5_DemoBank_Business.Utilities.Security.Jwt;
using Week5_DemoBank_Entities.Concrete;
using Week5_DemoBank_Entities.Dtos;
using Week5_DemoBank_Entities.Utilities.Result;

namespace Week5_DemoBank_Business.Concrete
{
    public class AuthManager : IAuthService
    {
        //public static string _token;
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passworSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passworSalt);
            var user = new User()
            {
                BankAccountName = userForRegisterDto.BankAccountName,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passworSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByBankAccountName(userForLoginDto.BankAccountName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash,
                userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfullLogin);
        }

        public IResult UserExists(string bankAccountName)
        {
            if (_userService.GetByBankAccountName(bankAccountName) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
