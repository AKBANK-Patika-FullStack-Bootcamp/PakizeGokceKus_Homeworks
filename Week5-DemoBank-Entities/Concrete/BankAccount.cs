using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_DemoBank_Entities.Concrete
{
    public class BankAccount
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BankAccountCode { get; set; }//değişecek burası iban

        [Required]

        public string BankAccountName { get; set; }

        [Required]
        public string BankAccountType { get; set; }

        [Required]
        public int BankAccountLimit { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public double Balance { get; set; }
    }
}
