using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Clinic;
public class DomainEvents
{
    public record DoctorFromClinicDeleted(
        Guid IdEvent,
        Guid IdDoctor
    ) : IDomainEvent, ICommand;
    
    public record ClinicBranchActivatedAction(
        Guid IdEvent,
        ClinicEvent.InActivatedClinic entity
    ) : IDomainEvent, ICommand;
    
    public record ClinicUpdated( 
        Guid IdEvent,
        ClinicEvent.ClinicUpdated entity
    ) : IDomainEvent, ICommand;
    
    public record ClinicDeleted( 
        Guid IdEvent,
        ClinicEvent.ClinicDeleted entity
    ) : IDomainEvent, ICommand;
}