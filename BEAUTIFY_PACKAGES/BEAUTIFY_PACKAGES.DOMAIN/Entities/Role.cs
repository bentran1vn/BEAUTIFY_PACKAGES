using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Aggregates;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Entities;
public class Role : AggregateRoot<int>, IAuditableEntity
{
    public required string Name { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}