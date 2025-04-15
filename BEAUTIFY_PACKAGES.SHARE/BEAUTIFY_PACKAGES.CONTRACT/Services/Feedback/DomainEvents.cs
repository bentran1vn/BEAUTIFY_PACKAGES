using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Services.Feedback;

public class DomainEvents
{
    public record CreateFeedback(
        Guid IdEvent,
        FeedbackEvent.CreateFeedback entity
    ) : IDomainEvent, ICommand;
    
    public record UpdateFeedback(
        Guid IdEvent,
        FeedbackEvent.UpdateFeedback entity
    ) : IDomainEvent, ICommand;
    
    public record ViewActionFeedback(
        Guid IdEvent,
        FeedbackEvent.ViewActionFeedback entity
    ) : IDomainEvent, ICommand;
}