using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Clinic;
public class DomainEvents
{
    public record DoctorFromClinicDeleted(
        Guid IdEvent,
        Guid IdDoctorService
    ) : IDomainEvent, ICommand;
}