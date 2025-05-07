using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.WorkingSchedules;
public static class DomainEvents
{
    public record ClinicEmptyScheduleCreated(
        Guid IdEvent,
        Guid Id,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities,
        string ClinicName) : IDomainEvent, ICommand;

    public record ClinicScheduleCapacityChanged(
        Guid IdEvent,
        Guid ShiftGroupId,
        int OldCapacity,
        int NewCapacity,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities
    ) : IDomainEvent, ICommand;

    public record DoctorScheduleRegistered(
        Guid IdEvent,
        Guid DoctorId,
        string DoctorName,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities
    ) : IDomainEvent, ICommand;

    public record DoctorScheduleChangedSingle(
        Guid IdEvent,
        EntityEvent.WorkingScheduleEntity entity,
        string DoctorName) : IDomainEvent, ICommand;

    public record DoctorScheduleChangedMultiple(
        Guid IdEvent,
        List<EntityEvent.WorkingScheduleEntity> entity,
        string DoctorName) : IDomainEvent, ICommand;

    public record DoctorScheduleStatusChanged(
        Guid IdEvent,
        List<Guid> WorkingScheduleId,
        string Status) : IDomainEvent, ICommand;

    #region NoUse

    public record WorkingScheduleCreated(
        Guid IdEvent,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities,
        string DoctorName) : IDomainEvent, ICommand;

    public record WorkingScheduleDeleted(Guid IdEvent, Guid WorkingId) : IDomainEvent, ICommand;

    public record WorkingScheduleUpdated(
        Guid IdEvent,
        List<EntityEvent.WorkingScheduleEntity> WorkingScheduleEntities,
        string DoctorName) : IDomainEvent, ICommand;

    #endregion
}