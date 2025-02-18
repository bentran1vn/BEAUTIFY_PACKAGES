namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public static class ClinicServiceEvent
{
    public record CreateClinicService(
        Guid Id, string Name, string Description,
        string[] CoverImage, string[] DescriptionImage,
        decimal Price, Category Category, ICollection<Clinic> Clinic);
    
    public record Category(Guid Id, string Name, string Description);
    
    public record Clinic(Guid Id, string Name, string Email, string Address,
        string PhoneNumber, string? ProfilePictureUrl, bool? IsParent, Guid? ParentId);
}