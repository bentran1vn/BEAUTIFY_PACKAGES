using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.WorkingSchedules;
public static class DomainEvents
{
    public record WorkingScheduleCreated(
        Guid IdEvent,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities,string DoctorName) : IDomainEvent,ICommand;
    
    public record WorkingScheduleDeleted(Guid IdEvent,Guid WorkingId) : IDomainEvent,ICommand;
    
    public record WorkingScheduleUpdated(Guid IdEvent,List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities,string DoctorName) : IDomainEvent,ICommand;
}