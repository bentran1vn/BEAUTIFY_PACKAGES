using MongoDB.Bson;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;
public abstract class Document : IDocument
{
    public Guid DocumentId { get; set; } // Id cua SourceMessage: ProductID, CustomerID, OrderI
    public ObjectId Id { get; set; }
    public DateTime CreatedOnUtc { get; set; }

    public DateTime? ModifiedOnUtc { get; set; }
}