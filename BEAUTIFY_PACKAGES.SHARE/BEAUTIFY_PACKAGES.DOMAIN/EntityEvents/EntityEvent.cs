namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public class EntityEvent
{
    public class SubscriptionEntity
    {
        private DateTimeOffset Created;
        private string Description;
        private int Duration;
        private Guid Id;
        private bool IsActivated;
        private bool IsDeleted;
        private DateTimeOffset? ModifiedOnUtc;
        private string Name;
        private decimal Price;
    }
}