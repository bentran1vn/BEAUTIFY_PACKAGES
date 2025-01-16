using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Users;

public static class Commands
{
    public record CreateUserCommand(string Name, string Email, string Password) : ICommand;

    public record UpdateUserCommand(Guid Id, string Name, decimal Price, string Description) : ICommand;

    public record DeleteUserCommand(Guid Id) : ICommand;
}