using FinancialManagement.Api.Models;
using FinancialManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace FinancialManagement.Api.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
        {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
            {
            _transactionService = transactionService;
            }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetTransactions(int userId)
            {
            var transactions = await _transactionService.GetTransactionsByUserIdAsync(userId);
            return Ok(transactions);
            }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction(FinancialTransaction transaction)
            {
            await _transactionService.CreateTransactionAsync(transaction);
            return CreatedAtAction(nameof(GetTransactions), new { id = transaction.Id }, transaction);
            }

        [HttpPost("{transactionId}/categories")]
        public async Task<IActionResult> AddCategoryToTransaction(int transactionId, [FromBody] int categoryId)
            {
            await _transactionService.AddCategoryToTransactionAsync(transactionId, categoryId);
            return Ok();
            }
        }
