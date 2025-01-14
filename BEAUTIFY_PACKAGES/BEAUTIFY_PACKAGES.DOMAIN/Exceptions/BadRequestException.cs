namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Exceptions;

public abstract class BadRequestException : DomainException
{
    protected BadRequestException(string message)
        : base("Bad Request", message)
    {
    }
}