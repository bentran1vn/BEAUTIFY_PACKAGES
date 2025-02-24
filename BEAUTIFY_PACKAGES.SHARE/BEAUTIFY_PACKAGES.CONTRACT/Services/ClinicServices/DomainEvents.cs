using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.ClinicServices;

public class DomainEvents
{
    public record ClinicServiceCreated(
        Guid IdEvent,
        ClinicServiceEvent.CreateClinicService entity
    ) : IDomainEvent, ICommand;
    
    public record ClinicServiceUpdated(
        Guid IdEvent,
        ClinicServiceEvent.UpdateClinicService entity
    ) : IDomainEvent, ICommand;
}