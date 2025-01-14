namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Exceptions;

public static class IdentityException
{
    public class TokenException : DomainException
    {
        public TokenException(string message) 
            : base("Token Exception", message)
        {
        }
    }
}