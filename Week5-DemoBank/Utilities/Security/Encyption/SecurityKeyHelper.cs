using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Week5_DemoBank_Business.Utilities.Security.Encyption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
