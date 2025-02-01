namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public class EntityEvent
{
    public class SubscriptionEntity
    {
        DateTimeOffset Created;
        string Description;
        int Duration;
        Guid Id;
        bool IsActivated;
        bool IsDeleted;
        DateTimeOffset? ModifiedOnUtc;
        string Name;
        decimal Price;
    }
}