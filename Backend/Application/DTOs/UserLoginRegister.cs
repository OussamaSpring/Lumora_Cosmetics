

using Enums;

namespace Application.DTOs
{
    public class LoginRequest
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }


    public class LoginResponse
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Enums.AccountStatus AccountStatus { get; set; }
        public UserRole Role { get; set; }
    }


    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Enums.UserRole Role { get; set; }
    }

    public class RegisterResponse
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Enums.UserRole Role { get; set; }
    }
}
