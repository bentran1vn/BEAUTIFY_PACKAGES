using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Messages;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Repositories;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Documents;
using MassTransit;
using MediatR;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.INFRASTRUCTURE.Consumer.Abstractions.Messages;

public abstract class Consumer<TMessage>(ISender sender, IMongoRepository<EventProjection> repository)
    : IConsumer<TMessage>
    where TMessage : class, IDomainEvent
{
    public async Task Consume(ConsumeContext<TMessage> context)
    {
        // Find By EventId
        // => Exist Ignore
        // => Not Exist Send Event
        var eventProjection = await repository.FindOneAsync(e => e.EventId.Equals(context.Message.IdEvent));

        if (eventProjection is null)
        {
            await sender.Send(context.Message);

            Console.WriteLine(context.Message.ToString());

            eventProjection = new EventProjection
            {
                EventId = context.Message.IdEvent,
                Name = context.Message.GetType().Name,
                Type = context.Message.GetType().Name
            };
            await repository.InsertOneAsync(eventProjection);
        }
    }
}