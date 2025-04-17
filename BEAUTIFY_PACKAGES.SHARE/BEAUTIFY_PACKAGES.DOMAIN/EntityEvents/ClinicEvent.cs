namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class ClinicEvent
{
    public record InActivatedClinic(Guid Id, bool IsActive, bool IsParent, Guid ParentId);
    public record ClinicUpdated(Clinic Clinic, bool IsParent);
    public record Clinic(
        Guid Id,
        string Name,
        string Email,
        string City,
        string Address,
        string FullAddress,
        TimeSpan WorkingTimeStart,
        TimeSpan WorkingTimeEnd,
        string District,
        string Ward,
        string PhoneNumber,
        string? ProfilePictureUrl,
        bool? IsParent,
        Guid? ParentId
    );

    public record ClinicDeleted(Guid ClinicId, bool IsParent);

}