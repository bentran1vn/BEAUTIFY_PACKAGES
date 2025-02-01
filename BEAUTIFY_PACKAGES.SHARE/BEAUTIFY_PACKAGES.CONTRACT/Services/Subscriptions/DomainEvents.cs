using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Subscriptions;
public static class DomainEvents
{
    public record SubscriptionCreated(
        Guid IdEvent,
        EntityEvent.SubscriptionEntity subscription
    ) : IDomainEvent, ICommand;

    public record SubscriptionUpdated(
        Guid IdEvent,
        EntityEvent.SubscriptionEntity subscription
    ) : IDomainEvent, ICommand;

    public record SubscriptionDeleted(
        Guid IdEvent,
        Guid SubscriptionId
    ) : IDomainEvent, ICommand;

    public record SubscriptionActivated(
        Guid IdEvent,
        Guid SubscriptionId
    ) : IDomainEvent, ICommand;

    public record SubscriptionDeactivated(
        Guid IdEvent,
        Guid SubscriptionId
    ) : IDomainEvent, ICommand;
}