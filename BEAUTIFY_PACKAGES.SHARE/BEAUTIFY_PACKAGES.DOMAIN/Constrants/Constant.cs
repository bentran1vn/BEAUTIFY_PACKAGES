// ReSharper disable InconsistentNaming

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Constrants;
/// <summary>
/// Constant class
/// </summary>
public static class Constant
{
    #region Role

    public class Role
    {
        public const string DOCTOR = "Doctor";
        public const string CUSTOMER = "Customer";
        public const string CLINIC_ADMIN = "Clinic Admin";
        public const string SYSTEM_ADMIN = "System Admin";
        public const string SYSTEM_STAFF = "System Staff";
        public const string CLINIC_STAFF = "Clinic Staff";
    }

    #endregion

    #region OrderStatus

    public class OrderStatus
    {
        public const string ORDER_PENDING = "Pending";
        public const string ORDER_IN_PROGRESS = "In Progress";
        public const string ORDER_COMPLETED = "Completed";
        public const string ORDER_UNCOMPLETED = "Uncompleted";
        public const string ORDER_WAITING_APPROVAL = "Waiting Approval";
        public const string ORDER_EXPIRED = "Expired";
    }

    #endregion

    #region SurveyQuestionType

    public class SurveyQuestionType
    {
        public const string TEXT = "Text";
        public const string MULTIPLE_CHOICE = "Multiple Choice";
        public const string SINGLE_CHOICE = "Single Choice";
    }

    #endregion

    #region Policy

    public class Policy
    {
        public const string POLICY_DOCTOR_AND_CUSTOMER = "Doctor and Customer";
        public const string POLICY_CLINIC_ADMIN_AND_CLINIC_STAFF = "Clinic Admin and Clinic Staff";
        public const string POLICY_SYSTEM_ADMIN = "System Admin";
        public const string POLICY_SYSTEM_STAFF = "System Staff";
        public const string POLICY_CLINIC_STAFF = "Clinic Staff";
    }

    #endregion

    #region WalletConstants

    public static class WalletConstants
    {
        public static class WalletType
        {
            public const int SYSTEM = 0;
            public const int USER = 1;
            public const int CLINIC = 2;
        }

        public static class TransactionType
        {
            public const int DEPOSIT = 0;
            public const int WITHDRAWAL = 1;
            public const int TRANSFER = 2;
        }

        public static class TransactionStatus
        {
            public const int PENDING = 0;
            public const int COMPLETED = 1;
            public const int FAILED = 2;
            public const int CANCELLED = 3;
        }
    }

    #endregion

}