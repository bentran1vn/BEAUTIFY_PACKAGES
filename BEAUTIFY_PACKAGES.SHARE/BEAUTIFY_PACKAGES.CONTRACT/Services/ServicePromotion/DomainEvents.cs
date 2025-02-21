using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.ServicePromotion;

public class DomainEvents
{
    
    public record ServicePromotionCreated(
        Guid IdEvent,
        PromotionEvent.CreateServicePromotion entity
    ) : IDomainEvent, ICommand;
    
    public record ServicePromotionUpdated(
        Guid IdEvent,
        PromotionEvent.UpdateServicePromotion entity
    ) : IDomainEvent, ICommand;
    
    public record ServicePromotionDeleted(
        Guid IdEvent,
        PromotionEvent.RemoveServicePromotion entity
    ) : IDomainEvent, ICommand;
}