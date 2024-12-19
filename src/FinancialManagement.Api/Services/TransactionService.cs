using FinancialManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialManagement.Api.Services
    {
    public class TransactionService : ITransactionService
        {
        private readonly FinancialManagementContext _context;

        public TransactionService(FinancialManagementContext context)
            {
            _context = context;
            }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync()
            {
            return await _context.Transactions.ToListAsync();
            }

        public async Task<Transaction> GetTransactionByIdAsync(int transactionId)
            {
            return await _context.Transactions.FindAsync(transactionId);
            }

        public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
            {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction;
            }

        public async Task UpdateTransactionAsync(Transaction transaction)
            {
            _context.Transactions.Update(transaction);
            await _context.SaveChangesAsync();
            }

        public async Task DeleteTransactionAsync(int transactionId)
            {
            var transaction = await _context.Transactions.FindAsync(transactionId);
            if (transaction != null)
                {
                _context.Transactions.Remove(transaction);
                await _context.SaveChangesAsync();
                }
            }
        }
    }
