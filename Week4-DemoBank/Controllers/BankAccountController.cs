using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week4_DemoBank_Business.Abstract;
using Week4_DemoBank_Entities.Concrete;

namespace Week4_DemoBank.Controllers
{
    [Route("api/[controller]")]
    public class BankAccountController : Controller
    {
        //Bağımlılığı azaltmak amacıyla depency injection kullanılarak IBankaccountService içindeki metodlara erişim sağlanmıştır.
        private IBankAccountService _bankAccountService;
        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        //Tüm banka hesaplarını getirir
        [HttpGet]
        public List<BankAccount> BankAccountList()
        {
            return _bankAccountService.GetList();
        }

        //Verilen bankaccountcode değişkenine göre listeleme işlemi yapar
        [HttpGet("getlistbybankaccount")]
        public IActionResult GetByBankAccountCode(int bankaccountcode)
        {
            try
            {
                var result = _bankAccountService.GetById(bankaccountcode);
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Banka hesabı ekleme işlemini gerçekleştirir
        [HttpPost]
        public IActionResult BankAccountAdd([FromBody] BankAccount bankAccount)
        {
            try
            {
                var _bankAccount = new BankAccount()
                {
                    BankAccountCode = 0,
                    BankAccountName = bankAccount.BankAccountName,
                    BankAccountType = bankAccount.BankAccountType,
                    BankAccountLimit = bankAccount.BankAccountLimit,
                    DateTime = DateTime.Now,
                    Balance = bankAccount.Balance
                };

                _bankAccountService.Add(_bankAccount);
                return Ok(_bankAccount);
            }
            catch (Exception ex)
            {
                return BadRequest($"Bir hata oluştu {ex.Message.ToString()}");
            }
        }

        //Banka hesabı güncelleme işlemini gerçekleştirir
        [HttpPut]
        public BankAccount BankAccountUpdate([FromBody] BankAccount bankAccount, string name) //hesap adı değiştir
        {

            try
            {
                _bankAccountService.Update(new BankAccount
                {
                    BankAccountCode = bankAccount.BankAccountCode,
                    BankAccountName = bankAccount.BankAccountName,
                    BankAccountType = bankAccount.BankAccountType,
                    BankAccountLimit = bankAccount.BankAccountLimit,
                    DateTime = bankAccount.DateTime,
                    Balance = bankAccount.Balance
                });
                return bankAccount;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
