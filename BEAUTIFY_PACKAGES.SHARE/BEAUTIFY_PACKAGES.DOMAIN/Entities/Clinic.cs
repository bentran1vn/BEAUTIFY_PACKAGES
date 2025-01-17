using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Aggregates;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Entities;
public class Clinic : AggregateRoot<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public int? TotalBranches { get; set; }
    public int? Status { get; set; }
    public string? TaxCode { get; set; }
    public string? BusinessLicenseUrl { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public required string Address { get; set; }
    public required string PhoneNumber { get; set; }
    public string? OperatingLicenseUrl { get; set; }
    public DateTimeOffset? OperatingLicenseExpiryDate { get; set; }
    public string? Description { get; set; }
    public bool IsActivated { get; set; } = false;
    public bool IsMain { get; set; } = false;
    public Guid? MainClinicId { get; set; }
    public virtual Clinic? MainClinic { get; set; }

    public int ClinicOnBoardingRequestId { get; set; }
    public virtual ClinicOnBoardingRequest? ClinicOnBoardingRequest { get; set; }

    public virtual ICollection<SystemTransaction>? SystemTransactions { get; set; } = [];

    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}