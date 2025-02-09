using System.Security.Claims;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Repositories;
using Microsoft.AspNetCore.Http;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.API.DependencyInjection.Extensions;
public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    private readonly ClaimsPrincipal? _claimsPrincipal = httpContextAccessor?.HttpContext?.User;

    public string? UserId => _claimsPrincipal?.FindFirstValue("UserId");
    public string? Role => _claimsPrincipal?.FindFirstValue(ClaimTypes.Role);

    public string? UserName => _claimsPrincipal?.FindFirstValue(ClaimTypes.Name);

}
