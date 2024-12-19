using FinancialManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Services
    {
    public class CategoryService : ICategoryService
        {
        private readonly FinancialManagementContext _context;

        public CategoryService(FinancialManagementContext context)
            {
            _context = context;
            }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
            {
            return await _context.Categories.ToListAsync();
            }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
            {
            return await _context.Categories.FindAsync(categoryId);
            }

        public async Task<Category> CreateCategoryAsync(Category category)
            {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
            }

        public async Task UpdateCategoryAsync(Category category)
            {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            }

        public async Task DeleteCategoryAsync(int categoryId)
            {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
                {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                }
            }
        }
    }
