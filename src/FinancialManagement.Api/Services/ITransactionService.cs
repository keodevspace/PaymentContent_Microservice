using FinancialManagement.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Services
    {
    public interface ITransactionService
        {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(int transactionId);
        Task<Transaction> CreateTransactionAsync(Transaction transaction);
        Task UpdateTransactionAsync(Transaction transaction);
        Task DeleteTransactionAsync(int transactionId);
        Task<IEnumerable<Transaction>> GetTransactionsByUserIdAsync(int userId); // Added missing method
        }
    }
