using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string GetBalance()
        {
            DataContext db = new();

            if (db.Transactions == null || db.Users == null)
            {
                throw new Exception("Database not initialized");
            }

            var deposits = db.Transactions.Where(t => t.AccountID == Id).Where(t => t.TransactionType == TransactionType.Income).Sum(t => (double)t.TransactionAmount);
            var withdravals = db.Transactions.Where(t => t.AccountID == Id).Where(t => t.TransactionType == TransactionType.Expense).Sum(t => (double)t.TransactionAmount);

            var balance = deposits - withdravals;

            return Math.Round(balance, 2).ToString();
        }
    }
}