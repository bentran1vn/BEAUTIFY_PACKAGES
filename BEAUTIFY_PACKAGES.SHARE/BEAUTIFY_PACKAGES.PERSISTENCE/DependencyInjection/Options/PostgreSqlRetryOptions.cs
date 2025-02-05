namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.PERSISTENCE.DependencyInjection.Options;

public record PostgreSqlRetryOptions
{
    public int MaxRetryCount { get; set; } = 5;
    public TimeSpan MaxRetryDelay { get; set; } = TimeSpan.FromSeconds(5);
}