namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.CONTRACT.Abstractions.Shared;

public interface IValidationResult
{
    public static readonly Error ValidationError = new("Validation Error", "A validation error occured");
    Error[] Errors { get; }
}