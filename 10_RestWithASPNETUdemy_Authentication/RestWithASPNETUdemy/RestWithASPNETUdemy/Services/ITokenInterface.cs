using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services
{
   public interface ITokenInterface
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string Token);
    }
}
