using Microsoft.IdentityModel.Tokens;

namespace Week5_DemoBank_Business.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredential(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
