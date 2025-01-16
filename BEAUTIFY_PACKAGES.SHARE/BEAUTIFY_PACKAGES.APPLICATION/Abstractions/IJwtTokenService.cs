using System.Security.Claims;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.APPLICATION.Abstractions;

public interface IJwtTokenService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);
    string GenerateRefreshToken();
    (ClaimsPrincipal, bool) GetPrincipalFromExpiredToken(string token);
}