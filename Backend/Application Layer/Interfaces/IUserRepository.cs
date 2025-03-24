

using Domain.Entities;
using Domain.Entities.Vendor_Verification;

namespace Application_Layer.Interfaces
{

    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetByEmailAsync(string email);
    }
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
        Task<bool> UsernameExistsAsync(string username);
    }

}
