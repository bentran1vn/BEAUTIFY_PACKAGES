namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Attributes;
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class BsonCollectionAttribute : Attribute
{
    public BsonCollectionAttribute(string collectionName)
    {
        CollectionName = collectionName;
    }

    public string CollectionName { get; }
}