namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public class EntityEvent
{
    public class SubscriptionEntity
    {
        public DateTimeOffset Created;
        public string Description;
        public int Duration;
        public Guid Id;
        public bool IsActivated;
        public bool IsDeleted;
        public DateTimeOffset? ModifiedOnUtc;
        public string Name;
        public decimal Price;
    }
}