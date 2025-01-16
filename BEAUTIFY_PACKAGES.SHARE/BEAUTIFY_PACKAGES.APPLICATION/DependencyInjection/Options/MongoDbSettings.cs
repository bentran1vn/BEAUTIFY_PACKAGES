namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.APPLICATION.DependencyInjection.Options;

public interface IMongoDbSettings
{
    string DatabaseName { get; set; }
    string ConnectionString { get; set; }
}

public class MongoDbSettings : IMongoDbSettings
{
    public string DatabaseName { get; set; }
    public string ConnectionString { get; set; }
}
