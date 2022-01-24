using System;

namespace Week5_DemoBank_Business.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
