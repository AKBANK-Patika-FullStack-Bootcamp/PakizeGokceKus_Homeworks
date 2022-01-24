using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Week5_DemoBank_Business.Extensions
{
    public static class ClaimExtensions
    {
        public static void AddBankAccountName(this ICollection<Claim> claims, string bankAccountName)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.UniqueName, bankAccountName));
        }

        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, name));
        }

        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
        }

        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
        }
    }
}
