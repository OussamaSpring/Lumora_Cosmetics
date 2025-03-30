
using Npgsql;


using Domain.Entities;
using Application.Interfaces;


namespace Persistence.Repositories
{
    public class AdminAuthRepository : IAdminAuthRepository
    {
        public async Task<Admin> GetAdminByUsernameOrEmailAsync(string usernameOrEmail)
        {
            using (var connection = DatabaseHelper.CreateConnection())
            {
                await connection.OpenAsync();

                const string query = @"
        SELECT a.id, a.person_id, a.username, a.password, a.update_date, a.status, a.role
        FROM ""admin"" u
        JOIN person p ON a.person_id = p.id
        WHERE a.username = @usernameOrEmail OR p.email = @usernameOrEmail";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Admin
                            {
                                Id = reader.GetGuid(0),
                                PersonId = reader.GetGuid(1),
                                Username = reader.GetString(2),
                                Password = reader.GetString(3),
                                UpdateDate = reader.GetDateTime(4),
                                AccountStatus = (Enums.AccountStatus)reader.GetInt16(5),
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
