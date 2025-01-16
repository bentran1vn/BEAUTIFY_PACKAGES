namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Shared;

public  interface ICacheable
{
    bool BypassCache { get; }
    string CacheKey { get; }
    int SlidingExpirationInMinutes { get; }
    int AbsoluteExpirationInMinutes { get; }
}