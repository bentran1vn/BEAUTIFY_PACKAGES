namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class ProcedureEvent
{
    public record CreateProcedure(Guid Id, Guid ServiceId, string Name, string Description,
        int StepIndex, string[] coverImage, ICollection<ProcedurePriceType> procedurePriceTypes
    );

    public record ProcedurePriceType(Guid Id, string Name, decimal Price);
}