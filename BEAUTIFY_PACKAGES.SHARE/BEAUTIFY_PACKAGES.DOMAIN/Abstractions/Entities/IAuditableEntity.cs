namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

public interface IAuditableEntity
{
    DateTimeOffset CreatedOnUtc { get; set; }

    DateTimeOffset? ModifiedOnUtc { get; set; }
}