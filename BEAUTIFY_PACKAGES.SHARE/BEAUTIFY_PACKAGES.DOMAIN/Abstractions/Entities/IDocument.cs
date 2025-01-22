using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Abstractions.Entities;
public interface IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    ObjectId Id { get; set; }

    DateTime CreatedOnUtc { get; set; }
    DateTime? ModifiedOnUtc { get; }
}