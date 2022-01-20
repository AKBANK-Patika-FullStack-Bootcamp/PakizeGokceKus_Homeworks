using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BankAccount
    {
        public int id { get; set; }
        public string InternationalBankAccountNumber { get; set; }
        public string BankAccountType { get; set; }
        public long BankAccountLimit { get; set; }
        public DateTime DateTime { get; set; }
        public double Balance { get; set; }
    }
}
