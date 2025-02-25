using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.DoctorServices;
public static class DomainEvents
{
    public record DoctorServiceCreated(Guid IdEvent,Guid DoctorId,string DoctorName, List<EntityEvent.DoctorServiceEntity> entity) : IDomainEvent, ICommand;

    public record DoctorServiceDeleted(Guid IdEvent, List<Guid> DoctorServiceIds) : IDomainEvent, ICommand;
}