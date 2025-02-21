namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class ProcedureEvent
{
    public record CreateProcedure(Guid Id, Guid ServiceId, string Name,
        string Description, decimal MaxPrice, decimal MinPrice,
        decimal? DiscountMaxPrice, decimal? DiscountMinPrice,
        int StepIndex, string[] coverImage, ICollection<ProcedurePriceType> procedurePriceTypes
    );

    public record ProcedurePriceType(Guid Id, string Name, decimal Price);
}