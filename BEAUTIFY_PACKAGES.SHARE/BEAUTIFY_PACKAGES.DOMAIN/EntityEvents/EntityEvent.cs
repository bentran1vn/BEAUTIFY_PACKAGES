namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;
public static class EntityEvent
{
    public class SubscriptionEntity
    {
        public DateTimeOffset Created;
        public string Description;
        public int Duration;
        public Guid Id;
        public bool IsActivated;
        public bool IsDeleted;
        public DateTimeOffset? ModifiedOnUtc;
        public string Name;
        public decimal Price;
        public int LimitBranch;
        public int LimitLiveStream;
    }

    public class WorkingScheduleEntity
    {
        public Guid Id;
        public Guid? DoctorId;
        public required Guid CustomerScheduleId;
        public Guid ClinicId;
        public DateTimeOffset? ModifiedOnUtc;
        public DateOnly Date;
        public TimeSpan StartTime;
        public TimeSpan EndTime;
        public bool IsDeleted;
        public CustomerScheduleEntity CustomerScheduleEntity;
        public string? Status;
        public string? Note;
    }

    public class CustomerScheduleEntity
    {
        public Guid Id;
        public Guid? CustomerId;
        public string CustomerName;
        public TimeSpan? StartTime;
        public TimeSpan? EndTime;
        public DateOnly? Date;
        public Guid? ServiceId;
        public string ServiceName;
        public Guid? DoctorId;
        public string? DoctorName;
        public Guid? ClinicId;
        public string ClinicName;
        public string Status;
        public string? DoctorNote;
        public ProcedurePriceTypeEntity CurrentProcedure;
        public ICollection<ProcedurePriceTypeEntity> CompletedProcedures;
        public ICollection<ProcedurePriceTypeEntity> PendingProcedures;
    }

    public class ProcedurePriceTypeEntity
    {
        public Guid Id;
        public string StepIndex;
        public string Name;
        public int Duration;
        public DateOnly? DateCompleted;
    }


    public class DoctorServiceEntity
    {
        public Guid Id;
        public Guid ServiceId;
        public UserEntity Doctor;
        public Guid ClinicId;
    }

    public class UserEntity
    {
        public Guid Id;
        public string FullName;
        public string Email;
        public string PhoneNumber;
        public string ProfilePictureUrl;
        public ICollection<CertificateEntity> DoctorCertificates;
    }

    //Final Test
    public class CertificateEntity
    {
        public Guid Id { get; set; }
        public string CertificateUrl { get; set; }
        public string CertificateName { get; set; }
        public DateTimeOffset? ExpiryDate { get; set; }
        public string? Note { get; set; }
    }
}