namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class PromotionEvent
{
    public record CreateServicePromotion(
        Guid ServiceId,
        string Name,
        double DiscountPercent,
        string ImageUrl,
        decimal DiscountMaxPrice,
        decimal DiscountMinPrice,
        DateTime StartDay,
        DateTime EndDate);
    
    public record UpdateServicePromotion(
        Guid ServiceId,
        Guid PromotionId,
        string Name,
        double DiscountPercent,
        string ImageUrl,
        decimal DiscountMaxPrice,
        decimal DiscountMinPrice,
        DateTime StartDay,
        DateTime EndDate);
    
    public record RemoveServicePromotion(
        Guid ServiceId,
        Guid PromotionId);
}