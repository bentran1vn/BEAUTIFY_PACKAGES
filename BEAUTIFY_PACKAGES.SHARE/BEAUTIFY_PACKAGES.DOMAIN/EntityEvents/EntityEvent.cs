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
        public int LimitBranch;
        public int LimitLiveStream;
        public DateTimeOffset? ModifiedOnUtc;
        public string Name;
        public decimal Price;
    }

    public class WorkingScheduleEntity
    {
        public Guid ClinicId;
        public CustomerScheduleEntity? CustomerScheduleEntity;
        public Guid? CustomerScheduleId;
        public DateOnly Date;
        public Guid? DoctorId;
        public TimeSpan EndTime;
        public Guid Id;
        public bool IsDeleted;
        public DateTimeOffset? ModifiedOnUtc;
        public string? Note;
        public TimeSpan StartTime;
        public string? Status;
        public Guid? ShiftGroupId { get; set; }
        public int? ShiftCapacity { get; set; }
    }

    public class CustomerScheduleEntity
    {
        public Guid? ClinicId;
        public string ClinicName;
        public ICollection<ProcedurePriceTypeEntity> CompletedProcedures;
        public ProcedurePriceTypeEntity CurrentProcedure;
        public Guid? CustomerId;
        public string CustomerName;
        public DateOnly? Date;
        public Guid? DoctorId;
        public string? DoctorName;
        public string? DoctorNote;
        public TimeSpan? EndTime;
        public Guid Id;
        public Guid OrderId;
        public ICollection<ProcedurePriceTypeEntity> PendingProcedures;
        public Guid? ServiceId;
        public string ServiceName;
        public TimeSpan? StartTime;
        public string Status;
    }

    public class ProcedurePriceTypeEntity
    {
        public DateOnly? DateCompleted;
        public int Duration;
        public Guid Id;
        public string Name;
        public string ProcedureName;
        public string StepIndex;
    }


    public class DoctorServiceEntity
    {
        public Guid ClinicId;
        public UserEntity Doctor;
        public Guid Id;
        public Guid ServiceId;
        public double Rating;
    }

    public class UserEntity
    {
        public ICollection<CertificateEntity> DoctorCertificates;
        public string Email;
        public string FullName;
        public Guid Id;
        public string PhoneNumber;
        public string ProfilePictureUrl;
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