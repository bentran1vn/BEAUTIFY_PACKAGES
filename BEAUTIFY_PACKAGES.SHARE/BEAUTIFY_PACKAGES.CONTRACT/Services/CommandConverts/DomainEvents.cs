using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.CommandConverts;

public static class DomainEvents
{
    public record PostgreMigrate(
        Guid IdEvent,
        string EntityType,
        object PrimaryKey,
        string Operation,
        string Data
    ) : IDomainEvent, ICommand;
}