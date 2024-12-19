using System.Collections.Generic;

namespace FinancialManagement.Api.Models
    {
    public class Transaction
        {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        // Relacionamento com User
        public User User { get; set; }

        // Relacionamento com Categories via tabela de junção
        public ICollection<Category> Categories { get; set; }
        }
    }
