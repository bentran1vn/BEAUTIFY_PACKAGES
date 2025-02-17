using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.WorkingSchedules;
public static class DomainEvents
{
    public record WorkingScheduleCreated(
        Guid IdEvent,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities) : IDomainEvent;
}