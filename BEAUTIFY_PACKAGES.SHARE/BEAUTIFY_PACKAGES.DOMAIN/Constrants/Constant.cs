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
        public const string CLINIC = "Clinic Admin";
        public const string ADMIN = "System Admin";
        public const string SYSTEM = "System Staff";
        public const string CLINIC_STAFF = "Clinic Staff";
    }


    public class OrderStatus
    {
        public const string ORDER_PENDING = "Pending";
        public const string ORDER_COMPLETED = "Completed";
        public const string ORDER_UNCOMPLETED = "Uncompleted";
    }
}
//Test