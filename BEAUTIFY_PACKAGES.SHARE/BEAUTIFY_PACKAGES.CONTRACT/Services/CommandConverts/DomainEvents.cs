using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.CommandConverts;

public static class DomainEvents
{
    public record SubscriptionCreated(
        Guid IdEvent,
        string Query
    ) : IDomainEvent, ICommand;
}