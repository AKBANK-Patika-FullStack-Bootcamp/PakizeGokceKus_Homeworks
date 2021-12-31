using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        //Banka hesap türünü belirten enum tanımlandı
        enum BankAccountType { TlHesabı, EuroHesabı, DolarHesabı, AltınHesabı }
        //Crud işlemlerini test etmek için static liste tanımlandı
        private static List<BankAccount> BankAccountList = new List<BankAccount>()
        {
            new BankAccount{id=1,InternationalBankAccountNumber="1234343434944",BankAccountType=BankAccountType.TlHesabı.ToString(),BankAccountLimit=3000,Balance=103.50,DateTime=new DateTime(2020,02,05)},
            new BankAccount{id=2,InternationalBankAccountNumber="2324324234254",BankAccountType=BankAccountType.EuroHesabı.ToString(),BankAccountLimit=50000,Balance=40000,DateTime=new DateTime(2018,11,12)},
            new BankAccount{id=3,InternationalBankAccountNumber="2324452566654",BankAccountType=BankAccountType.DolarHesabı.ToString(),BankAccountLimit=150000,Balance=533335,DateTime=new DateTime(2021,02,15)},
            new BankAccount{id=4,InternationalBankAccountNumber="2453453454354",BankAccountType=BankAccountType.AltınHesabı.ToString(),BankAccountLimit=1000,Balance=5,DateTime=new DateTime(2015,12,30)},
            new BankAccount{id=5,InternationalBankAccountNumber="1234343434655",BankAccountType=BankAccountType.TlHesabı.ToString(),BankAccountLimit=45000,Balance=43535,DateTime=new DateTime(2020,12,15)},
        };

        //Kişiye ait tüm hesapları listeler
        [HttpGet]
        public List<BankAccount> GetBankAccounts()
        {
            var bankAccountList = BankAccountList.OrderBy(x => x.id).ToList();
            return bankAccountList;
        }

        //İd parametresine ait olan hesabı getirir
        [HttpGet("{id}")]
        public BankAccount GetById(int id)
        {
            var bankAccount = BankAccountList.Where(x => x.id == id).SingleOrDefault();
            return bankAccount;
        }

        //Yeni hesap ekleme işlemini yapar
        [HttpPost]
        public IActionResult AddBankAccount([FromBody] BankAccount newBankAccount)
        {
            var bankAccount = BankAccountList.SingleOrDefault(x => x.InternationalBankAccountNumber == newBankAccount.InternationalBankAccountNumber);
            if (bankAccount is not null)
                return BadRequest();
            BankAccountList.Add(newBankAccount);
            return Ok();
        }

        //Hesabın limit ve bakiye bilgisinde güncelleme yapar
        [HttpPut("{id}")]
        public IActionResult UpdateBankAccount(int id, [FromBody] BankAccount updatedBankAccount)
        {
            var bankAccount = BankAccountList.SingleOrDefault(x => x.id == id);
            if (bankAccount is null)
                return BadRequest();
            bankAccount.BankAccountLimit = updatedBankAccount.BankAccountLimit != default ? updatedBankAccount.BankAccountLimit : bankAccount.BankAccountLimit;
            bankAccount.Balance = updatedBankAccount.Balance != default ? updatedBankAccount.Balance : bankAccount.Balance;
            return Ok();
        }

        //Hesap silme işlemini gerçekleştirir
        [HttpDelete("{id}")]
        public IActionResult DeleteBankAccount(int id)
        {
            var bankAccount = BankAccountList.SingleOrDefault(x => x.id == id);
            if (bankAccount is null)
                return BadRequest();
            BankAccountList.Remove(bankAccount);
            return Ok();
        }
    }
}
