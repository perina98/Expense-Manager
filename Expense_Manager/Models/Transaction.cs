using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models
{
    public class Transaction
    {
        public Transaction()
        {
            TransactionDate = DateTime.Now;
        }

        [Key]
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public string TransactionDescription { get; set; }
        public TransactionCategory TransactionCategory { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
