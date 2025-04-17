using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.DoctorServices;
public static class DomainEvents
{
    public record DoctorServiceCreated(Guid IdEvent, List<EntityEvent.DoctorServiceEntity> entity)
        : IDomainEvent, ICommand;

    public record DoctorServiceDeleted(Guid IdEvent, Guid ServiceId, List<Guid> DoctorServiceIds)
        : IDomainEvent, ICommand;

    public record DoctorServiceUpdated(Guid IdEvent, EntityEvent.DoctorServiceEntity entity)
        : IDomainEvent, ICommand;
}