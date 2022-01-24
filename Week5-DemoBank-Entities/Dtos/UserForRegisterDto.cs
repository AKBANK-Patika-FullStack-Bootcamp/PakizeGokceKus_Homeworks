using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_DemoBank_Entities.Dtos
{
    public class UserForRegisterDto
    {
        public string BankAccountName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
