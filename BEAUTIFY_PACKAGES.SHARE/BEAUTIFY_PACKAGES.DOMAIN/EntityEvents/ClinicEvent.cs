namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class ClinicEvent
{
    public record InActivatedClinic(Guid Id, bool IsActive, bool IsParent, Guid? ParentId);
}