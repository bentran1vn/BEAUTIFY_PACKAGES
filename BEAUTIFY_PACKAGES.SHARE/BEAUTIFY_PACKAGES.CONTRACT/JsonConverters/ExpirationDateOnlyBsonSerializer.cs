using System.Globalization;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.JsonConverters;

public class ExpirationDateOnlyBsonSerializer : SerializerBase<DateOnly>
{
    private const string Format = "MM/yy";

    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, DateOnly value)
        => context.Writer.WriteString(value.ToString(Format, CultureInfo.InvariantCulture));

    public override DateOnly Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        => DateOnly.ParseExact(context.Reader.ReadString(), Format, CultureInfo.InvariantCulture);
}