

using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAdminAuthRepository
    {
        Task<Admin> GetAdminByUsernameOrEmailAsync(string usernameOrEmail); // return null if not found

    }
}
