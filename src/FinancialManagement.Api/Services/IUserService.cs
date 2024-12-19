using FinancialManagement.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Services
    {
    public interface IUserService
        {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task<User> CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int userId);
        }
    }
