

using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> GetByEmailAsync(string email);
    }
    public interface IUserRepository
    {
    }
}
