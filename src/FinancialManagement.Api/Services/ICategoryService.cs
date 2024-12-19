using FinancialManagement.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Services
    {
    public interface ICategoryService
        {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int categoryId);
        Task<Category> CreateCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int categoryId);
        }
    }
