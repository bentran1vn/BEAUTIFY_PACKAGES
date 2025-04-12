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
        public const string ORDER_IN_PROGRESS = "In Progress";
        public const string ORDER_COMPLETED = "Completed";
        public const string ORDER_UNCOMPLETED = "Uncompleted";
        public const string ORDER_WAITING_APPROVAL = "Waiting Approval";
        public const string ORDER_EXPIRED = "Expired";
    }

    public class SurveyQuestionType
    {
        public const string TEXT = "Text";
        public const string MULTIPLE_CHOICE = "Multiple Choice";
        public const string SINGLE_CHOICE = "Single Choice";
    }

    public class Policy
    {
        public const string POLICY_DOCTOR_AND_CUSTOMER = "Doctor and Customer";
        public const string POLICY_CLINIC_ADMIN_AND_CLINIC_STAFF = "Clinic Admin and Clinic Staff";
        public const string POLICY_SYSTEM_ADMIN = "System Admin";
        public const string POLICY_SYSTEM_STAFF = "System Staff";
        public const string POLICY_CLINIC_STAFF = "Clinic Staff";
    }
    //Test
}