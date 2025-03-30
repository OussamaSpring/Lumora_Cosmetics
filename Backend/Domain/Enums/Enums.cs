
namespace Enums
{
    public enum AccountStatus
    {
        Active = 1,
        Suspended = 2,
        Closed = 3,
        Pending = 4
    }

    public enum UserRole
    {
        Customer = 1,
        Vendor = 2,
    }

    public enum Gender
    {
        Unknown = 1,
        Male = 2,
        Female = 3,
        Children = 4
    }

    public enum VerificationStatus
    {
        Pending = 1,
        Approved = 2,
        Rejected = 3
    }
}