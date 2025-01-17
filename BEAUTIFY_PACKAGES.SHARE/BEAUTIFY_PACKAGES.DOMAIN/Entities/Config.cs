using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Aggregates;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Entities;
public class Config : AggregateRoot<Guid>, IAuditableEntity
{
    public required string Key { get; set; }
    public required string Value { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}