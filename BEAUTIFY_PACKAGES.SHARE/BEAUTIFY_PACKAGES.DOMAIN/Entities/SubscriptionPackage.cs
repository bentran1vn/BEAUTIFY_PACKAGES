using System.ComponentModel.DataAnnotations.Schema;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Aggregates;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Entities;
public class SubscriptionPackage : AggregateRoot<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    [Column(TypeName = "decimal(18,2)")] public required decimal Price { get; set; }
    public required int Duration { get; set; }
    public bool IsActivated { get; set; } = false;
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}