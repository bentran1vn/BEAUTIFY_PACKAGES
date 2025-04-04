using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.CustomerSchedules;
public static class DomainEvents
{
    public record CustomerScheduleCreated(
        Guid IdEvent,
        EntityEvent.CustomerScheduleEntity entity
    ) : IDomainEvent, ICommand;

    //delete
    public record CustomerScheduleDeleted(
        Guid IdEvent,
        Guid IdCustomerSchedule
    ) : IDomainEvent, ICommand;

    public record CustomerScheduleUpdateAfterPaymentCompleted(Guid IdEvent, Guid IdCustomerSchedule, string Status)
        : IDomainEvent, ICommand;

    public record CustomerScheduleUpdatedDoctorNote(
        Guid IdEvent,
        Guid IdCustomerSchedule,
        string DoctorNote
    ) : IDomainEvent, ICommand;

    public record CustomerScheduleUpdateDateAndTimeAndStatus(
        Guid IdEvent,
        Guid IdCustomerSchedule,
        TimeSpan StartTime,
        TimeSpan EndTime,
        DateOnly Date,
        string Status
    ) : IDomainEvent, ICommand;
}