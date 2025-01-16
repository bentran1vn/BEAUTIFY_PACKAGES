using System.ComponentModel.DataAnnotations.Schema;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Aggregates;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Entities;
public class SystemTransaction : AggregateRoot<int>, IAuditableEntity
{
    public int ClinicId { get; set; }
    public virtual Clinic? Clinic { get; set; }
    public int SubscriptionPackageId { get; set; }
    public virtual SubscriptionPackage? SubscriptionPackage { get; set; }
    public DateTimeOffset TransactionDate { get; set; }
    [Column(TypeName = "decimal(18,2)")] public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; }
    public string? PaymentStatus { get; set; }
    
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}