namespace Week5_DemoBank_Business.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; }//token kullanıcı kitlesi
        public string Issuer { get; set; }//imzalayan
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }

    }
}
