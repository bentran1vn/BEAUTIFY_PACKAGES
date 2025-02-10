using System.Security.Claims;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Repositories;
using Microsoft.AspNetCore.Http;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.API.DependencyInjection.Extensions;
public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    private readonly ClaimsPrincipal? _claimsPrincipal = httpContextAccessor?.HttpContext?.User;

    public Guid? UserId => Guid.Parse(_claimsPrincipal?.FindFirstValue("UserId") ?? string.Empty);
    public string? Role => _claimsPrincipal?.FindFirstValue(ClaimTypes.Role);

    public string? UserName => _claimsPrincipal?.FindFirstValue(ClaimTypes.Name);
    public Guid? ClinicId => Guid.Parse(_claimsPrincipal?.FindFirstValue("ClinicId") ?? string.Empty);

}
