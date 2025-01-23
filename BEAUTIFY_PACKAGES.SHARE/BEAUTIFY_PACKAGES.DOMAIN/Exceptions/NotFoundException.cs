namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Exceptions;
public abstract class NotFoundException : DomainException
{
    protected NotFoundException(string message)
        : base("Not Found", message)
    {
    }
}