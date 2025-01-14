using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Users;

public static class Queries
{
    public record GetUsersQuery(string? SearchTerm, string? SortColumn) : IQuery<List<Responses.UserResponse>>;

    public record GetProductById(Guid Id) : IQuery<List<Responses.UserResponse>>;
}