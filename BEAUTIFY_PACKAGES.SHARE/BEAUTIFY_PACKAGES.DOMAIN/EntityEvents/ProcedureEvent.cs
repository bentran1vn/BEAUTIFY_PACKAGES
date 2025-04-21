namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public class ProcedureEvent
{
    public record CreateProcedure(
        Guid Id,
        Guid ServiceId,
        string ProcedureName,
        string Name,
        string Description,
        decimal MaxPrice,
        decimal MinPrice,
        decimal? DiscountMaxPrice,
        decimal? DiscountMinPrice,
        int StepIndex,
        ICollection<ProcedurePriceType> procedurePriceTypes
    );

    public record DeleteProcedure(
        Guid Id,
        Guid ServiceId,
        decimal MaxPrice,
        decimal MinPrice,
        decimal DiscountMaxPrice,
        decimal DiscountMinPrice);

    public record ProcedurePriceType(Guid Id, string Name, decimal Price, int Duration, bool IsDefault);
}