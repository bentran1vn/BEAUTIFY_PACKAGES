using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Procedures;

public class DomainEvents
{
    public record ProcedureCreated(
        Guid IdEvent,
        ProcedureEvent.CreateProcedure entity
    ) : IDomainEvent, ICommand;
}