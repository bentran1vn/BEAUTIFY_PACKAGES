// ReSharper disable InconsistentNaming

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Constrants;
/// <summary>
/// Constant class
/// </summary>
public static class Constant
{
    public class Role
    {
        public const string DOCTOR = "Doctor";
        public const string CUSTOMER = "Customer";
        public const string CLINIC_ADMIN = "Clinic Admin";
        public const string SYSTEM_ADMIN = "System Admin";
        public const string SYSTEM_STAFF = "System Staff";
        public const string CLINIC_STAFF = "Clinic Staff";
    }


    public class OrderStatus
    {
        public const string ORDER_PENDING = "Pending";
        public const string ORDER_COMPLETED = "Completed";
        public const string ORDER_UNCOMPLETED = "Uncompleted";
    }
}
