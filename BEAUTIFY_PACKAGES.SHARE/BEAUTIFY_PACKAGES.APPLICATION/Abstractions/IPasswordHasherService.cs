namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.APPLICATION.Abstractions;

public interface IPasswordHasherService
{
    public string HashPassword(string password);

    public bool VerifyPassword(string password, string hashedPassword);
}