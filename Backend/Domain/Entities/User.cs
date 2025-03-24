
namespace Domain.Entities
{
    public class AccountStatus
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }

    public class UserRole
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }
    public class User
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public short AccountStatus { get; set; }
        public short RoleId { get; set; }
    }
}


