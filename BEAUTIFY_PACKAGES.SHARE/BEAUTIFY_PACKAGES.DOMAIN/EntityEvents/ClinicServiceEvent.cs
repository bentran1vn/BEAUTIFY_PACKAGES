namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public static class ClinicServiceEvent
{
    public record CreateClinicService(
        Guid Id,
        string Name,
        string Description,
        Image[] CoverImages,
        Image[] DescriptionImages,
        Category Category,
        ICollection<Clinic> Clinic);

    public record Category(Guid Id, string Name, string Description);

    public record Clinic(
        Guid Id,
        string Name,
        string Email,
        string City,
        string Address,
        string District,
        string Ward,
        string PhoneNumber,
        string? ProfilePictureUrl,
        bool? IsParent,
        Guid? ParentId);

    public record Image(Guid Id, int Index, string Url);

    public record UpdateClinicService(
        Guid Id,
        string Name,
        string Description,
        Image[] CoverImages,
        Image[] DescriptionImages,
        Category Category,
        ICollection<Clinic> Clinic);
}