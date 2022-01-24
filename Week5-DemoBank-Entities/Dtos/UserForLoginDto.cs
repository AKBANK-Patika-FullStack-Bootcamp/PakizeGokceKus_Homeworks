using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_DemoBank_Entities.Dtos
{
    public class UserForLoginDto 
    {
        public string BankAccountName { get; set; }

        public string Password { get; set; }
    }
}
